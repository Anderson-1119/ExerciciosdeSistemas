
namespace maioroumenorquedez
{
    partial class frmMaioroumenor
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
            this.txtMaioroumenor = new System.Windows.Forms.TextBox();
            this.lblMaioroumenor = new System.Windows.Forms.Label();
            this.btnMaiorouMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaioroumenor
            // 
            this.txtMaioroumenor.BackColor = System.Drawing.Color.White;
            this.txtMaioroumenor.ForeColor = System.Drawing.Color.Black;
            this.txtMaioroumenor.Location = new System.Drawing.Point(310, 75);
            this.txtMaioroumenor.Name = "txtMaioroumenor";
            this.txtMaioroumenor.Size = new System.Drawing.Size(125, 20);
            this.txtMaioroumenor.TabIndex = 0;
            // 
            // lblMaioroumenor
            // 
            this.lblMaioroumenor.AutoSize = true;
            this.lblMaioroumenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaioroumenor.Location = new System.Drawing.Point(306, 42);
            this.lblMaioroumenor.Name = "lblMaioroumenor";
            this.lblMaioroumenor.Size = new System.Drawing.Size(136, 20);
            this.lblMaioroumenor.TabIndex = 1;
            this.lblMaioroumenor.Text = "Digite um Número";
            // 
            // btnMaiorouMenor
            // 
            this.btnMaiorouMenor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMaiorouMenor.FlatAppearance.BorderSize = 0;
            this.btnMaiorouMenor.Location = new System.Drawing.Point(333, 114);
            this.btnMaiorouMenor.Name = "btnMaiorouMenor";
            this.btnMaiorouMenor.Size = new System.Drawing.Size(75, 23);
            this.btnMaiorouMenor.TabIndex = 2;
            this.btnMaiorouMenor.Text = "Verificar";
            this.btnMaiorouMenor.UseVisualStyleBackColor = false;
            this.btnMaiorouMenor.Click += new System.EventHandler(this.btnMaiorouMenor_Click);
            // 
            // frmMaioroumenor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(723, 294);
            this.Controls.Add(this.btnMaiorouMenor);
            this.Controls.Add(this.lblMaioroumenor);
            this.Controls.Add(this.txtMaioroumenor);
            this.Name = "frmMaioroumenor";
            this.Text = "Maior ou Menor que Dez";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaioroumenor;
        private System.Windows.Forms.Label lblMaioroumenor;
        private System.Windows.Forms.Button btnMaiorouMenor;
    }
}

