using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividademenu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sobreNósToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Loja SP foi fundada em 2025 com a intenção de produzir peças de qualidade a um preço acessivel.", "Sobre Nós" );
        }
    }
}
