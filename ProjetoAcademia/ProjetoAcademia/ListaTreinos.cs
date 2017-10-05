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
    public partial class ListaTreinos : Form
    {
        SqlConnection sqlConnection = null;
        //String caminho de conexão SQLSERVER
        private string strConnection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Academia;Data Source=DANTAS-PC";
        //String com os comandos SQL passado para o SGDB para execução
        private string strSql = string.Empty; //strSql

        public ListaTreinos()
        {
            InitializeComponent();

            InitializeComponent();

            strSql = "SELECT * FROM treinos";
            SqlDataAdapter da = new SqlDataAdapter(strSql, strConnection);

            DataSet tbl = new DataSet();
            SqlCommandBuilder comando = new SqlCommandBuilder(da);
            da.Fill(tbl);

            tblTreinos.DataSource = tbl.Tables[0];

        }


    }
}
