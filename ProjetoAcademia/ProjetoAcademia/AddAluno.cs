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

namespace ProjetoAcademia
{
    public partial class AddAluno : Form
    {
        public AddAluno()
        {
            InitializeComponent();

            txtNome.Enabled= false;
            txtIdade.Enabled = false;
            txtPeso.Enabled = false;
            txtAltura.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            txtCpf.Enabled = false;
            txtCodigo.Enabled = false;


        }
        //STRING DE CONEXÃO 
        //Instancia||Objeto de conexão
        SqlConnection sqlConnection = null; 
        //String caminho de conexão SQLSERVER
        private string strConnection= "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Academia;Data Source=DANTAS-PC";
        //String com os comandos SQL passado para o SGDB para execução
        private string strSql = string.Empty; //strSql
        /////////////////////////////////


        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            txtPeso.Enabled = true;
            txtAltura.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtCpf.Enabled = true;
           // txtCodigo.Enabled = true;


            //strSql = "INSERT INTO alunos (nome,idade,peso,altura,endereco,telefone,cpf) values (@nome,@idade,@peso,@altura,@endereco,@telefone,@cpf)";
            //sqlConnection = new SqlConnection(strConnection);

            //SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            //comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            //comando.Parameters.Add("@idade", SqlDbType.VarChar).Value = txtIdade.Text;
            //comando.Parameters.Add("@peso", SqlDbType.VarChar).Value = txtPeso.Text;
            //comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = txtAltura.Text;
            //comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            //comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            //comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCpf.Text;

            //try
            //{
            //    sqlConnection.Open();

            //    comando.ExecuteNonQuery();

            //    MessageBox.Show("Cadastro efetuado com sucesso !");
            //}
            //catch(Exception erro)
            //{
            //    MessageBox.Show(erro.Message);

            //}

            //finally
            //{
            //    sqlConnection.Close();

            //    txtNome.Clear();
            //    txtIdade.Clear();
            //    txtPeso.Clear();
            //    txtAltura.Clear();
            //    txtEndereco.Clear();
            //    txtTelefone.Clear();
            //    txtCpf.Clear();

            //}

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            strSql = "SELECT * FROM alunos WHERE cod_cliente=@pesquisa";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtPesquisa.Text;

            try
            {
                if(txtPesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Digite o codigo de um aluno para pesquisar !");
                }

                sqlConnection.Open();

                //Instanciando obejto para para leitura dos campos do banco
                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows== false)
                {
                    throw new Exception("Aluno não está cadastrado!");
                }

                dr.Read();

                txtNome.Text = Convert.ToString(dr["nome"]);
                txtIdade.Text = Convert.ToString(dr["idade"]);
                txtPeso.Text = Convert.ToString(dr["peso"]);
                txtAltura.Text = Convert.ToString(dr["altura"]);
                txtEndereco.Text = Convert.ToString(dr["endereco"]);
                txtTelefone.Text = Convert.ToString(dr["telefone"]);
                txtCpf.Text = Convert.ToString(dr["cpf"]);
                txtCodigo.Text = Convert.ToString(dr["cod_cliente"]);
                
            } catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                sqlConnection.Close();
            }

            txtPesquisa.Clear();

            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            txtPeso.Enabled = true;
            txtAltura.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            txtCpf.Enabled = true;
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            strSql = "UPDATE alunos SET nome=@nome, idade=@idade, peso=@peso, altura=@altura, endereco=@endereco," +
                "telefone=@telefone, cpf=@cpf WHERE cod_cliente=@codigo";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCodigo.Text;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@idade", SqlDbType.VarChar).Value = txtIdade.Text;
            comando.Parameters.Add("@peso", SqlDbType.VarChar).Value = txtPeso.Text;
            comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = txtAltura.Text;
            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCpf.Text;

            try
            {
                sqlConnection.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso!");

                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();

                txtNome.Clear();
                txtIdade.Clear();
                txtPeso.Clear();
                txtAltura.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtCodigo.Clear();
                

            }



        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM alunos WHERE cod_cliente=@codigo";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;

            try
            {
                sqlConnection.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Exclusão realizada com sucesso");
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                sqlConnection.Close();

                txtNome.Clear();
                txtIdade.Clear();
                txtPeso.Clear();
                txtAltura.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtCodigo.Clear();
                                
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO alunos (nome,idade,peso,altura,endereco,telefone,cpf) values (@nome,@idade,@peso,@altura,@endereco,@telefone,@cpf)";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@idade", SqlDbType.VarChar).Value = txtIdade.Text;
            comando.Parameters.Add("@peso", SqlDbType.VarChar).Value = txtPeso.Text;
            comando.Parameters.Add("@altura", SqlDbType.VarChar).Value = txtAltura.Text;
            comando.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtEndereco.Text;
            comando.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = txtCpf.Text;

            try
            {
                sqlConnection.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso !");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

            finally
            {
                sqlConnection.Close();

                txtNome.Clear();
                txtIdade.Clear();
                txtPeso.Clear();
                txtAltura.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtCodigo.Clear();

                txtNome.Enabled = false;
                txtIdade.Enabled = false;
                txtPeso.Enabled = false;
                txtAltura.Enabled = false;
                txtEndereco.Enabled = false;
                txtTelefone.Enabled = false;
                txtCpf.Enabled = false;

            }
        }

        private void bntListar_Click(object sender, EventArgs e)
        {

            ListaAlunos lista = new ListaAlunos();
            lista.Show();
        }
    }
}
