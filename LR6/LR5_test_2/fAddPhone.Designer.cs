
namespace LR5_2
{
    partial class fAddPhone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbOc = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbCpu = new System.Windows.Forms.TextBox();
            this.tbGpu = new System.Windows.Forms.TextBox();
            this.tbRom = new System.Windows.Forms.TextBox();
            this.tbRam = new System.Windows.Forms.TextBox();
            this.tbBody = new System.Windows.Forms.TextBox();
            this.cbCamera = new System.Windows.Forms.CheckBox();
            this.cbBiometrix = new System.Windows.Forms.CheckBox();
            this.btClance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOc
            // 
            this.tbOc.Location = new System.Drawing.Point(62, 12);
            this.tbOc.Name = "tbOc";
            this.tbOc.Size = new System.Drawing.Size(220, 22);
            this.tbOc.TabIndex = 6;
            this.tbOc.TabStop = false;
            this.tbOc.Enter += new System.EventHandler(this.tbOc_Enter);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(62, 207);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Додати";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbCpu
            // 
            this.tbCpu.Location = new System.Drawing.Point(62, 40);
            this.tbCpu.Name = "tbCpu";
            this.tbCpu.Size = new System.Drawing.Size(220, 22);
            this.tbCpu.TabIndex = 8;
            this.tbCpu.TabStop = false;
            this.tbCpu.Enter += new System.EventHandler(this.tbCpu_Enter);
            // 
            // tbGpu
            // 
            this.tbGpu.Location = new System.Drawing.Point(62, 68);
            this.tbGpu.Name = "tbGpu";
            this.tbGpu.Size = new System.Drawing.Size(220, 22);
            this.tbGpu.TabIndex = 9;
            this.tbGpu.TabStop = false;
            this.tbGpu.Enter += new System.EventHandler(this.tbGpu_Enter);
            // 
            // tbRom
            // 
            this.tbRom.Location = new System.Drawing.Point(62, 96);
            this.tbRom.Name = "tbRom";
            this.tbRom.Size = new System.Drawing.Size(220, 22);
            this.tbRom.TabIndex = 10;
            this.tbRom.TabStop = false;
            this.tbRom.Enter += new System.EventHandler(this.tbRom_Enter);
            this.tbRom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRom_KeyPress);
            // 
            // tbRam
            // 
            this.tbRam.Location = new System.Drawing.Point(62, 124);
            this.tbRam.Name = "tbRam";
            this.tbRam.Size = new System.Drawing.Size(220, 22);
            this.tbRam.TabIndex = 11;
            this.tbRam.TabStop = false;
            this.tbRam.Enter += new System.EventHandler(this.tbRam_Enter);
            this.tbRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRam_KeyPress);
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(62, 152);
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(220, 22);
            this.tbBody.TabIndex = 12;
            this.tbBody.TabStop = false;
            this.tbBody.Enter += new System.EventHandler(this.tbBody_Enter);
            // 
            // cbCamera
            // 
            this.cbCamera.AutoSize = true;
            this.cbCamera.Location = new System.Drawing.Point(62, 180);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(80, 21);
            this.cbCamera.TabIndex = 13;
            this.cbCamera.Text = "Камера";
            this.cbCamera.UseVisualStyleBackColor = true;
            // 
            // cbBiometrix
            // 
            this.cbBiometrix.AutoSize = true;
            this.cbBiometrix.Location = new System.Drawing.Point(153, 180);
            this.cbBiometrix.Name = "cbBiometrix";
            this.cbBiometrix.Size = new System.Drawing.Size(129, 21);
            this.cbBiometrix.TabIndex = 14;
            this.cbBiometrix.Text = "Сканер пальця";
            this.cbBiometrix.UseVisualStyleBackColor = true;
            // 
            // btClance
            // 
            this.btClance.Location = new System.Drawing.Point(196, 207);
            this.btClance.Name = "btClance";
            this.btClance.Size = new System.Drawing.Size(86, 23);
            this.btClance.TabIndex = 15;
            this.btClance.Text = "Скасувати";
            this.btClance.UseVisualStyleBackColor = true;
            this.btClance.Click += new System.EventHandler(this.btClance_Click);
            // 
            // fAddPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 240);
            this.Controls.Add(this.btClance);
            this.Controls.Add(this.cbBiometrix);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbRam);
            this.Controls.Add(this.tbRom);
            this.Controls.Add(this.tbGpu);
            this.Controls.Add(this.tbCpu);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbOc);
            this.MaximizeBox = false;
            this.Name = "fAddPhone";
            this.Text = "Додати телефон";
            this.Load += new System.EventHandler(this.fAddPhone_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOc;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbCpu;
        private System.Windows.Forms.TextBox tbGpu;
        private System.Windows.Forms.TextBox tbRom;
        private System.Windows.Forms.TextBox tbRam;
        private System.Windows.Forms.TextBox tbBody;
        private System.Windows.Forms.CheckBox cbCamera;
        private System.Windows.Forms.CheckBox cbBiometrix;
        private System.Windows.Forms.Button btClance;
    }
}