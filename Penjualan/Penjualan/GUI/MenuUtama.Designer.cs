namespace Penjualan.GUI
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mn_file = new System.Windows.Forms.ToolStripMenuItem();
            this.sb_login = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sub_keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_master = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_buku = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_pembayaran = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_lapbuku = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_lappelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_pengaturan = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_ubahpsw = new System.Windows.Forms.ToolStripMenuItem();
            this.sub_tambahpengguna = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tool_barang = new System.Windows.Forms.ToolStripButton();
            this.tool_pelanggan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tool_transaksi = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_file,
            this.mn_master,
            this.mn_transaksi,
            this.mn_laporan,
            this.mn_pengaturan});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mn_file
            // 
            this.mn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_login,
            this.sub_logout,
            this.toolStripMenuItem1,
            this.sub_keluar});
            this.mn_file.Name = "mn_file";
            this.mn_file.Size = new System.Drawing.Size(37, 20);
            this.mn_file.Text = "&File";
            // 
            // sb_login
            // 
            this.sb_login.Name = "sb_login";
            this.sb_login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.sb_login.Size = new System.Drawing.Size(192, 22);
            this.sb_login.Text = "&Login";
            // 
            // sub_logout
            // 
            this.sub_logout.Name = "sub_logout";
            this.sub_logout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.sub_logout.Size = new System.Drawing.Size(192, 22);
            this.sub_logout.Text = "&Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // sub_keluar
            // 
            this.sub_keluar.Name = "sub_keluar";
            this.sub_keluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.sub_keluar.Size = new System.Drawing.Size(192, 22);
            this.sub_keluar.Text = "&Keluar Aplikasi";
            this.sub_keluar.Click += new System.EventHandler(this.sub_keluar_Click);
            // 
            // mn_master
            // 
            this.mn_master.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_buku,
            this.sub_pelanggan});
            this.mn_master.Name = "mn_master";
            this.mn_master.Size = new System.Drawing.Size(82, 20);
            this.mn_master.Text = "&Master Data";
            // 
            // sub_buku
            // 
            this.sub_buku.Name = "sub_buku";
            this.sub_buku.Size = new System.Drawing.Size(130, 22);
            this.sub_buku.Text = "&Buku";
            this.sub_buku.Click += new System.EventHandler(this.sub_buku_Click);
            // 
            // sub_pelanggan
            // 
            this.sub_pelanggan.Name = "sub_pelanggan";
            this.sub_pelanggan.Size = new System.Drawing.Size(130, 22);
            this.sub_pelanggan.Text = "&Pelanggan";
            this.sub_pelanggan.Click += new System.EventHandler(this.sub_pelanggan_Click);
            // 
            // mn_transaksi
            // 
            this.mn_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_pembayaran});
            this.mn_transaksi.Name = "mn_transaksi";
            this.mn_transaksi.Size = new System.Drawing.Size(66, 20);
            this.mn_transaksi.Text = "&Transaksi";
            // 
            // sub_pembayaran
            // 
            this.sub_pembayaran.Name = "sub_pembayaran";
            this.sub_pembayaran.Size = new System.Drawing.Size(140, 22);
            this.sub_pembayaran.Text = "&Pembayaran";
            // 
            // mn_laporan
            // 
            this.mn_laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_lapbuku,
            this.sub_lappelanggan});
            this.mn_laporan.Name = "mn_laporan";
            this.mn_laporan.Size = new System.Drawing.Size(62, 20);
            this.mn_laporan.Text = "&Laporan";
            // 
            // sub_lapbuku
            // 
            this.sub_lapbuku.Name = "sub_lapbuku";
            this.sub_lapbuku.Size = new System.Drawing.Size(176, 22);
            this.sub_lapbuku.Text = "&Laporan Buku";
            // 
            // sub_lappelanggan
            // 
            this.sub_lappelanggan.Name = "sub_lappelanggan";
            this.sub_lappelanggan.Size = new System.Drawing.Size(176, 22);
            this.sub_lappelanggan.Text = "&Laporan Pelanggan";
            // 
            // mn_pengaturan
            // 
            this.mn_pengaturan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_ubahpsw,
            this.sub_tambahpengguna});
            this.mn_pengaturan.Name = "mn_pengaturan";
            this.mn_pengaturan.Size = new System.Drawing.Size(80, 20);
            this.mn_pengaturan.Text = "&Pengaturan";
            // 
            // sub_ubahpsw
            // 
            this.sub_ubahpsw.Name = "sub_ubahpsw";
            this.sub_ubahpsw.Size = new System.Drawing.Size(173, 22);
            this.sub_ubahpsw.Text = "&Ubah Password";
            // 
            // sub_tambahpengguna
            // 
            this.sub_tambahpengguna.Name = "sub_tambahpengguna";
            this.sub_tambahpengguna.Size = new System.Drawing.Size(173, 22);
            this.sub_tambahpengguna.Text = "&Tambah Pengguna";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tool_barang,
            this.tool_pelanggan,
            this.toolStripSeparator1,
            this.tool_transaksi});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tool_barang
            // 
            this.tool_barang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_barang.Image = global::Penjualan.Properties.Resources.books_48;
            this.tool_barang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_barang.Name = "tool_barang";
            this.tool_barang.Size = new System.Drawing.Size(23, 22);
            this.tool_barang.ToolTipText = "Data Barang";
            // 
            // tool_pelanggan
            // 
            this.tool_pelanggan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_pelanggan.Image = global::Penjualan.Properties.Resources.User__2_;
            this.tool_pelanggan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_pelanggan.Name = "tool_pelanggan";
            this.tool_pelanggan.Size = new System.Drawing.Size(23, 22);
            this.tool_pelanggan.ToolTipText = "Data Pelanggan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tool_transaksi
            // 
            this.tool_transaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tool_transaksi.Image = global::Penjualan.Properties.Resources.penjualan;
            this.tool_transaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tool_transaksi.Name = "tool_transaksi";
            this.tool_transaksi.Size = new System.Drawing.Size(23, 22);
            this.tool_transaksi.ToolTipText = "Data Transaksi";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(139, 17);
            this.status.Text = "Created by :: Ade Hikmat";
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penjualan.Properties.Resources.Bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MenuUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Penjualan Buku";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem mn_file;
        public System.Windows.Forms.ToolStripMenuItem sb_login;
        public System.Windows.Forms.ToolStripMenuItem sub_logout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem sub_keluar;
        public System.Windows.Forms.ToolStripMenuItem mn_master;
        public System.Windows.Forms.ToolStripMenuItem sub_buku;
        public System.Windows.Forms.ToolStripMenuItem sub_pelanggan;
        public System.Windows.Forms.ToolStripMenuItem mn_transaksi;
        public System.Windows.Forms.ToolStripMenuItem mn_laporan;
        public System.Windows.Forms.ToolStripMenuItem sub_lapbuku;
        public System.Windows.Forms.ToolStripMenuItem mn_pengaturan;
        public System.Windows.Forms.ToolStripMenuItem sub_pembayaran;
        public System.Windows.Forms.ToolStripMenuItem sub_lappelanggan;
        public System.Windows.Forms.ToolStripMenuItem sub_ubahpsw;
        public System.Windows.Forms.ToolStripMenuItem sub_tambahpengguna;
        public System.Windows.Forms.ToolStripButton tool_barang;
        private System.Windows.Forms.ToolStripButton tool_pelanggan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tool_transaksi;
        public System.Windows.Forms.ToolStripStatusLabel status;
    }
}



