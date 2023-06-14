namespace ACRRentalCar
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblCPF = new Label();
            lblDtNasc = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            btnIncluir = new Button();
            btAlterar = new Button();
            btnExcluir = new Button();
            btnConsultar = new Button();
            btnFechar = new Button();
            mskDtNasc = new MaskedTextBox();
            msk_CPF = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(22, 27);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(25, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(156, 27);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(28, 15);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF";
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(337, 27);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(98, 15);
            lblDtNasc.TabIndex = 4;
            lblDtNasc.Text = "Data Nascimento";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(25, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(415, 23);
            txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(22, 83);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(25, 148);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 5;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btAlterar
            // 
            btAlterar.Location = new Point(106, 148);
            btAlterar.Name = "btAlterar";
            btAlterar.Size = new Size(75, 23);
            btAlterar.TabIndex = 6;
            btAlterar.Text = "Alterar";
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(187, 148);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(268, 148);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(365, 148);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // mskDtNasc
            // 
            mskDtNasc.Location = new Point(340, 48);
            mskDtNasc.Mask = "00/00/0000";
            mskDtNasc.Name = "mskDtNasc";
            mskDtNasc.Size = new Size(100, 23);
            mskDtNasc.TabIndex = 3;
            // 
            // msk_CPF
            // 
            msk_CPF.Location = new Point(156, 48);
            msk_CPF.Mask = "999,999,999-99";
            msk_CPF.Name = "msk_CPF";
            msk_CPF.Size = new Size(145, 23);
            msk_CPF.TabIndex = 2;
            msk_CPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 193);
            Controls.Add(msk_CPF);
            Controls.Add(mskDtNasc);
            Controls.Add(btnFechar);
            Controls.Add(btnConsultar);
            Controls.Add(btnExcluir);
            Controls.Add(btAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblDtNasc);
            Controls.Add(lblCPF);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "frmCadastroCliente";
            Text = "frmCadastroCliente";
            Load += frmCadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox mskCPF;
        private Label lblCPF;
        private TextBox textBox3;
        private Label lblDtNasc;
        private Label lblNome;
        private Button btnIncluir;
        private Button btAlterar;
        private Button btnExcluir;
        private Button btnConsultar;
        private Button btnFechar;
        public TextBox txtCodigo;
        public TextBox txtNome;
        public MaskedTextBox mskDtNasc;
        public MaskedTextBox msk_CPF;
    }
}