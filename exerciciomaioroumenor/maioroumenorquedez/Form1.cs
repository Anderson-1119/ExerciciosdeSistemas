using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maioroumenorquedez
{
    public partial class frmMaioroumenor : Form
    {
        public frmMaioroumenor()
        {
            InitializeComponent();
        }

        private void btnMaiorouMenor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMaioroumenor.Text, out int num))
            {

                if (num > 10)
                {
                    MessageBox.Show("o valor é maior que 10");
                }
                else if (num < 10)
                {
                    MessageBox.Show("o valor é menor que 10");
                }
                else if (num == 10)
                {
                    MessageBox.Show("o valor é 10");
                }
            }
            else
            {
                MessageBox.Show("insira um numero valido");
            }
            
            
        }
    }
}
