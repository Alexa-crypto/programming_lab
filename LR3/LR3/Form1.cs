using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double y;
            for (int x = -1; x <= 30; x++)
            {
                y = Math.Sqrt(56 * x + ((x + x + Math.Sin(x * x)) / (5 - Math.Cos(Math.Pow(x, 2)))));
                chart1.Series[0].Points.AddXY(x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_x1.Text) || (string.IsNullOrEmpty(tb_x2.Text))) { tb_x1.Text = tb_x2.Text = "ERROR_empty!!!"; return; }
            double x1 = Convert.ToDouble(tb_x1.Text); 
            double x2 = Convert.ToDouble(tb_x2.Text);
            if (x1 < x2)
                less.Text = "Число х1 менше, х1 = " + Convert.ToString(x1);
            else if (x1 > x2)
                less.Text = "Число х2 менше, х2 = " + Convert.ToString(x2);
            else
                less.Text = "Число х1 та х1 рівні та = " + Convert.ToString(x2);
            
            if (((5 - Math.Cos(Math.Pow(x2, 2))) != 0) && (56 * x1 + ((x1 + x2 + Math.Sin(x1 * x2)) / (5 - Math.Cos(Math.Pow(x2, 2))))) >= 0)
            {
                double y = Math.Sqrt(56 * x1 + ((x1 + x2 + Math.Sin(x1 * x2)) / (5 - Math.Cos(Math.Pow(x2, 2)))));
                result.Text = y.ToString("0.###");
            }
            else { tb_x1.Text = tb_x2.Text = "ERROR x1_or_x2"; return; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_x1.Text = string.Empty;
            tb_x2.Text = string.Empty;
            result.Text = "xxx";
            less.Text = string.Empty;
        }
    }
}
