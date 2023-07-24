
namespace SignUp
{
    partial class AddReview
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Review = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RosyBrown;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 44);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reviews";
            // 
            // Review
            // 
            this.Review.BackColor = System.Drawing.Color.SeaShell;
            this.Review.Location = new System.Drawing.Point(203, 199);
            this.Review.Multiline = true;
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(383, 132);
            this.Review.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Your Review Here";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.IndianRed;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Black;
            this.Save.Location = new System.Drawing.Point(447, 346);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(139, 34);
            this.Save.TabIndex = 15;
            this.Save.Text = "Add";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(885, 520);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Review);
            this.Controls.Add(this.panel4);
            this.Name = "AddReview";
            this.Text = "AddReview";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Review;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
    }
}