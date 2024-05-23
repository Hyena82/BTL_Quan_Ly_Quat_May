namespace BTL_Quan_Ly_Quat_May
{
    partial class FormDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            aToolStripMenuItem = new ToolStripMenuItem();
            bToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem1 = new ToolStripMenuItem();
            sdgsdgToolStripMenuItem = new ToolStripMenuItem();
            sdgsdgToolStripMenuItem1 = new ToolStripMenuItem();
            bToolStripMenuItem1 = new ToolStripMenuItem();
            đạiLýToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(480, 53);
            label1.Name = "label1";
            label1.Size = new Size(555, 46);
            label1.TabIndex = 0;
            label1.Text = "PHẦN MỀM QUẢN LÝ QUẠT MÁY";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(29, 180);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(435, 692);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "controller";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(551, 180);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1002, 679);
            dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(89, 28);
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bToolStripMenuItem });
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(88, 24);
            aToolStripMenuItem.Text = "A";
            // 
            // bToolStripMenuItem
            // 
            bToolStripMenuItem.Name = "bToolStripMenuItem";
            bToolStripMenuItem.Size = new Size(101, 26);
            bToolStripMenuItem.Text = "B";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, aToolStripMenuItem1, sdgsdgToolStripMenuItem, sdgsdgToolStripMenuItem1, đạiLýToolStripMenuItem, bToolStripMenuItem1, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1567, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem1
            // 
            aToolStripMenuItem1.Name = "aToolStripMenuItem1";
            aToolStripMenuItem1.Size = new Size(87, 24);
            aToolStripMenuItem1.Text = "Nhập kho";
            aToolStripMenuItem1.Click += aToolStripMenuItem1_Click;
            // 
            // sdgsdgToolStripMenuItem
            // 
            sdgsdgToolStripMenuItem.Name = "sdgsdgToolStripMenuItem";
            sdgsdgToolStripMenuItem.Size = new Size(81, 24);
            sdgsdgToolStripMenuItem.Text = "Xuất kho";
            sdgsdgToolStripMenuItem.Click += sdgsdgToolStripMenuItem_Click;
            // 
            // sdgsdgToolStripMenuItem1
            // 
            sdgsdgToolStripMenuItem1.Name = "sdgsdgToolStripMenuItem1";
            sdgsdgToolStripMenuItem1.Size = new Size(118, 24);
            sdgsdgToolStripMenuItem1.Text = "Xưởng lắp ráp";
            // 
            // bToolStripMenuItem1
            // 
            bToolStripMenuItem1.Name = "bToolStripMenuItem1";
            bToolStripMenuItem1.Size = new Size(77, 24);
            bToolStripMenuItem1.Text = "Báo cáo";
            bToolStripMenuItem1.Click += bToolStripMenuItem1_Click;
            // 
            // đạiLýToolStripMenuItem
            // 
            đạiLýToolStripMenuItem.Name = "đạiLýToolStripMenuItem";
            đạiLýToolStripMenuItem.Size = new Size(61, 24);
            đạiLýToolStripMenuItem.Text = "Đại lý";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(87, 24);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 888);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem bToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem1;
        private ToolStripMenuItem sdgsdgToolStripMenuItem;
        private ToolStripMenuItem sdgsdgToolStripMenuItem1;
        private ToolStripMenuItem bToolStripMenuItem1;
        private ToolStripMenuItem đạiLýToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem trangChủToolStripMenuItem;
    }
}
