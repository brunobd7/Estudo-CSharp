using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void aDICIONARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAluno cadastro = new AddAluno();
            cadastro.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTreino treinoJanela = new AddTreino();
            treinoJanela.ShowDialog();
        }

        private void cADASTROToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
