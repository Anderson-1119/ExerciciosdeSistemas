
namespace Atividadematriz
{
    partial class frmMatriz
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.txtVerificacao = new System.Windows.Forms.TextBox();
            this.txtquadro = new System.Windows.Forms.TextBox();
            this.btnMenorValor = new System.Windows.Forms.Button();
            this.btnMaiorValor = new System.Windows.Forms.Button();
            this.panelDireito = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtValores = new System.Windows.Forms.TextBox();
            this.lblTextoDigite = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.panelEsquerdo.SuspendLayout();
            this.panelDireito.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.BackColor = System.Drawing.Color.OrangeRed;
            this.panelEsquerdo.Controls.Add(this.txtVerificacao);
            this.panelEsquerdo.Controls.Add(this.txtquadro);
            this.panelEsquerdo.Controls.Add(this.btnMenorValor);
            this.panelEsquerdo.Controls.Add(this.btnMaiorValor);
            this.panelEsquerdo.Location = new System.Drawing.Point(8, 8);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(388, 432);
            this.panelEsquerdo.TabIndex = 0;
            // 
            // txtVerificacao
            // 
            this.txtVerificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVerificacao.Location = new System.Drawing.Point(104, 317);
            this.txtVerificacao.Multiline = true;
            this.txtVerificacao.Name = "txtVerificacao";
            this.txtVerificacao.Size = new System.Drawing.Size(146, 54);
            this.txtVerificacao.TabIndex = 3;
            // 
            // txtquadro
            // 
            this.txtquadro.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquadro.Location = new System.Drawing.Point(89, 28);
            this.txtquadro.Multiline = true;
            this.txtquadro.Name = "txtquadro";
            this.txtquadro.Size = new System.Drawing.Size(170, 118);
            this.txtquadro.TabIndex = 2;
            // 
            // btnMenorValor
            // 
            this.btnMenorValor.BackColor = System.Drawing.Color.Olive;
            this.btnMenorValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorValor.ForeColor = System.Drawing.Color.White;
            this.btnMenorValor.Location = new System.Drawing.Point(113, 250);
            this.btnMenorValor.Name = "btnMenorValor";
            this.btnMenorValor.Size = new System.Drawing.Size(122, 45);
            this.btnMenorValor.TabIndex = 1;
            this.btnMenorValor.Text = "Menor Valor";
            this.btnMenorValor.UseVisualStyleBackColor = false;
            this.btnMenorValor.Click += new System.EventHandler(this.btnMenorValor_Click);
            // 
            // btnMaiorValor
            // 
            this.btnMaiorValor.BackColor = System.Drawing.Color.Olive;
            this.btnMaiorValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaiorValor.ForeColor = System.Drawing.Color.White;
            this.btnMaiorValor.Location = new System.Drawing.Point(113, 172);
            this.btnMaiorValor.Name = "btnMaiorValor";
            this.btnMaiorValor.Size = new System.Drawing.Size(122, 46);
            this.btnMaiorValor.TabIndex = 0;
            this.btnMaiorValor.Text = "Maior Valor";
            this.btnMaiorValor.UseVisualStyleBackColor = false;
            this.btnMaiorValor.Click += new System.EventHandler(this.btnMaiorValor_Click);
            // 
            // panelDireito
            // 
            this.panelDireito.BackColor = System.Drawing.Color.OrangeRed;
            this.panelDireito.Controls.Add(this.lblEnter);
            this.panelDireito.Controls.Add(this.btnEnviar);
            this.panelDireito.Controls.Add(this.txtValores);
            this.panelDireito.Controls.Add(this.lblTextoDigite);
            this.panelDireito.Location = new System.Drawing.Point(402, 8);
            this.panelDireito.Name = "panelDireito";
            this.panelDireito.Size = new System.Drawing.Size(388, 432);
            this.panelDireito.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.Olive;
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(128, 172);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(119, 46);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtValores
            // 
            this.txtValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValores.Location = new System.Drawing.Point(79, 120);
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(217, 26);
            this.txtValores.TabIndex = 1;
            this.txtValores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValores_KeyPress);
            // 
            // lblTextoDigite
            // 
            this.lblTextoDigite.AutoSize = true;
            this.lblTextoDigite.BackColor = System.Drawing.Color.OrangeRed;
            this.lblTextoDigite.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDigite.ForeColor = System.Drawing.Color.White;
            this.lblTextoDigite.Location = new System.Drawing.Point(25, 28);
            this.lblTextoDigite.Name = "lblTextoDigite";
            this.lblTextoDigite.Size = new System.Drawing.Size(324, 29);
            this.lblTextoDigite.TabIndex = 0;
            this.lblTextoDigite.Text = "Insira os valores da Matriz:";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.Color.White;
            this.lblEnter.Location = new System.Drawing.Point(51, 74);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(272, 20);
            this.lblEnter.TabIndex = 3;
            this.lblEnter.Text = "Aperte enter após digitar um número!";
            // 
            // frmMatriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDireito);
            this.Controls.Add(this.panelEsquerdo);
            this.Name = "frmMatriz";
            this.Text = "Matriz";
            this.panelEsquerdo.ResumeLayout(false);
            this.panelEsquerdo.PerformLayout();
            this.panelDireito.ResumeLayout(false);
            this.panelDireito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.TextBox txtVerificacao;
        private System.Windows.Forms.TextBox txtquadro;
        private System.Windows.Forms.Button btnMenorValor;
        private System.Windows.Forms.Button btnMaiorValor;
        private System.Windows.Forms.Panel panelDireito;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.Label lblTextoDigite;
        private System.Windows.Forms.Label lblEnter;
    }
}

