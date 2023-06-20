using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
                sql2.AppendLine("SELECT TOP (@exibir) p.nomePaciente, p.rgPaciente, p.cpfPaciente, p.dataNascPaciente, p.nomeMaePaciente, r.codProntuario, r.localizacao, r.leito, r.situacao");
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
        private ConsultaModel PopulateDr(SqlDataReader dr)
        {
            ConsultaModel model = new ConsultaModel();

            if (DBNull.Value != dr["nomePaciente"])
            {
                model.nomePaciente = dr["nomePaciente"].ToString();
            }
            if (DBNull.Value != dr["rgPaciente"])
            {
                model.rg = dr["rgPaciente"].ToString();
            }
            if (DBNull.Value != dr["cpfPaciente"])
            {
                model.cpf = dr["cpfPaciente"].ToString();
            }
            if (DBNull.Value != dr["dataNascPaciente"])
            {
                model.dataNasc = dr["dataNascPaciente"].ToString();
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

