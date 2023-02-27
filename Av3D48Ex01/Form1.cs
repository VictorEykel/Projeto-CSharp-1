using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3D48Ex01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntransform_Click(object sender, EventArgs e)
        {
            int timeH, timeM, timeS;
            int HemM;
            int MemS;
            int TotalSegundos;

            timeH = int.Parse(txtH.Text);
            timeM = int.Parse(txtM.Text);
            timeS = int.Parse(txtS.Text);

            HemM = (timeH * 60) * 60;
            MemS = timeM * 60;
            TotalSegundos = HemM + MemS + timeS;

            lblSeg.Text = TotalSegundos.ToString();
        }
    }
}
