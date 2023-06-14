namespace ACRRentalCar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria um novo formulário
            Form frmCadastroCliente = new frmCadastroCliente();

            //Define quem é o pai dessa janela
            frmCadastroCliente.MdiParent = this;

            //Exibe o formulário
            frmCadastroCliente.Show();
        }
    }
}