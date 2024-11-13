using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class clear : Form
    {
        public clear()
        {
            InitializeComponent();
        }

        private void calcBMI_Click(object sender, EventArgs e)
        {
            double w = Convert.ToDouble(weight.Text);
            double h = Convert.ToDouble(height.Text);
            double bmi = w / (h * h);
            BMIShow.Text = bmi.ToString();
        }

        private void c_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cNum = Convert.ToDouble(c.Text);
                cShow.Text = (cNum * 2.54).ToString();
            } 
            catch
            {
                cShow.Text = "0";
            }
        }

        private void cm_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cmNum = Convert.ToDouble(cm.Text);
                cmShow.Text = (cmNum / 2.54).ToString();
            }
            catch
            {
                cmShow.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }
    }
}
