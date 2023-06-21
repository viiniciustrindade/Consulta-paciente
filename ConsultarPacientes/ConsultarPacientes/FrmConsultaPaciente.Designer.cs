namespace ConsultarPacientes
{
    partial class FrmConsultaPaciente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPaciente));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.colNomePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProntuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloLocalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProntuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.TextBox();
            this.mskRg = new System.Windows.Forms.TextBox();
            this.txtExibir = new System.Windows.Forms.NumericUpDown();
            this.cbAlta = new System.Windows.Forms.CheckBox();
            this.cbObito = new System.Windows.Forms.CheckBox();
            this.cbInternado = new System.Windows.Forms.CheckBox();
            this.cbEvasao = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExibir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultar.Location = new System.Drawing.Point(481, 164);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 27);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomePaciente,
            this.colRg,
            this.colCpf,
            this.colDataNasc,
            this.colMae,
            this.colProntuario,
            this.coloLocalizacao,
            this.colLeito,
            this.colSituacao});
            this.dadosGrid.Location = new System.Drawing.Point(17, 197);
            this.dadosGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(656, 197);
            this.dadosGrid.TabIndex = 32;
            // 
            // colNomePaciente
            // 
            this.colNomePaciente.HeaderText = "Nome paciente";
            this.colNomePaciente.MinimumWidth = 6;
            this.colNomePaciente.Name = "colNomePaciente";
            this.colNomePaciente.ReadOnly = true;
            // 
            // colRg
            // 
            this.colRg.HeaderText = "Rg";
            this.colRg.MinimumWidth = 6;
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "Cpf";
            this.colCpf.MinimumWidth = 6;
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colDataNasc
            // 
            this.colDataNasc.HeaderText = "Data de nascimento";
            this.colDataNasc.MinimumWidth = 6;
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            // 
            // colMae
            // 
            this.colMae.HeaderText = "Mae";
            this.colMae.MinimumWidth = 6;
            this.colMae.Name = "colMae";
            this.colMae.ReadOnly = true;
            // 
            // colProntuario
            // 
            this.colProntuario.HeaderText = "Prontuario";
            this.colProntuario.MinimumWidth = 6;
            this.colProntuario.Name = "colProntuario";
            this.colProntuario.ReadOnly = true;
            // 
            // coloLocalizacao
            // 
            this.coloLocalizacao.HeaderText = "Localização";
            this.coloLocalizacao.MinimumWidth = 6;
            this.coloLocalizacao.Name = "coloLocalizacao";
            this.coloLocalizacao.ReadOnly = true;
            // 
            // colLeito
            // 
            this.colLeito.HeaderText = "Leito";
            this.colLeito.MinimumWidth = 6;
            this.colLeito.Name = "colLeito";
            this.colLeito.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.MinimumWidth = 6;
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafico.Location = new System.Drawing.Point(580, 164);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(93, 27);
            this.btnGrafico.TabIndex = 12;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Exibir";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Location = new System.Drawing.Point(91, 102);
            this.txtProntuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(49, 22);
            this.txtProntuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Prontuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Rg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cpf";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 14);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(91, 43);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(115, 22);
            this.mskCpf.TabIndex = 2;
            this.mskCpf.TextChanged += new System.EventHandler(this.mskCpf_TextChanged);
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(91, 73);
            this.mskRg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(115, 22);
            this.mskRg.TabIndex = 3;
            this.mskRg.TextChanged += new System.EventHandler(this.mskRg_TextChanged);
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(91, 133);
            this.txtExibir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExibir.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.Size = new System.Drawing.Size(79, 22);
            this.txtExibir.TabIndex = 5;
            this.txtExibir.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbAlta
            // 
            this.cbAlta.AutoSize = true;
            this.cbAlta.Location = new System.Drawing.Point(8, 23);
            this.cbAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAlta.Name = "cbAlta";
            this.cbAlta.Size = new System.Drawing.Size(52, 20);
            this.cbAlta.TabIndex = 7;
            this.cbAlta.Text = "Alta";
            this.cbAlta.UseVisualStyleBackColor = true;
            // 
            // cbObito
            // 
            this.cbObito.AutoSize = true;
            this.cbObito.Location = new System.Drawing.Point(8, 52);
            this.cbObito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbObito.Name = "cbObito";
            this.cbObito.Size = new System.Drawing.Size(61, 20);
            this.cbObito.TabIndex = 8;
            this.cbObito.Text = "Óbito";
            this.cbObito.UseVisualStyleBackColor = true;
            // 
            // cbInternado
            // 
            this.cbInternado.AutoSize = true;
            this.cbInternado.Location = new System.Drawing.Point(8, 80);
            this.cbInternado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbInternado.Name = "cbInternado";
            this.cbInternado.Size = new System.Drawing.Size(85, 20);
            this.cbInternado.TabIndex = 9;
            this.cbInternado.Text = "Internado";
            this.cbInternado.UseVisualStyleBackColor = true;
            // 
            // cbEvasao
            // 
            this.cbEvasao.AutoSize = true;
            this.cbEvasao.Location = new System.Drawing.Point(8, 108);
            this.cbEvasao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEvasao.Name = "cbEvasao";
            this.cbEvasao.Size = new System.Drawing.Size(76, 20);
            this.cbEvasao.TabIndex = 10;
            this.cbEvasao.Text = "Evasão";
            this.cbEvasao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbAlta);
            this.groupBox1.Controls.Add(this.cbEvasao);
            this.groupBox1.Controls.Add(this.cbObito);
            this.groupBox1.Controls.Add(this.cbInternado);
            this.groupBox1.Location = new System.Drawing.Point(481, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(191, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Situação";
            // 
            // FrmConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtExibir);
            this.Controls.Add(this.mskRg);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProntuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultaPaciente";
            this.Text = "Consulta de Pacientes";
            this.Load += new System.EventHandler(this.FrmConsultaPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExibir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMae;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProntuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloLocalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeito;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSituacao;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProntuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mskCpf;
        private System.Windows.Forms.TextBox mskRg;
        private System.Windows.Forms.NumericUpDown txtExibir;
        private System.Windows.Forms.CheckBox cbAlta;
        private System.Windows.Forms.CheckBox cbObito;
        private System.Windows.Forms.CheckBox cbInternado;
        private System.Windows.Forms.CheckBox cbEvasao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

