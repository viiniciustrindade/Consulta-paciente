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
using System.Windows.Forms.DataVisualization.Charting;

namespace ConsultarPacientes
{
    public partial class FrmGrafico : Form
    {
        public FrmGrafico()
        {
            InitializeComponent();
        }

        private void FrmGrafico_Load(object sender, EventArgs e)
        {
            Grafico();
        }
        private void Grafico()
        {
            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Brown;
            title.Text = "Situações pacientes";
            chart1.Titles.Add(title);

            chart1.Series.Add("Situações");

            chart1.Series["Situações"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Situações"].BorderWidth = 4;
            chart1.Series["Situações"].CustomProperties = "PointWidth=0.6"; // Define a largura das colunas

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false; // Remove as linhas verticais do fundo

            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ConsultaDAO dao = new ConsultaDAO(connection);
                int altas = dao.ContaAltas();
                chart1.Series["Situações"].Points.AddXY("Altas", altas);
                chart1.Series["Situações"].Points[0].Color = Color.Green; // Define a cor da coluna "Altas"
                chart1.Series["Situações"].Points[0].Label = altas.ToString(); // Adiciona o valor em cima da coluna "Altas"

                int internados = dao.ContaInternados();
                chart1.Series["Situações"].Points.AddXY("Internados", internados);
                chart1.Series["Situações"].Points[1].Color = Color.Yellow; // Define a cor da coluna "Internados"
                chart1.Series["Situações"].Points[1].Label = internados.ToString(); // Adiciona o valor em cima da coluna "Internados"

                int evasoes = dao.ContaEvasoes();
                chart1.Series["Situações"].Points.AddXY("Evasões", evasoes);
                chart1.Series["Situações"].Points[2].Color = Color.Red; // Define a cor da coluna "Evasões"
                chart1.Series["Situações"].Points[2].Label = evasoes.ToString(); // Adiciona o valor em cima da coluna "Evasões"

                int obitos = dao.ContaObitos();
                chart1.Series["Situações"].Points.AddXY("Óbitos", obitos);
                chart1.Series["Situações"].Points[3].Color = Color.Black; // Define a cor da coluna "Óbitos"
                chart1.Series["Situações"].Points[3].Label = obitos.ToString(); // Adiciona o valor em cima da coluna "Óbitos"
            }
        }
    }
}
