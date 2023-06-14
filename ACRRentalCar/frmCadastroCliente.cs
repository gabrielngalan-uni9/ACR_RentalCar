using System.Data.SqlClient;

namespace ACRRentalCar
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        //Sub-rotina para habilitar os controles
        private void Habilitar()
        {
            //txtCodigo sempre será desabilitado
            txtCodigo.Enabled = false;

            //Alterar a propriedade Enabled dos controles para true, habilitando o controle
            txtNome.Enabled = true;
            msk_CPF.Enabled = true;
            mskDtNasc.Enabled = true;
        }

        //Sub-rotina para desabilitar os controles
        private void Desabilitar()
        {
            //txtCodigo sempre será desabilitado
            txtCodigo.Enabled = false;

            //Alterar a propriedade Enabled dos controles para true, habilitando o controle
            txtNome.Enabled = false;
            msk_CPF.Enabled = false;
            mskDtNasc.Enabled = false;
        }

        //Sub-rotina para limpar os controles do formulário
        private void LimparControles()
        {
            //Desabilitar o TextBox
            txtCodigo.Enabled = false;

            //Limpa os textos do TextBoc e do MaskedTextBox
            txtNome.Clear();
            txtCodigo.Clear();
            msk_CPF.Clear();
            mskDtNasc.Clear();

            //Coloca o foco no mskCPF
            msk_CPF.Focus();
        }

        //Função para validar os campos de entrada
        //Retorna True or False

        private bool ValidaDados()
        {
            //Verificar se mskCPF está preenchido, se não estiver
            if (string.IsNullOrEmpty(msk_CPF.Text))
            {
                //Mensagem ao usuário
                MessageBox.Show("Preenchimento de campo obrigatóio", "ACR Rental Car");

                //Limpa o mskCPF
                msk_CPF.Clear();

                //Coloca o cursor no mskCPF
                msk_CPF.Focus();

                return false;
            }

            //Validação Data de Nascimento
            DateTime auxData; //variável auxiliar

            if (!(DateTime.TryParse(mskDtNasc.Text, out auxData)))
            {
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car");
                mskDtNasc.Clear();
                mskDtNasc.Focus();
                return false;
            }

            //Verifica se o txtNome está preenchido, Se for nulo ou vazio retorna falso
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Preenchimento de campo obrigatório", "ACR Rental Car");
                txtNome.Clear();
                txtNome.Focus();
                return false;
            }

            //Se todas as validações passarem no teste, retorna verdadeiro
            return true;
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            //Chamar função para habilitar os controles
            Habilitar();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                //se txtCodigo não estiver vazio, significa que já foi consultado um cliente.
                // a instrução a seguir captura se foi clicado o botão Yes (SIM) como resposta da pergunta.
                if (MessageBox.Show("Você está editando um registro existente. Deseja incluir um registro novo?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    LimparControles();
                return;   //encerra a sub-rotina
            }

            //antes de incluir é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento para incluir no banco de dados

            if (ValidaDados() == false)
            {
                return;  //interrompe a sub-rotina
            }

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            //cria a instrução sql, parametrizada
            sqlQuery = "INSERT INTO cliente(nome,data_nasc,cpf) VALUES(@nome,@data_nasc,@cpf)";

            //Tratamento de exceções
            try
            {
                //abre a conexão com o banco de dados
                conCliente.Open();

                //cria um objeto do tipo SqlCommand com a instrução SQL e a conexão
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", msk_CPF.Text));

                //executa o commando
                //ExecuteNonQuery envia instruções para o banco de dados que estão em cmd
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente incluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                LimparControles();
            }
            catch (Exception ex)  // se houve alguma exceção dentro do bloco try
            {
                MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally  // independente se houve exceção ou não o bloco try é sempre executado
            {
                //se conexão não for nula, fecha conexão
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            //os campos para serem alterados são preenchidos por meio da consulta no grid do form Consulta de Cliente
            //verifica se tem o código do cliente no txtCodigo. Se o campo estiver vazio, interrompe a sub-rotina
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja alterar clicando no botão consultar", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;   //interrompe a sub-rotina
            }

            // antes de alterar o registro é preciso validar os dados de preenchimento obrigatório
            //chama o método para validar a entrada de dados
            //se retornou falso, interrompe o processamento
            if (ValidaDados() == false)
            {
                return;
            }

            //declaração da variável para guardar as instruções SQL
            string sqlQuery;

            //cria conexão chamando o método getConnection da classe Conexao
            SqlConnection conCliente = Conexao.getConnection();

            //cria a instrução sql, parametrizada
            sqlQuery = "UPDATE cliente set nome=@nome,data_nasc=@data_nasc,cpf=@cpf WHERE id_cliente=@id_cliente";

            //Tratamento de exceções 
            //códigos semelhantes ao botão inserir com diferença na instrução SQL
            try
            {
                conCliente.Open();
                SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);
                //define, adiciona os parametros
                cmd.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                cmd.Parameters.Add(new SqlParameter("@data_nasc", Convert.ToDateTime(mskDtNasc.Text)));
                cmd.Parameters.Add(new SqlParameter("@cpf", msk_CPF.Text));
                cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                //executa o comando
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpa os campos para nova entrada de dados
                LimparControles();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Problema ao alterar cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (conCliente != null)
                {
                    conCliente.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //veririfica se tem o código do cliente no txtCodigo
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Consulte o cliente que deseja excluir clicando no botão consultar", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //solicita confirmação de exclusão de registro
            if (MessageBox.Show("Deseja excluir permanentemente o registro?", "ACR Rental Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //declaração da variável para guardar as instruções SQL
                string sqlQuery;

                //cria conexão chamando o método getConnection da classe Conexao
                SqlConnection conCliente = Conexao.getConnection();

                //cria a instrução sql, parametrizada
                sqlQuery = "DELETE FROM cliente WHERE id_cliente=@id_cliente";

                //Tratamento de exceções
                try
                {
                    conCliente.Open();
                    SqlCommand cmd = new SqlCommand(sqlQuery, conCliente);

                    //define, adiciona os parametros
                    cmd.Parameters.Add(new SqlParameter("@id_cliente", Convert.ToInt32(txtCodigo.Text)));

                    //executa o commando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluído com sucesso", "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpa os campos para nova entrada de dados
                    LimparControles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao incluir cliente " + ex, "ACR Rental Car", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (conCliente != null)
                    {
                        conCliente.Close();
                    }
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //Cria um novo formulário de frmConsultaCliente, passando como parâmetro uma referência deste form
            Form frm = new frmConsultaCliente(this);

            // Define quem é o pai dessa janela
            frm.MdiParent = MdiParent;

            // Exibe o formulário
            frm.Show();
        }
    }
}
