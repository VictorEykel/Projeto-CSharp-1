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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.lblSeg = new System.Windows.Forms.Label();
            this.btntransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "digite as horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "digite os minutos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "digite os segundos";
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
            // btntransform
            // 
            this.btntransform.Location = new System.Drawing.Point(321, 280);
            this.btntransform.Name = "btntransform";
            this.btntransform.Size = new System.Drawing.Size(75, 23);
            this.btntransform.TabIndex = 11;
            this.btntransform.Text = "slk";
            this.btntransform.UseVisualStyleBackColor = true;
            this.btntransform.Click += new System.EventHandler(this.btntransform_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 406);
            this.Controls.Add(this.btntransform);
            this.Controls.Add(this.lblSeg);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.Button btntransform;
    }
}

