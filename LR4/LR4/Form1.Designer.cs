
namespace LR4
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.bAddPhone = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAddPhone
            // 
            this.bAddPhone.Location = new System.Drawing.Point(12, 271);
            this.bAddPhone.Name = "bAddPhone";
            this.bAddPhone.Size = new System.Drawing.Size(75, 23);
            this.bAddPhone.TabIndex = 0;
            this.bAddPhone.Text = "+";
            this.bAddPhone.UseVisualStyleBackColor = true;
            this.bAddPhone.Click += new System.EventHandler(this.button1_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(822, 271);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 1;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.Control;
            this.tbPhone.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(12, 12);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPhone.Size = new System.Drawing.Size(885, 252);
            this.tbPhone.TabIndex = 2;
            this.tbPhone.Text = resources.GetString("tbPhone.Text");
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(432, 271);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 306);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bAddPhone);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.Text = "Телефон";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddPhone;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btClear;
    }
}

