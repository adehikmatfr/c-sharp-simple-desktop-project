namespace GrandHotel.GUI
{
    partial class Employee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_employee = new System.Windows.Forms.DataGridView();
            this.tx_src = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tx_address = new System.Windows.Forms.RichTextBox();
            this.cm_job = new System.Windows.Forms.ComboBox();
            this.tx_tgl = new System.Windows.Forms.DateTimePicker();
            this.tx_psw1 = new System.Windows.Forms.TextBox();
            this.tx_psw2 = new System.Windows.Forms.TextBox();
            this.tx_nama = new System.Windows.Forms.TextBox();
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_user = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.can = new System.Windows.Forms.Button();
            this.sav = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.ins = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_employee)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dg_employee);
            this.groupBox1.Controls.Add(this.tx_src);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dg_employee
            // 
            this.dg_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_employee.Location = new System.Drawing.Point(6, 45);
            this.dg_employee.Name = "dg_employee";
            this.dg_employee.Size = new System.Drawing.Size(651, 219);
            this.dg_employee.TabIndex = 1;
            this.dg_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_employee_CellContentClick);
            // 
            // tx_src
            // 
            this.tx_src.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tx_src.Location = new System.Drawing.Point(448, 19);
            this.tx_src.Name = "tx_src";
            this.tx_src.Size = new System.Drawing.Size(168, 20);
            this.tx_src.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.id);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tx_address);
            this.groupBox2.Controls.Add(this.cm_job);
            this.groupBox2.Controls.Add(this.tx_tgl);
            this.groupBox2.Controls.Add(this.tx_psw1);
            this.groupBox2.Controls.Add(this.tx_psw2);
            this.groupBox2.Controls.Add(this.tx_nama);
            this.groupBox2.Controls.Add(this.tx_email);
            this.groupBox2.Controls.Add(this.tx_user);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 182);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Job";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // tx_address
            // 
            this.tx_address.Location = new System.Drawing.Point(300, 98);
            this.tx_address.Name = "tx_address";
            this.tx_address.Size = new System.Drawing.Size(134, 68);
            this.tx_address.TabIndex = 8;
            this.tx_address.Text = "";
            // 
            // cm_job
            // 
            this.cm_job.FormattingEnabled = true;
            this.cm_job.Location = new System.Drawing.Point(300, 57);
            this.cm_job.Name = "cm_job";
            this.cm_job.Size = new System.Drawing.Size(134, 21);
            this.cm_job.TabIndex = 7;
       
            // 
            // tx_tgl
            // 
            this.tx_tgl.Location = new System.Drawing.Point(300, 20);
            this.tx_tgl.Name = "tx_tgl";
            this.tx_tgl.Size = new System.Drawing.Size(134, 20);
            this.tx_tgl.TabIndex = 6;
            // 
            // tx_psw1
            // 
            this.tx_psw1.Location = new System.Drawing.Point(104, 53);
            this.tx_psw1.Name = "tx_psw1";
            this.tx_psw1.Size = new System.Drawing.Size(110, 20);
            this.tx_psw1.TabIndex = 5;
            // 
            // tx_psw2
            // 
            this.tx_psw2.Location = new System.Drawing.Point(104, 87);
            this.tx_psw2.Name = "tx_psw2";
            this.tx_psw2.Size = new System.Drawing.Size(110, 20);
            this.tx_psw2.TabIndex = 4;
            // 
            // tx_nama
            // 
            this.tx_nama.Location = new System.Drawing.Point(104, 116);
            this.tx_nama.Name = "tx_nama";
            this.tx_nama.Size = new System.Drawing.Size(110, 20);
            this.tx_nama.TabIndex = 3;
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(104, 148);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(110, 20);
            this.tx_email.TabIndex = 2;
            // 
            // tx_user
            // 
            this.tx_user.Location = new System.Drawing.Point(104, 22);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(110, 20);
            this.tx_user.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox3.Controls.Add(this.can);
            this.groupBox3.Controls.Add(this.sav);
            this.groupBox3.Controls.Add(this.del);
            this.groupBox3.Controls.Add(this.upd);
            this.groupBox3.Controls.Add(this.ins);
            this.groupBox3.Location = new System.Drawing.Point(490, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 182);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // can
            // 
            this.can.Location = new System.Drawing.Point(63, 145);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(75, 23);
            this.can.TabIndex = 4;
            this.can.Text = "cancle";
            this.can.UseVisualStyleBackColor = true;
            this.can.Click += new System.EventHandler(this.can_Click);
            // 
            // sav
            // 
            this.sav.Location = new System.Drawing.Point(63, 114);
            this.sav.Name = "sav";
            this.sav.Size = new System.Drawing.Size(75, 23);
            this.sav.TabIndex = 3;
            this.sav.Text = "Save";
            this.sav.UseVisualStyleBackColor = true;
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(63, 81);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 2;
            this.del.Text = "Delete";
            // 
            // upd
            // 
            this.upd.Location = new System.Drawing.Point(63, 50);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(75, 23);
            this.upd.TabIndex = 1;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            // 
            // ins
            // 
            this.ins.Location = new System.Drawing.Point(63, 15);
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size(75, 23);
            this.ins.TabIndex = 0;
            this.ins.Text = "Insert";
            this.ins.UseVisualStyleBackColor = true;
            this.ins.Click += new System.EventHandler(this.ins_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(431, 60);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(35, 13);
            this.id.TabIndex = 17;
            this.id.Text = "label9";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 482);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_employee)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox tx_address;
        private System.Windows.Forms.ComboBox cm_job;
        private System.Windows.Forms.DateTimePicker tx_tgl;
        private System.Windows.Forms.TextBox tx_psw1;
        private System.Windows.Forms.TextBox tx_psw2;
        private System.Windows.Forms.TextBox tx_nama;
        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button can;
        private System.Windows.Forms.Button sav;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button upd;
        private System.Windows.Forms.Button ins;
        private System.Windows.Forms.DataGridView dg_employee;
        private System.Windows.Forms.TextBox tx_src;
        private System.Windows.Forms.Label id;
    }
}