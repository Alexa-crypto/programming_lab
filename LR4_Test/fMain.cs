using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4_Test
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddTown_Click(object sender, EventArgs e)
        {
            Town town = new Town();
            fTown ft = new fTown(town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTownsInfo.Text += string.Format("{0}, {1}, {2}. Мешканців: {3}. Річний дохід: {4:0.00} грн. Площа: {5:0.000} кв.км. [{6} | {7}] | Річний дохід на мешканця: {8:0.00} грн\r\n",
                town.Name, town.Country, town.Region,
                town.Population, town.YearIncome, town.Square,
                town.HasPort ? "Є порт" : "Немає порта",
                town.HasAirport ? "Є аеропорт" : "Немає аеропорта",
                town.GetYearIncomePerInhabitant());

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
