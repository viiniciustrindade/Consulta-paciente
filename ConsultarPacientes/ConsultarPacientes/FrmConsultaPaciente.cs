using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsultarPacientes
{
    public partial class FrmConsultaPaciente : Form
    {
        public FrmConsultaPaciente()
        {
            InitializeComponent();
        }
        private void ConsultaPaciente(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultaDAO dao = new ConsultaDAO(connection);
                List<ConsultaModel> consultas = dao.ConsultarPaciente(new ConsultaModel()
                {
                    nomePaciente = txtNome.Text,
                    rg = mskRg.Text.Replace(".", "").Replace("-", ""),
                    cpf = mskCpf.Text.Replace(".", "").Replace("-", ""),
                    prontuario = txtProntuario.Text,
                    exibir = Convert.ToInt32(txtExibir.Text),
                    alta = CheckBoxAlta(),
                    obito = CheckBoxObito(),
                    internado = CheckBoxInternado(),
                    evasao = CheckBoxEvasao(),
                });
                foreach (ConsultaModel consulta in consultas)
                {
                    DataGridViewRow row = dataGridView.Rows[dataGridView.Rows.Add()];
                    row.Cells[colNomePaciente.Index].Value = consulta.nomePaciente;
                    row.Cells[colRg.Index].Value = consulta.rg;
                    row.Cells[colCpf.Index].Value = consulta.cpf;
                    row.Cells[colDataNasc.Index].Value = consulta.dataNasc;
                    row.Cells[colMae.Index].Value = consulta.mae;
                    row.Cells[colProntuario.Index].Value = consulta.prontuario;
                    row.Cells[coloLocalizacao.Index].Value = consulta.localizacao;
                    row.Cells[colLeito.Index].Value = consulta.leito;
                    row.Cells[colSituacao.Index].Value = consulta.situacao;
                }
            }
        }
        private string CheckBoxAlta()
        {
            string checkBox;
            if (cbAlta.Checked == true)
            {
                checkBox = cbAlta.Text;
            }
            else
            {
                checkBox = "";
            }
            return checkBox;
        }

        private string CheckBoxInternado()
        {
            string checkBox;
            if (cbInternado.Checked == true)
            {
                checkBox = cbInternado.Text;
            }
            else
            {
                checkBox = "";
            }
            return checkBox;
        }
        private string CheckBoxObito()
        {
            string checkBox;
            if (cbObito.Checked == true)
            {
                checkBox = cbObito.Text;
            }
            else
            {
                checkBox = "";
            }
            return checkBox;
        }
        private string CheckBoxEvasao()
        {
            string checkBox;
            if (cbEvasao.Checked == true)
            {
                checkBox = cbEvasao.Text;
            }
            else
            {
                checkBox = "";
            }
            return checkBox;
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaPaciente(dadosGrid);
        }
        private void mskCpf_TextChanged(object sender, EventArgs e)
        {
            string cpf = new string(mskCpf.Text.Where(char.IsDigit).ToArray());
            if (cpf.Length >= 11)
            {

                cpf = cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
            mskCpf.Text = cpf;
        }
        private void mskRg_TextChanged(object sender, EventArgs e)
        {
            string rg = new string(mskRg.Text.Where(char.IsDigit).ToArray());
            if (rg.Length >= 9)
            {
                rg = rg.Insert(2, ".").Insert(6, ".").Insert(10, "-");
            }

            mskRg.Text = rg;
        }
        private void FrmConsultaPaciente_Load(object sender, EventArgs e)
        {
            MaxCaraceteres();
        }
        private void MaxCaraceteres()
        {
            mskRg.MaxLength = 9;
            mskCpf.MaxLength = 11;
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            FrmGrafico grafico = new FrmGrafico();
            grafico.Show();
        }
    }
}
