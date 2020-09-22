namespace WindowsFormsApplication2.GUI
{
    partial class UserData
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
            this.dg_user = new System.Windows.Forms.DataGridView();
            this.tx_user = new System.Windows.Forms.TextBox();
            this.tx_psw = new System.Windows.Forms.TextBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_user
            // 
            this.dg_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_user.Location = new System.Drawing.Point(116, 101);
            this.dg_user.Name = "dg_user";
            this.dg_user.Size = new System.Drawing.Size(383, 150);
            this.dg_user.TabIndex = 0;
            this.dg_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_user_CellContentClick);
            // 
            // tx_user
            // 
            this.tx_user.Location = new System.Drawing.Point(116, 49);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(141, 20);
            this.tx_user.TabIndex = 1;
            // 
            // tx_psw
            // 
            this.tx_psw.Location = new System.Drawing.Point(357, 49);
            this.tx_psw.Name = "tx_psw";
            this.tx_psw.Size = new System.Drawing.Size(142, 20);
            this.tx_psw.TabIndex = 2;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(116, 271);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 21);
            this.cb1.TabIndex = 3;
            // 
            // UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 327);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.tx_psw);
            this.Controls.Add(this.tx_user);
            this.Controls.Add(this.dg_user);
            this.Name = "UserData";
            this.Text = "UserData";
            ((System.ComponentModel.ISupportInitialize)(this.dg_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_user;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.TextBox tx_psw;
        private System.Windows.Forms.ComboBox cb1;
    }
}