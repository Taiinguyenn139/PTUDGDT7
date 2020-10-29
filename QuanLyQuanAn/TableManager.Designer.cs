namespace QuanLyQuanAn
{
    partial class TableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.btnFood = new System.Windows.Forms.Button();
            this.numFoodcount = new System.Windows.Forms.NumericUpDown();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDiscnt = new System.Windows.Forms.Button();
            this.numDiscnt = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnswitchtable = new System.Windows.Forms.Button();
            this.cbbswitch = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscnt)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin cá nhân ";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(477, 411);
            this.flowLayoutPanelTable.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstBill);
            this.panel1.Location = new System.Drawing.Point(495, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 289);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbswitch);
            this.panel2.Controls.Add(this.btnswitchtable);
            this.panel2.Controls.Add(this.numDiscnt);
            this.panel2.Controls.Add(this.btnDiscnt);
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Location = new System.Drawing.Point(495, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 51);
            this.panel2.TabIndex = 3;
            // 
            // lstBill
            // 
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(4, 3);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(286, 268);
            this.lstBill.TabIndex = 0;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numFoodcount);
            this.panel3.Controls.Add(this.btnFood);
            this.panel3.Controls.Add(this.cbbFood);
            this.panel3.Controls.Add(this.cbbCategory);
            this.panel3.Location = new System.Drawing.Point(495, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 58);
            this.panel3.TabIndex = 4;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(4, 4);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(137, 21);
            this.cbbCategory.TabIndex = 0;
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(4, 32);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(137, 21);
            this.cbbFood.TabIndex = 1;
            // 
            // btnFood
            // 
            this.btnFood.Location = new System.Drawing.Point(147, 4);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(74, 49);
            this.btnFood.TabIndex = 2;
            this.btnFood.Text = "Thêm món";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // numFoodcount
            // 
            this.numFoodcount.Location = new System.Drawing.Point(228, 19);
            this.numFoodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numFoodcount.Name = "numFoodcount";
            this.numFoodcount.Size = new System.Drawing.Size(62, 20);
            this.numFoodcount.TabIndex = 3;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(215, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 45);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnDiscnt
            // 
            this.btnDiscnt.Location = new System.Drawing.Point(134, 3);
            this.btnDiscnt.Name = "btnDiscnt";
            this.btnDiscnt.Size = new System.Drawing.Size(75, 23);
            this.btnDiscnt.TabIndex = 1;
            this.btnDiscnt.Text = "Giảm giá";
            this.btnDiscnt.UseVisualStyleBackColor = true;
            // 
            // numDiscnt
            // 
            this.numDiscnt.Location = new System.Drawing.Point(134, 28);
            this.numDiscnt.Name = "numDiscnt";
            this.numDiscnt.Size = new System.Drawing.Size(75, 20);
            this.numDiscnt.TabIndex = 2;
            // 
            // btnswitchtable
            // 
            this.btnswitchtable.Location = new System.Drawing.Point(4, 3);
            this.btnswitchtable.Name = "btnswitchtable";
            this.btnswitchtable.Size = new System.Drawing.Size(75, 23);
            this.btnswitchtable.TabIndex = 3;
            this.btnswitchtable.Text = "Chuyển bàn ";
            this.btnswitchtable.UseVisualStyleBackColor = true;
            // 
            // cbbswitch
            // 
            this.cbbswitch.FormattingEnabled = true;
            this.cbbswitch.Location = new System.Drawing.Point(4, 28);
            this.cbbswitch.Name = "cbbswitch";
            this.cbbswitch.Size = new System.Drawing.Size(75, 21);
            this.cbbswitch.TabIndex = 4;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFoodcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.NumericUpDown numFoodcount;
        private System.Windows.Forms.ComboBox cbbswitch;
        private System.Windows.Forms.Button btnswitchtable;
        private System.Windows.Forms.NumericUpDown numDiscnt;
        private System.Windows.Forms.Button btnDiscnt;
        private System.Windows.Forms.Button btnPay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}