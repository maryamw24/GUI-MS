
namespace SignUp
{
    partial class PersonalInfo
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
            this.u_name = new System.Windows.Forms.TextBox();
            this.UName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // u_name
            // 
            this.u_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.u_name.BackColor = System.Drawing.Color.SeaShell;
            this.u_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_name.Location = new System.Drawing.Point(66, 178);
            this.u_name.Name = "u_name";
            this.u_name.Size = new System.Drawing.Size(171, 33);
            this.u_name.TabIndex = 23;
            this.u_name.TextChanged += new System.EventHandler(this.Adress_TextChanged);
            // 
            // UName
            // 
            this.UName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UName.BackColor = System.Drawing.Color.SeaShell;
            this.UName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName.Location = new System.Drawing.Point(66, 93);
            this.UName.Name = "UName";
            this.UName.Size = new System.Drawing.Size(171, 33);
            this.UName.TabIndex = 22;
            this.UName.TextChanged += new System.EventHandler(this.SalonName_TextChanged);
            // 
            // Name
            // 
            this.Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name.Location = new System.Drawing.Point(62, 154);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(62, 21);
            this.Name.TabIndex = 21;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // Phone
            // 
            this.Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Phone.Location = new System.Drawing.Point(62, 234);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(140, 19);
            this.Phone.TabIndex = 20;
            this.Phone.Text = "Phone Numnber";
            this.Phone.Click += new System.EventHandler(this.Phone_Click);
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserName.Location = new System.Drawing.Point(62, 69);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(104, 21);
            this.UserName.TabIndex = 19;
            this.UserName.Text = "UserName";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::SignUp.Properties.Resources.icons8_edit_32;
            this.pictureBox1.InitialImage = global::SignUp.Properties.Resources.icons8_edit_50;
            this.pictureBox1.Location = new System.Drawing.Point(243, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::SignUp.Properties.Resources.icons8_edit_32;
            this.pictureBox2.InitialImage = global::SignUp.Properties.Resources.icons8_edit_50;
            this.pictureBox2.Location = new System.Drawing.Point(243, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::SignUp.Properties.Resources.icons8_edit_32;
            this.pictureBox3.InitialImage = global::SignUp.Properties.Resources.icons8_edit_50;
            this.pictureBox3.Location = new System.Drawing.Point(243, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.BackColor = System.Drawing.Color.IndianRed;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(40, 311);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(251, 43);
            this.Save.TabIndex = 28;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.BackColor = System.Drawing.Color.SeaShell;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(66, 257);
            this.maskedTextBox1.Mask = "0000-0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(171, 30);
            this.maskedTextBox1.TabIndex = 29;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // PersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(331, 423);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.u_name);
            this.Controls.Add(this.UName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.UserName);
            /*this.Name = "PersonalInfo";*/
            this.Text = "PersonalInfo";
            this.Load += new System.EventHandler(this.PersonalInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox u_name;
        private System.Windows.Forms.TextBox UName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}