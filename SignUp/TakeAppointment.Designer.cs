
namespace SignUp
{
    partial class TakeAppointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Bills = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSelect = new System.Windows.Forms.DateTimePicker();
            this.Add_Another = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ServicesBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(503, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Bills);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateSelect);
            this.panel2.Controls.Add(this.Add_Another);
            this.panel2.Controls.Add(this.confirm);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ServicesBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1305, 756);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1305, 83);
            this.panel3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(563, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 34);
            this.label4.TabIndex = 10;
            this.label4.Text = "Take Appointment";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(480, 505);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(315, 55);
            this.button3.TabIndex = 8;
            this.button3.Text = "Confirm Appointment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bills
            // 
            this.Bills.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Bills.AutoSize = true;
            this.Bills.BackColor = System.Drawing.Color.White;
            this.Bills.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills.Location = new System.Drawing.Point(779, 416);
            this.Bills.Name = "Bills";
            this.Bills.Size = new System.Drawing.Size(126, 30);
            this.Bills.TabIndex = 7;
            this.Bills.Text = "Your Bill";
            this.Bills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(740, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Total bill here";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select date here";
            // 
            // dateSelect
            // 
            this.dateSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateSelect.CalendarMonthBackground = System.Drawing.Color.SeaShell;
            this.dateSelect.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSelect.Location = new System.Drawing.Point(322, 410);
            this.dateSelect.Name = "dateSelect";
            this.dateSelect.Size = new System.Drawing.Size(227, 36);
            this.dateSelect.TabIndex = 4;
            this.dateSelect.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Add_Another
            // 
            this.Add_Another.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Another.BackColor = System.Drawing.Color.IndianRed;
            this.Add_Another.FlatAppearance.BorderSize = 0;
            this.Add_Another.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Another.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Another.Location = new System.Drawing.Point(822, 265);
            this.Add_Another.Name = "Add_Another";
            this.Add_Another.Size = new System.Drawing.Size(182, 44);
            this.Add_Another.TabIndex = 3;
            this.Add_Another.Text = "Add Another";
            this.Add_Another.UseVisualStyleBackColor = false;
            this.Add_Another.Click += new System.EventHandler(this.Add_Another_Click);
            // 
            // confirm
            // 
            this.confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm.BackColor = System.Drawing.Color.IndianRed;
            this.confirm.FlatAppearance.BorderSize = 0;
            this.confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(636, 262);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(146, 47);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Services here";
            // 
            // ServicesBox
            // 
            this.ServicesBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ServicesBox.BackColor = System.Drawing.Color.SeaShell;
            this.ServicesBox.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesBox.FormattingEnabled = true;
            this.ServicesBox.Location = new System.Drawing.Point(306, 261);
            this.ServicesBox.Name = "ServicesBox";
            this.ServicesBox.Size = new System.Drawing.Size(277, 37);
            this.ServicesBox.TabIndex = 0;
            // 
            // TakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1305, 756);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TakeAppointment";
            this.Text = "TakeAppointment";
            this.Load += new System.EventHandler(this.TakeAppointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServicesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateSelect;
        private System.Windows.Forms.Button Add_Another;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Bills;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}