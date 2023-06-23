using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarPacientes
{
    public class ConsultaDAO
    {
        private SqlConnection Connection { get; }
        public ConsultaDAO(SqlConnection connection)
        {
            Connection = connection;
        }
        public List<ConsultaModel> ConsultarPaciente(ConsultaModel consulta)
        {
            List<ConsultaModel> consultas = new List<ConsultaModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql2 = new StringBuilder();
                sql2.AppendLine("SELECT TOP (@exibir) p.nomePaciente, p.rgPaciente, p.cpfPaciente, p.dataNascPaciente, p.nomeMaePaciente, r.codProntuario, r.localizacao, r.leito, p.situacao");
                sql2.AppendLine("FROM mvtHospCadPac p INNER JOIN mvtHospRegInt r ON p.codPaciente = r.codPaciente");
                sql2.AppendLine("WHERE 1 = 1");

                if (!string.IsNullOrEmpty(consulta.nomePaciente))
                {
                    sql2.AppendLine("AND p.nomePaciente LIKE '%' + @nomePaciente + '%'");
                    command.Parameters.Add(new SqlParameter("@nomePaciente", consulta.nomePaciente));
                }
                if (!string.IsNullOrEmpty(consulta.rg))
                {
                    sql2.AppendLine("AND p.rgPaciente LIKE '%' + @rg + '%'");
                    command.Parameters.AddWithValue("@rg", consulta.rg);
                }
                if (!string.IsNullOrEmpty(consulta.cpf))
                {
                    sql2.AppendLine("AND p.cpfPaciente LIKE '%' + @cpf + '%'");
                    command.Parameters.AddWithValue("@cpf", consulta.cpf);
                }
                if (!string.IsNullOrEmpty(consulta.prontuario))
                {
                    sql2.AppendLine("AND r.codProntuario LIKE '%' + @prontuario + '%'");
                    command.Parameters.AddWithValue("@prontuario", consulta.prontuario);
                }

                if (!string.IsNullOrEmpty(consulta.alta) || !string.IsNullOrEmpty(consulta.evasao) || !string.IsNullOrEmpty(consulta.internado) || !string.IsNullOrEmpty(consulta.obito))
                {
                    sql2.AppendLine("AND (");
                    bool isConditionAdded = false;

                    if (!string.IsNullOrEmpty(consulta.alta))
                    {
                        sql2.AppendLine("p.situacao LIKE '%' + @alta + '%'");
                        command.Parameters.AddWithValue("@alta", consulta.alta);
                        isConditionAdded = true;
                    }
                    if (!string.IsNullOrEmpty(consulta.evasao))
                    {
                        if (isConditionAdded)
                            sql2.AppendLine("OR");
                        sql2.AppendLine("p.situacao LIKE '%' + @evasao + '%'");
                        command.Parameters.AddWithValue("@evasao", consulta.evasao);
                        isConditionAdded = true;
                    }
                    if (!string.IsNullOrEmpty(consulta.internado))
                    {
                        if (isConditionAdded)
                            sql2.AppendLine("OR");
                        sql2.AppendLine("p.situacao LIKE '%' + @internado + '%'");
                        command.Parameters.AddWithValue("@internado", consulta.internado);
                        isConditionAdded = true;
                    }
                    if (!string.IsNullOrEmpty(consulta.obito))
                    {
                        if (isConditionAdded)
                            sql2.AppendLine("OR");
                        sql2.AppendLine("p.situacao LIKE '%' + @obito + '%'");
                        command.Parameters.AddWithValue("@obito", consulta.obito);
                    }  

                    sql2.AppendLine(")");
                }

                command.Parameters.AddWithValue("@exibir", consulta.exibir);
                command.CommandText = sql2.ToString();

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        consultas.Add(PopulateDr(dr));
                    }
                }

                return consultas;
            }
        }
        public int ContaAltas()
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(situacao) FROM mvtHospCadPac WHERE situacao = 'Alta'");
                command.CommandText = sql.ToString();
                int countAlta = Convert.ToInt32(command.ExecuteScalar());
                return countAlta;
            }
        }  
        public int ContaObitos()
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(situacao) FROM mvtHospCadPac WHERE situacao = 'Óbito'");
                command.CommandText = sql.ToString();
                int countObitos = Convert.ToInt32(command.ExecuteScalar());
                return countObitos;
            }
        }      
        public int ContaInternados()
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(situacao) FROM mvtHospCadPac WHERE situacao = 'Internado'");
                command.CommandText = sql.ToString();
                int countInternado = Convert.ToInt32(command.ExecuteScalar());
                return countInternado;
            }
        }       
        public int ContaEvasoes()
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(situacao) FROM mvtHospCadPac WHERE situacao = 'Evasão'");
                command.CommandText = sql.ToString();
                int countEvasoes = Convert.ToInt32(command.ExecuteScalar());
                return countEvasoes;
            }
        }

        private ConsultaModel PopulateDr(SqlDataReader dr)
        {
            ConsultaModel model = new ConsultaModel();

            if (DBNull.Value != dr["nomePaciente"])
            {
                model.nomePaciente = dr["nomePaciente"].ToString();
            }
            if (DBNull.Value != dr["rgPaciente"])
            {
                string rg = dr["rgPaciente"].ToString();
                if (rg.Length == 9)
                {
                    rg = $"{rg.Substring(0, 2)}.{rg.Substring(2, 3)}.{rg.Substring(5, 3)}-{rg.Substring(8)}";
                }
                model.rg = rg;
            }
            if (DBNull.Value != dr["cpfPaciente"])
            {
                string cpf = dr["cpfPaciente"].ToString();
                if (cpf.Length == 11)
                {
                    cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";
                }
                model.cpf = cpf;
            }
            if (DBNull.Value != dr["dataNascPaciente"])
            {
                model.dataNasc = dr["dataNascPaciente"].ToString().Substring(0, 10);
            }
            if (DBNull.Value != dr["nomeMaePaciente"])
            {
                model.mae = dr["nomeMaePaciente"].ToString();
            }
            if (DBNull.Value != dr["codProntuario"])
            {
                model.prontuario = dr["codProntuario"].ToString();
            }
            if (DBNull.Value != dr["localizacao"])
            {
                model.localizacao = dr["localizacao"].ToString();
            }
            if (DBNull.Value != dr["leito"])
            {
                model.leito = dr["leito"].ToString();
            }
            if (DBNull.Value != dr["situacao"])
            {
                model.situacao = dr["situacao"].ToString();
            }
            return model;
        }
    }
}

