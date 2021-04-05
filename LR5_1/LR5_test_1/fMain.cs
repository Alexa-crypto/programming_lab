using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5_1
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            lbl_dob.Text = null;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Перетворення текстових рядків, які ввів користувач,
            // у змінні числового типу
            double x1min = double.Parse(tbx1min.Text);
            double x1max = double.Parse(tbx1max.Text);
            double x2min = double.Parse(tbx2min.Text);
            double x2max = double.Parse(tbx2max.Text);
            double dx1 = double.Parse(tbdx1.Text);
            double dx2 = double.Parse(tbdx2.Text);
            // Обчислення кількості рядків та стовпчиків таблиці
            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 2;
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 2;
            // Вивід заголовків рядків та стовпців таблиці
            for (int i = 0; i < gv.RowCount - 1; i++)
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
            gv.RowHeadersWidth = 80;
            for (int i = 0; i < gv.ColumnCount - 1; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2min + i * dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }
            // Для автоматичного підлаштування розмірів стовпчиків та рядків
            // можна використовувати ці методи
            //gv.AutoResizeColumns();
            //gv.AutoResizeRows();
            int cl, rw;
            double x1, x2, y;
            // Розрахунок і вивід результатів
            rw = 0;
            x1 = x1min;
            double dob_id = 1;
            while (x1 <= x1max)
            {
                x2 = x2min;
                cl = 0;
                while (x2 <= x2max)
                {
                    y = Math.Sqrt(56*x1+((x1+x2+Math.Sin(x1*x2))/(5-Math.Cos(Math.Pow(x2, 2)))));
                    if (y > 0)
                        dob_id = dob_id * y;
                    gv.Rows[rw].Cells[cl].Value = y.ToString("0.000");
                    x2 += dx2;
                    cl++;
                }
                x1 += dx1;
                rw++;
            }
            //підрахунок суми відповідних рядків та стовпців
            gv.Rows[gv.RowCount - 1].HeaderCell.Value = "Сумма";
            gv.Columns[gv.ColumnCount - 1].HeaderCell.Value = "Сумма";
            double sum = 0;
            for (int j = 0; j < gv.RowCount - 1; j++)
            {
                for (int i = 0; i < gv.ColumnCount - 1; i++)
                    sum += Convert.ToDouble(gv.Rows[j].Cells[i].Value);
                gv.Rows[j].Cells[gv.ColumnCount - 1].Value = sum.ToString("0.000");
                sum = 0;
            }
            for (int i = 0; i < gv.ColumnCount; i++)
            {
                for (int j = 0; j < gv.RowCount - 1; j++)
                    sum += Convert.ToDouble(gv.Rows[j].Cells[i].Value);
                gv.Rows[gv.RowCount - 1].Cells[i].Value = sum.ToString("0.000");
                sum = 0;
            }
            lbl_dob.Text = "Добуток всіх додатніх значень = " + dob_id.ToString("0.000");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx1min.Text = "";
            tbx1max.Text = "";
            tbx2min.Text = "";
            tbx2max.Text = "";
            tbdx1.Text = "";
            tbdx2.Text = "";
            lbl_dob.Text = null;
            gv.Rows.Clear();
            for (int Cl = 0; Cl < gv.ColumnCount; Cl++)
                gv.Columns[Cl].HeaderCell.Value = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
