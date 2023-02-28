namespace Av3D48Ex01
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
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.lblSeg = new System.Windows.Forms.Label();
            this.btnTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(99, 79);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(75, 13);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "digite as horas";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(99, 173);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(88, 13);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "digite os minutos ";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(99, 267);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(95, 13);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "digite os segundos";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(102, 95);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 3;
            this.txtH.Text = "0";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(102, 189);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 4;
            this.txtM.Text = "0";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(102, 283);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 20);
            this.txtS.TabIndex = 5;
            this.txtS.Text = "0";
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.Location = new System.Drawing.Point(341, 189);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(25, 13);
            this.lblSeg.TabIndex = 8;
            this.lblSeg.Text = "000";
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(286, 267);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(101, 52);
            this.btnTransform.TabIndex = 11;
            this.btnTransform.Text = "Tranformar em Segundos";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btntransform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 406);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.lblSeg);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.Button btnTransform;
    }
}

