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
            //Cria um novo formul�rio
            Form frmCadastroCliente = new frmCadastroCliente();

            //Define quem � o pai dessa janela
            frmCadastroCliente.MdiParent = this;

            //Exibe o formul�rio
            frmCadastroCliente.Show();
        }
    }
}