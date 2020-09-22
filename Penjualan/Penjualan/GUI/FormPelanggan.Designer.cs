namespace Penjualan.GUI
{
    partial class FormPelanggan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rc_alamat = new System.Windows.Forms.RichTextBox();
            this.cb_kelamin = new System.Windows.Forms.ComboBox();
            this.tx_nama = new System.Windows.Forms.TextBox();
            this.tx_pelanggan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_penaggan = new System.Windows.Forms.TextBox();
            this.dg_pelanggan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pelanggan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rc_alamat);
            this.groupBox1.Controls.Add(this.cb_kelamin);
            this.groupBox1.Controls.Add(this.tx_nama);
            this.groupBox1.Controls.Add(this.tx_pelanggan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pelanggan";
            // 
            // rc_alamat
            // 
            this.rc_alamat.Location = new System.Drawing.Point(123, 121);
            this.rc_alamat.Name = "rc_alamat";
            this.rc_alamat.Size = new System.Drawing.Size(114, 41);
            this.rc_alamat.TabIndex = 6;
            this.rc_alamat.Text = "";
            // 
            // cb_kelamin
            // 
            this.cb_kelamin.FormattingEnabled = true;
            this.cb_kelamin.Location = new System.Drawing.Point(123, 82);
            this.cb_kelamin.Name = "cb_kelamin";
            this.cb_kelamin.Size = new System.Drawing.Size(114, 21);
            this.cb_kelamin.TabIndex = 5;
            // 
            // tx_nama
            // 
            this.tx_nama.Location = new System.Drawing.Point(123, 49);
            this.tx_nama.Name = "tx_nama";
            this.tx_nama.Size = new System.Drawing.Size(114, 20);
            this.tx_nama.TabIndex = 5;
            // 
            // tx_pelanggan
            // 
            this.tx_pelanggan.Location = new System.Drawing.Point(123, 19);
            this.tx_pelanggan.Name = "tx_pelanggan";
            this.tx_pelanggan.Size = new System.Drawing.Size(100, 20);
            this.tx_pelanggan.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tx_penaggan);
            this.groupBox2.Controls.Add(this.dg_pelanggan);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 291);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Pelanggan";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::Penjualan.Properties.Resources.search_24;
            this.label5.Location = new System.Drawing.Point(251, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "   ";
            // 
            // tx_penaggan
            // 
            this.tx_penaggan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tx_penaggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_penaggan.Location = new System.Drawing.Point(37, 19);
            this.tx_penaggan.Name = "tx_penaggan";
            this.tx_penaggan.Size = new System.Drawing.Size(217, 21);
            this.tx_penaggan.TabIndex = 2;
            // 
            // dg_pelanggan
            // 
            this.dg_pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pelanggan.Location = new System.Drawing.Point(7, 45);
            this.dg_pelanggan.Name = "dg_pelanggan";
            this.dg_pelanggan.Size = new System.Drawing.Size(267, 240);
            this.dg_pelanggan.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btn_hapus);
            this.groupBox3.Controls.Add(this.btn_simpan);
            this.groupBox3.Controls.Add(this.btn_ubah);
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Location = new System.Drawing.Point(12, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 112);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Button";
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Image = global::Penjualan.Properties.Resources.trash_24;
            this.btn_hapus.Location = new System.Drawing.Point(158, 64);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(87, 32);
            this.btn_hapus.TabIndex = 7;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_hapus.UseVisualStyleBackColor = true;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.Image = global::Penjualan.Properties.Resources.save_24;
            this.btn_simpan.Location = new System.Drawing.Point(158, 24);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(87, 34);
            this.btn_simpan.TabIndex = 6;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_simpan.UseVisualStyleBackColor = true;
            // 
            // btn_ubah
            // 
            this.btn_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.Image = global::Penjualan.Properties.Resources.pencil_tip_24;
            this.btn_ubah.Location = new System.Drawing.Point(28, 64);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(85, 32);
            this.btn_ubah.TabIndex = 5;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ubah.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Image = global::Penjualan.Properties.Resources.plus_24;
            this.btn_new.Location = new System.Drawing.Point(28, 24);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(85, 34);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "Baru";
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 315);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelanggan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pelanggan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rc_alamat;
        private System.Windows.Forms.ComboBox cb_kelamin;
        private System.Windows.Forms.TextBox tx_nama;
        private System.Windows.Forms.TextBox tx_pelanggan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_pelanggan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_penaggan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_new;
    }
}