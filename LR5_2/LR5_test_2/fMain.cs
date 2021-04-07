using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5_2
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvPhone.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "operatitong_sistem";
            column.Name = "ОС";
            gvPhone.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "cpu";
            column.Name = "Центральний процесор";
            gvPhone.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "gpu";
            column.Name = "Графічний процесор";
            gvPhone.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "rom";
            column.Name = "ROM";
            gvPhone.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ram";
            column.Name = "RAM";
            gvPhone.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "tip_body";
            column.Name = "Тип корпусу";
            column.Width = 80;
            gvPhone.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "camera";
            column.Name = "Камера";
            column.Width = 60;
            gvPhone.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "biometrics";
            column.Name = "Біометрія";
            column.Width = 60;
            gvPhone.Columns.Add(column);
            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Phone phone = new Phone();
            fAddPhone fphone = new fAddPhone(ref phone);
            if (fphone.ShowDialog() == DialogResult.OK)
            {
                bindSrcPhone.Add(phone);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Phone phone = (Phone)bindSrcPhone.List[bindSrcPhone.Position];
            fAddPhone ft = new fAddPhone(ref phone);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcPhone.List[bindSrcPhone.Position] = phone;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcPhone.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcPhone.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
