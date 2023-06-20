using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultarPacientes
{
    public partial class FrmConsultaPaciente : Form
    {
        public FrmConsultaPaciente()
        {
            InitializeComponent();
        }
        public void ConsultaPaciente(DataGridView dataGridView)
        {

            dataGridView.Rows.Clear();

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultaDAO dao = new ConsultaDAO(connection);
                List<ConsultaModel> consultas = dao.ConsultarPaciente(new ConsultaModel()
                {
                    nomePaciente = txtNome.Text,
                    rg = mskRg.Text,
                    cpf = mskCpf.Text,
                    prontuario = txtProntuario.Text,
                    exibir = Convert.ToInt32(txtExibir.Text),
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
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaPaciente(dadosGrid);
        }
    }
}
