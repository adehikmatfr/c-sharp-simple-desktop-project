namespace GrandHotel.GUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_login = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.sub_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_employee = new System.Windows.Forms.ToolStripMenuItem();
            this.room = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_rmtype = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_room = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_item = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_keeper = new System.Windows.Forms.ToolStripMenuItem();
            this.masterHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_res = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_in = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_out = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_cls = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.date});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Digital Numbers", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(68, 17);
            this.date.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.masterHotelToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_login,
            this.sub_logout,
            this.logoutToolStripMenuItem,
            this.sub_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // sub_login
            // 
            this.sub_login.Name = "sub_login";
            this.sub_login.Size = new System.Drawing.Size(152, 22);
            this.sub_login.Text = "Login";
            // 
            // sub_logout
            // 
            this.sub_logout.Name = "sub_logout";
            this.sub_logout.Size = new System.Drawing.Size(152, 22);
            this.sub_logout.Text = "Logout";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(149, 6);
            // 
            // sub_exit
            // 
            this.sub_exit.Name = "sub_exit";
            this.sub_exit.Size = new System.Drawing.Size(152, 22);
            this.sub_exit.Text = "Exit";
            this.sub_exit.Click += new System.EventHandler(this.sub_exit_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_employee,
            this.room,
            this.sub_keeper});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.masterToolStripMenuItem.Text = "&Master Data";
            // 
            // sub_employee
            // 
            this.sub_employee.Name = "sub_employee";
            this.sub_employee.Size = new System.Drawing.Size(152, 22);
            this.sub_employee.Text = "Employee";
            this.sub_employee.Click += new System.EventHandler(this.sub_employee_Click);
            // 
            // room
            // 
            this.room.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_rmtype,
            this.sub_room,
            this.sub_item});
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(152, 22);
            this.room.Text = "Room";
            // 
            // sub_rmtype
            // 
            this.sub_rmtype.Name = "sub_rmtype";
            this.sub_rmtype.Size = new System.Drawing.Size(152, 22);
            this.sub_rmtype.Text = "Room type";
            // 
            // sub_room
            // 
            this.sub_room.Name = "sub_room";
            this.sub_room.Size = new System.Drawing.Size(152, 22);
            this.sub_room.Text = "Room";
            // 
            // sub_item
            // 
            this.sub_item.Name = "sub_item";
            this.sub_item.Size = new System.Drawing.Size(152, 22);
            this.sub_item.Text = "Item";
            // 
            // sub_keeper
            // 
            this.sub_keeper.Name = "sub_keeper";
            this.sub_keeper.Size = new System.Drawing.Size(152, 22);
            this.sub_keeper.Text = "HouseKeeper";
            // 
            // masterHotelToolStripMenuItem
            // 
            this.masterHotelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_res,
            this.sub_in,
            this.sub_out,
            this.sub_cls});
            this.masterHotelToolStripMenuItem.Name = "masterHotelToolStripMenuItem";
            this.masterHotelToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.masterHotelToolStripMenuItem.Text = "&Master Hotel";
            // 
            // sub_res
            // 
            this.sub_res.Name = "sub_res";
            this.sub_res.Size = new System.Drawing.Size(156, 22);
            this.sub_res.Text = "Reservation";
            // 
            // sub_in
            // 
            this.sub_in.Name = "sub_in";
            this.sub_in.Size = new System.Drawing.Size(156, 22);
            this.sub_in.Text = "Chack in";
            // 
            // sub_out
            // 
            this.sub_out.Name = "sub_out";
            this.sub_out.Size = new System.Drawing.Size(156, 22);
            this.sub_out.Text = "Chack out";
            // 
            // sub_cls
            // 
            this.sub_cls.Name = "sub_cls";
            this.sub_cls.Size = new System.Drawing.Size(156, 22);
            this.sub_cls.Text = "Cleaning Room";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Main";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel date;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sub_login;
        private System.Windows.Forms.ToolStripMenuItem sub_logout;
        private System.Windows.Forms.ToolStripSeparator logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sub_exit;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sub_employee;
        private System.Windows.Forms.ToolStripMenuItem room;
        private System.Windows.Forms.ToolStripMenuItem sub_rmtype;
        private System.Windows.Forms.ToolStripMenuItem sub_room;
        private System.Windows.Forms.ToolStripMenuItem sub_item;
        private System.Windows.Forms.ToolStripMenuItem sub_keeper;
        private System.Windows.Forms.ToolStripMenuItem masterHotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sub_res;
        private System.Windows.Forms.ToolStripMenuItem sub_in;
        private System.Windows.Forms.ToolStripMenuItem sub_out;
        private System.Windows.Forms.ToolStripMenuItem sub_cls;
        private System.Windows.Forms.Timer timer1;
    }
}



