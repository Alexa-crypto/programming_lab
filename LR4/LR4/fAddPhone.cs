using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class fAddPhone : Form
    {
        private Phone phone = new Phone();
        public fAddPhone(Phone phone)
        {
            this.phone = phone;
            InitializeComponent();
        }
        private void fAddPhone_Load(object sender, EventArgs e)
        {
            tbOc.Text = "Операційна_Система";
            tbCpu.Text = "Центральний_Процесор";
            tbGpu.Text = "Графічний_Процесор";
            tbRom.Text = "Постійна_Память";
            tbRam.Text = "Оперативна_Память";
            tbBody.Text = "Тип_Корпусу";
            tbOc.ForeColor = tbCpu.ForeColor = tbGpu.ForeColor = tbRom.ForeColor = tbRam.ForeColor = tbBody.ForeColor = Color.Gray;
        }
        private void tbOc_Enter(object sender, EventArgs e)
        {
            tbOc.Text = null;
            tbOc.ForeColor = Color.Black;
        }
        private void tbCpu_Enter(object sender, EventArgs e)
        {
            tbCpu.Text = null;
            tbCpu.ForeColor = Color.Black;
        }
        private void tbGpu_Enter(object sender, EventArgs e)
        {
            tbGpu.Text = null;
            tbGpu.ForeColor = Color.Black;
        }
        private void tbRom_Enter(object sender, EventArgs e)
        {
            tbRom.Text = null;
            tbRom.ForeColor = Color.Black;
        }
        private void tbRam_Enter(object sender, EventArgs e)
        {
            tbRam.Text = null;
            tbRam.ForeColor = Color.Black;
        }
        private void tbBody_Enter(object sender, EventArgs e)
        {
            tbBody.Text = null;
            tbBody.ForeColor = Color.Black;
        }

        private void btClance_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (phone != null)
            {
                phone.Set_Phone(tbOc.Text, tbCpu.Text, tbGpu.Text, Convert.ToInt32(tbRom.Text), Convert.ToInt32(tbRam.Text), tbBody.Text, cbCamera.Checked, cbBiometrix.Checked);
                DialogResult = DialogResult.OK;
            }
            else
                DialogResult = DialogResult.Cancel;
        }

        private void tbRom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar));
        }

        private void tbRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar));
        }
    }
}
