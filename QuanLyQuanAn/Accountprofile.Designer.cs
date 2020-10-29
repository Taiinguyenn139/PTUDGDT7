namespace QuanLyQuanAn
{
    partial class Accountprofile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsername2 = new System.Windows.Forms.Label();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtbUsename1 = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.lbReDo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbReDo);
            this.panel1.Controls.Add(this.txtbPass);
            this.panel1.Controls.Add(this.txtbName);
            this.panel1.Controls.Add(this.txtbUsename1);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbNewPass);
            this.panel1.Controls.Add(this.lbUsername2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 174);
            this.panel1.TabIndex = 0;
            // 
            // lbUsername2
            // 
            this.lbUsername2.AutoSize = true;
            this.lbUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername2.Location = new System.Drawing.Point(3, 12);
            this.lbUsername2.Name = "lbUsername2";
            this.lbUsername2.Size = new System.Drawing.Size(117, 18);
            this.lbUsername2.TabIndex = 0;
            this.lbUsername2.Text = "Tên đăng nhập  :";
            // 
            // lbNewPass
            // 
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPass.Location = new System.Drawing.Point(3, 103);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(106, 18);
            this.lbNewPass.TabIndex = 1;
            this.lbNewPass.Text = "Mật khẩu mới :";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(3, 58);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 18);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Tên hiển thị :";
            // 
            // txtbUsename1
            // 
            this.txtbUsename1.Location = new System.Drawing.Point(126, 9);
            this.txtbUsename1.Name = "txtbUsename1";
            this.txtbUsename1.ReadOnly = true;
            this.txtbUsename1.Size = new System.Drawing.Size(251, 20);
            this.txtbUsename1.TabIndex = 3;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(126, 55);
            this.txtbName.Name = "txtbName";
            this.txtbName.ReadOnly = true;
            this.txtbName.Size = new System.Drawing.Size(251, 20);
            this.txtbName.TabIndex = 4;
            // 
            // txtbPass
            // 
            this.txtbPass.Location = new System.Drawing.Point(126, 100);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.Size = new System.Drawing.Size(251, 20);
            this.txtbPass.TabIndex = 5;
            this.txtbPass.UseSystemPasswordChar = true;
            this.txtbPass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbReDo
            // 
            this.lbReDo.AutoSize = true;
            this.lbReDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReDo.Location = new System.Drawing.Point(3, 134);
            this.lbReDo.Name = "lbReDo";
            this.lbReDo.Size = new System.Drawing.Size(69, 18);
            this.lbReDo.TabIndex = 6;
            this.lbReDo.Text = "Nhập lại :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(317, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(207, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật ";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Accountprofile
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(404, 256);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Name = "Accountprofile";
            this.Text = "Thông tin cá nhân ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbUsename1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.Label lbUsername2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbReDo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
    }
}