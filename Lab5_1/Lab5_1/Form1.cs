using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_1
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double x1min = double.Parse(tbx1min.Text);
            double x1max = double.Parse(tbx1max.Text);
            double x2min = double.Parse(tbx2min.Text);
            double x2max = double.Parse(tbx2max.Text);
            double dx1 = double.Parse(tbdx1.Text);
            double dx2 = double.Parse(tbdx2.Text);
            dataGridView.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 2;
            dataGridView.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 2;
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
                dataGridView.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
            dataGridView.RowHeadersWidth = 80;
            for (int i = 0; i < dataGridView.ColumnCount - 1; i++)
            {
                dataGridView.Columns[i].HeaderCell.Value = (x2min + i * dx2).ToString("0.000");
                dataGridView.Columns[i].Width = 60;
            }
            // Для автоматичного підлаштування розмірів стовпчиків та рядків
            // можна використовувати ці методи
            //gv.AutoResizeColumns();
            //gv.AutoResizeRows();
            int cl, rw;
            double x1, x2, y;
            rw = 0;
            x1 = x1min;
            //сума косинусоїд
            double sum_cos = 0;
            while (x1 <= x1max)
            {
                x2 = x2min;
                cl = 0;
                while (x2 <= x2max)
                {
                    //захист від помилкових результатів
                    if (((16 * x2 * x1) != 0) && (x2 != 0) && ((Math.Cos(2 * x2) + x1 / x2) / (16 * x2 * x1) >= 0))
                    {
                        y = Math.Sqrt((Math.Cos(2 * x2) + x1 / x2) / (16 * x2 * x1));
                        if (Math.Cos(y) >= 0)
                            sum_cos += Math.Cos(y);
                        dataGridView.Rows[rw].Cells[cl].Value = y.ToString("0.000");
                    }else
                        dataGridView.Rows[rw].Cells[cl].Value = "0";
                    x2 += dx2;
                    cl++;
                }
                x1 += dx1;
                rw++;
            }
            //підрахунок суми відповідних рядків та стовпців
            dataGridView.Rows[dataGridView.RowCount - 1].HeaderCell.Value = "Сумма";
            dataGridView.Columns[dataGridView.ColumnCount - 1].HeaderCell.Value = "Сумма";
            double sum = 0;
            for (int j = 0; j < dataGridView.RowCount - 1; j++)
            {
                for (int i = 0; i < dataGridView.ColumnCount - 1; i++)
                    sum += Convert.ToDouble(dataGridView.Rows[j].Cells[i].Value);
                dataGridView.Rows[j].Cells[dataGridView.ColumnCount - 1].Value = sum.ToString("0.000");
                sum = 0;
            }
            for (int i = 0; i < dataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView.RowCount - 1; j++)
                    sum += Convert.ToDouble(dataGridView.Rows[j].Cells[i].Value);
                dataGridView.Rows[dataGridView.RowCount - 1].Cells[i].Value = sum.ToString("0.000");
                sum = 0;
            }
            l_sum_cos.Text = "Сума додатніх косинусоїд = " + Convert.ToString(sum_cos);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx1min.Text = "";
            tbx1max.Text = "";
            tbx2min.Text = "";
            tbx2max.Text = "";
            tbdx1.Text = "";
            tbdx2.Text = "";
            dataGridView.Rows.Clear();
            for (int Cl = 0; Cl < dataGridView.ColumnCount; Cl++)
                dataGridView.Columns[Cl].HeaderCell.Value = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
