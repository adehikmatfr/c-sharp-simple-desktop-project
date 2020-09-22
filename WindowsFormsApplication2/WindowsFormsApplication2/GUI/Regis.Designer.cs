namespace WindowsFormsApplication2.GUI
{
    partial class Regis
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
            this.tx_user = new System.Windows.Forms.TextBox();
            this.tx_psw = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_user
            // 
            this.tx_user.Location = new System.Drawing.Point(107, 46);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(153, 20);
            this.tx_user.TabIndex = 0;
            // 
            // tx_psw
            // 
            this.tx_psw.Location = new System.Drawing.Point(107, 84);
            this.tx_psw.Name = "tx_psw";
            this.tx_psw.Size = new System.Drawing.Size(153, 20);
            this.tx_psw.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(185, 132);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Simpan";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // Regis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 219);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tx_psw);
            this.Controls.Add(this.tx_user);
            this.Name = "Regis";
            this.Text = "Regis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.TextBox tx_psw;
        private System.Windows.Forms.Button btn;
    }
}