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
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExibir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(361, 112);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(70, 22);
            this.btnConsultar.TabIndex = 33;
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
            this.dadosGrid.Location = new System.Drawing.Point(13, 139);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(492, 178);
            this.dadosGrid.TabIndex = 32;
            // 
            // colNomePaciente
            // 
            this.colNomePaciente.HeaderText = "Nome paciente";
            this.colNomePaciente.Name = "colNomePaciente";
            this.colNomePaciente.ReadOnly = true;
            // 
            // colRg
            // 
            this.colRg.HeaderText = "Rg";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "Cpf";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colDataNasc
            // 
            this.colDataNasc.HeaderText = "Data de nascimento";
            this.colDataNasc.Name = "colDataNasc";
            this.colDataNasc.ReadOnly = true;
            // 
            // colMae
            // 
            this.colMae.HeaderText = "Mae";
            this.colMae.Name = "colMae";
            this.colMae.ReadOnly = true;
            // 
            // colProntuario
            // 
            this.colProntuario.HeaderText = "Prontuario";
            this.colProntuario.Name = "colProntuario";
            this.colProntuario.ReadOnly = true;
            // 
            // coloLocalizacao
            // 
            this.coloLocalizacao.HeaderText = "Localização";
            this.coloLocalizacao.Name = "coloLocalizacao";
            this.coloLocalizacao.ReadOnly = true;
            // 
            // colLeito
            // 
            this.colLeito.HeaderText = "Leito";
            this.colLeito.Name = "colLeito";
            this.colLeito.ReadOnly = true;
            // 
            // colSituacao
            // 
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(435, 112);
            this.btnGrafico.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(70, 22);
            this.btnGrafico.TabIndex = 31;
            this.btnGrafico.Text = "Grafico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Exibir";
            // 
            // txtProntuario
            // 
            this.txtProntuario.Location = new System.Drawing.Point(68, 83);
            this.txtProntuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtProntuario.Name = "txtProntuario";
            this.txtProntuario.Size = new System.Drawing.Size(38, 20);
            this.txtProntuario.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Prontuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Rg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cpf";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 11);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 20);
            this.txtNome.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(68, 35);
            this.mskCpf.Margin = new System.Windows.Forms.Padding(2);
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(87, 20);
            this.mskCpf.TabIndex = 34;
            // 
            // mskRg
            // 
            this.mskRg.Location = new System.Drawing.Point(68, 59);
            this.mskRg.Margin = new System.Windows.Forms.Padding(2);
            this.mskRg.Name = "mskRg";
            this.mskRg.Size = new System.Drawing.Size(87, 20);
            this.mskRg.TabIndex = 35;
            // 
            // txtExibir
            // 
            this.txtExibir.Location = new System.Drawing.Point(68, 108);
            this.txtExibir.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtExibir.Name = "txtExibir";
            this.txtExibir.Size = new System.Drawing.Size(59, 20);
            this.txtExibir.TabIndex = 40;
            this.txtExibir.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // FrmConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 328);
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
            this.Name = "FrmConsultaPaciente";
            this.Text = "Consulta de Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExibir)).EndInit();
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
    }
}

