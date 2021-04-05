
namespace LR5_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx1min = new System.Windows.Forms.TextBox();
            this.tbx2min = new System.Windows.Forms.TextBox();
            this.tbx1max = new System.Windows.Forms.TextBox();
            this.tbx2max = new System.Windows.Forms.TextBox();
            this.tbdx1 = new System.Windows.Forms.TextBox();
            this.tbdx2 = new System.Windows.Forms.TextBox();
            this.gv = new System.Windows.Forms.DataGridView();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl_dob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X1min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "X2min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "X1max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "X2max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "dX1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "dX2";
            // 
            // tbx1min
            // 
            this.tbx1min.Location = new System.Drawing.Point(65, 12);
            this.tbx1min.Name = "tbx1min";
            this.tbx1min.Size = new System.Drawing.Size(100, 22);
            this.tbx1min.TabIndex = 6;
            // 
            // tbx2min
            // 
            this.tbx2min.Location = new System.Drawing.Point(65, 52);
            this.tbx2min.Name = "tbx2min";
            this.tbx2min.Size = new System.Drawing.Size(100, 22);
            this.tbx2min.TabIndex = 7;
            // 
            // tbx1max
            // 
            this.tbx1max.Location = new System.Drawing.Point(248, 12);
            this.tbx1max.Name = "tbx1max";
            this.tbx1max.Size = new System.Drawing.Size(100, 22);
            this.tbx1max.TabIndex = 8;
            // 
            // tbx2max
            // 
            this.tbx2max.Location = new System.Drawing.Point(248, 50);
            this.tbx2max.Name = "tbx2max";
            this.tbx2max.Size = new System.Drawing.Size(100, 22);
            this.tbx2max.TabIndex = 9;
            // 
            // tbdx1
            // 
            this.tbdx1.Location = new System.Drawing.Point(417, 13);
            this.tbdx1.Name = "tbdx1";
            this.tbdx1.Size = new System.Drawing.Size(100, 22);
            this.tbdx1.TabIndex = 10;
            // 
            // tbdx2
            // 
            this.tbdx2.Location = new System.Drawing.Point(417, 50);
            this.tbdx2.Name = "tbdx2";
            this.tbdx2.Size = new System.Drawing.Size(100, 22);
            this.tbdx2.TabIndex = 11;
            // 
            // gv
            // 
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(12, 89);
            this.gv.Name = "gv";
            this.gv.RowHeadersWidth = 51;
            this.gv.RowTemplate.Height = 24;
            this.gv.Size = new System.Drawing.Size(505, 285);
            this.gv.TabIndex = 12;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 389);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(116, 23);
            this.btnCalc.TabIndex = 13;
            this.btnCalc.Text = "Розрахувати";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(417, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Вийти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(74, 426);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(46, 17);
            this.lbl_dob.TabIndex = 16;
            this.lbl_dob.Text = "label7";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 452);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.gv);
            this.Controls.Add(this.tbdx2);
            this.Controls.Add(this.tbdx1);
            this.Controls.Add(this.tbx2max);
            this.Controls.Add(this.tbx1max);
            this.Controls.Add(this.tbx2min);
            this.Controls.Add(this.tbx1min);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fMain";
            this.Text = "Розрахунок";
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx1min;
        private System.Windows.Forms.TextBox tbx2min;
        private System.Windows.Forms.TextBox tbx1max;
        private System.Windows.Forms.TextBox tbx2max;
        private System.Windows.Forms.TextBox tbdx1;
        private System.Windows.Forms.TextBox tbdx2;
        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl_dob;
    }
}

