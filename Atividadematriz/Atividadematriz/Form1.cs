using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividadematriz
{
    public partial class frmMatriz : Form
    {
        double[,] matriz = new double[3, 3];
        int i = 0;
        int j = 0;
        public frmMatriz()
        {
            InitializeComponent();
        }

        private void txtValores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                matriz[i, j] = double.Parse(txtValores.Text);
                j++;

                if (j == 3)
                {
                    i++;
                    j = 0;
                }
                txtValores.Text = "";
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    txtquadro.Text += matriz[i, j].ToString() + " ";
                }
                txtquadro.Text += Environment.NewLine;
            }
        }

        private void btnMaiorValor_Click(object sender, EventArgs e)
        {
            double maior = double.MinValue;

            foreach (var valor in matriz)
            {
                if (valor > maior)
                {
                    maior = valor;
                }
            }
            txtVerificacao.Text = $"maior:" + maior.ToString(); // envia o Maior valor para a TextVerificação no lado inferior esquerdo.
            MessageBox.Show($"O Maior Valor na matriz é {maior}", "Maior Valor"); // Exibe na Show Box
        }

        private void btnMenorValor_Click(object sender, EventArgs e)
        {
            double menor = double.MaxValue;
            foreach (var valor in matriz)
            {
                if (valor < menor)
                {
                    menor = valor;
                }
            }
            txtVerificacao.Text += $"{Environment.NewLine}Menor: {menor}"; // envia o Menor valor para a TextVerificação no lado inferior esquerdo.
            MessageBox.Show($"O Menor Valor na matriz é {menor}", "Menor Valor"); // Exibe na Show Box
        }
    }

}
