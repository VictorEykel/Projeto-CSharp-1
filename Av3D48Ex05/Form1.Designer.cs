namespace Av3D48Ex05
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblmes = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnmes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um número entre 1 e 12:";
            // 
            // lblmes
            // 
            this.lblmes.AutoSize = true;
            this.lblmes.Location = new System.Drawing.Point(365, 143);
            this.lblmes.Name = "lblmes";
            this.lblmes.Size = new System.Drawing.Size(16, 13);
            this.lblmes.TabIndex = 1;
            this.lblmes.Text = "...";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(171, 143);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 2;
            // 
            // btnmes
            // 
            this.btnmes.Location = new System.Drawing.Point(171, 208);
            this.btnmes.Name = "btnmes";
            this.btnmes.Size = new System.Drawing.Size(75, 23);
            this.btnmes.TabIndex = 3;
            this.btnmes.Text = "slk";
            this.btnmes.UseVisualStyleBackColor = true;
            this.btnmes.Click += new System.EventHandler(this.btnmes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 356);
            this.Controls.Add(this.btnmes);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblmes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblmes;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnmes;
    }
}

