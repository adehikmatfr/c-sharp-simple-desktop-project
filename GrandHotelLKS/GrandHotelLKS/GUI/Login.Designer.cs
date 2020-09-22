namespace GrandHotelLKS.GUI
{
    partial class Login
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
            this.psw = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Button();
            this.can = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // psw
            // 
            this.psw.Location = new System.Drawing.Point(91, 114);
            this.psw.Name = "psw";
            this.psw.Size = new System.Drawing.Size(153, 20);
            this.psw.TabIndex = 0;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(91, 72);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(153, 20);
            this.user.TabIndex = 1;
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(56, 179);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(75, 23);
            this.log.TabIndex = 2;
            this.log.Text = "Login";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // can
            // 
            this.can.Location = new System.Drawing.Point(169, 179);
            this.can.Name = "can";
            this.can.Size = new System.Drawing.Size(75, 23);
            this.can.TabIndex = 3;
            this.can.Text = "cancel";
            this.can.UseVisualStyleBackColor = true;
            this.can.Click += new System.EventHandler(this.can_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.can);
            this.Controls.Add(this.log);
            this.Controls.Add(this.user);
            this.Controls.Add(this.psw);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button can;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}