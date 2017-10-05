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
    public partial class AddTreino : Form
    {
        public AddTreino()
        {
            InitializeComponent();

            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtNome.Enabled = false;
            txtDificuldade.Enabled = false;

        }

        //STRING DE CONEXÃO 
        //Instancia||Objeto de conexão
        SqlConnection sqlConnection = null;
        //String caminho de conexão SQLSERVER
        private string strConnection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Academia;Data Source=DANTAS-PC";
        //String com os comandos SQL passado para o SGDB para execução
        private string strSql = string.Empty; //strSql

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            txtDescricao.Enabled = true;
            txtNome.Enabled = true;
            txtDificuldade.Enabled = true;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            strSql = "INSERT INTO treinos (nome, descricao, nivel_dificuldade) values (@nome, @descricao, @nivelDificuldade)";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@descricao", SqlDbType.VarChar).Value = txtDescricao.Text;
            comando.Parameters.Add("@nivelDificuldade", SqlDbType.VarChar).Value = txtDificuldade.Text;

            try
            {
                sqlConnection.Open();

                comando.ExecuteNonQuery();
                MessageBox.Show("Treino cadastrado com sucesso!!!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                sqlConnection.Close();

                txtNome.Clear();
                txtDescricao.Clear();
                txtDificuldade.Clear();
                txtCodigo.Clear();

                txtCodigo.Enabled = false;
                txtDescricao.Enabled = false;
                txtNome.Enabled = false;
                txtDificuldade.Enabled = false;
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            strSql = "UPDATE treinos SET nome=@nome,descricao=@descricao,nivel_dificuldade=@nivelDificuldade" +
                " WHERE cod_treino=@codigo";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@codigo", SqlDbType.Int).Value = txtCodigo.Text;
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@descricao", SqlDbType.VarChar).Value = txtDescricao.Text;
            comando.Parameters.Add("@nivelDificuldade", SqlDbType.VarChar).Value = txtDificuldade.Text;

            

            try
            {
                sqlConnection.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Dados alterados com sucesso!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();

                txtNome.Clear();
                txtDescricao.Clear();
                txtDificuldade.Clear();
                txtCodigo.Clear();

                txtCodigo.Enabled = false;
                txtDescricao.Enabled = false;
                txtNome.Enabled = false;
                txtDificuldade.Enabled = false;


            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            strSql = "SELECT * FROM treinos WHERE cod_treino=@pesquisa";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txtPesquisa.Text;

            try
            {
                if (txtPesquisa.Text == string.Empty)
                {
                    MessageBox.Show("Digite o codigo de um treino para pesquisa!");
                }

                sqlConnection.Open();

                //Instanciando obejto para para leitura dos campos do banco
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Treino não cadastrado!");
                }

                dr.Read();

                txtNome.Text = Convert.ToString(dr["nome"]);
                txtCodigo.Text = Convert.ToString(dr["cod_treino"]);
                txtDescricao.Text = Convert.ToString(dr["descricao"]);
                txtDificuldade.Text = Convert.ToString(dr["nivel_dificuldade"]);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                sqlConnection.Close();
            }

            txtPesquisa.Clear();

            txtDescricao.Enabled = true;
            txtNome.Enabled = true;
            txtDificuldade.Enabled = true;

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            strSql = "DELETE FROM treinos WHERE cod_treino=@codigo";
            sqlConnection = new SqlConnection(strConnection);

            SqlCommand comando = new SqlCommand(strSql, sqlConnection);

            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = txtCodigo.Text;

            try
            {
                sqlConnection.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Treino deletado com sucesso!");
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            finally
            {
                sqlConnection.Close();

                txtNome.Clear();
                txtDescricao.Clear();
                txtDificuldade.Clear();
                txtCodigo.Clear();

                txtCodigo.Enabled = false;
                txtDescricao.Enabled = false;
                txtNome.Enabled = false;
                txtDificuldade.Enabled = false;

            }

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListaTreinos tabela = new ListaTreinos();
            tabela.Show();
        }
    }
}
