using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3D48Ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmes_Click(object sender, EventArgs e)
        {
            int numM;

            numM = int.Parse(txtnum.Text);

            switch (numM)
            {
                case 1:
                    lblmes.Text = "Janeiro";
                    break; 
                
                case 2:
                    lblmes.Text = "Fevereiro";
                    break;

                case 3:
                    lblmes.Text = "Março";
                    break;

                case 4:
                    lblmes.Text = "Abril";
                    break;

                case 5:
                    lblmes.Text = "Maio";
                    break;

                case 6:
                    lblmes.Text = "Junho";
                    break;

                case 7:
                    lblmes.Text = "Julho";
                    break;

                case 8:
                    lblmes.Text = "Agosto";
                    break;

                case 9:
                    lblmes.Text = "Setembro";
                    break;

                case 10:
                    lblmes.Text = "Outubro";
                    break;

                case 11:
                    lblmes.Text = "Novembro";
                    break;

                case 12:
                    lblmes.Text = "Dezembro";
                    break;
            }

            if (numM < 1 || numM >12)
            {
                MessageBox.Show("Digite um número válido!");
            }
            
        }
    }
}
