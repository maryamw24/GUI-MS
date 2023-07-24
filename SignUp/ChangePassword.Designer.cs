
namespace SignUp
{
    partial class ChangePassword
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
            this.Save = new System.Windows.Forms.Button();
            this.N_Password = new System.Windows.Forms.TextBox();
            this.O_Password = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.O_P = new System.Windows.Forms.Label();
            this.C_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.IndianRed;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(35, 291);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(251, 43);
            this.Save.TabIndex = 35;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // N_Password
            // 
            this.N_Password.BackColor = System.Drawing.Color.SeaShell;
            this.N_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_Password.Location = new System.Drawing.Point(51, 153);
            this.N_Password.Name = "N_Password";
            this.N_Password.Size = new System.Drawing.Size(225, 30);
            this.N_Password.TabIndex = 34;
            // 
            // O_Password
            // 
            this.O_Password.BackColor = System.Drawing.Color.SeaShell;
            this.O_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_Password.Location = new System.Drawing.Point(51, 84);
            this.O_Password.Name = "O_Password";
            this.O_Password.Size = new System.Drawing.Size(225, 30);
            this.O_Password.TabIndex = 33;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name.Location = new System.Drawing.Point(47, 129);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(141, 21);
            this.Name.TabIndex = 32;
            this.Name.Text = "New Password";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Phone.Location = new System.Drawing.Point(47, 203);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(168, 20);
            this.Phone.TabIndex = 31;
            this.Phone.Text = "Confirm Password";
            // 
            // O_P
            // 
            this.O_P.AutoSize = true;
            this.O_P.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.O_P.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.O_P.Location = new System.Drawing.Point(47, 60);
            this.O_P.Name = "O_P";
            this.O_P.Size = new System.Drawing.Size(134, 21);
            this.O_P.TabIndex = 30;
            this.O_P.Text = "Old Password";
            // 
            // C_Password
            // 
            this.C_Password.BackColor = System.Drawing.Color.SeaShell;
            this.C_Password.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_Password.Location = new System.Drawing.Point(51, 226);
            this.C_Password.Name = "C_Password";
            this.C_Password.Size = new System.Drawing.Size(225, 30);
            this.C_Password.TabIndex = 36;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.C_Password);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.N_Password);
            this.Controls.Add(this.O_Password);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.O_P);
            /*this.Name = "ChangePassword";*/
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox N_Password;
        private System.Windows.Forms.TextBox O_Password;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label O_P;
        private System.Windows.Forms.TextBox C_Password;
    }
}