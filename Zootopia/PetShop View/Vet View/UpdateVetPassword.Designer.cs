namespace Zootopia
{
    partial class UpdateVetPassword
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
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCloseViewUtilities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(255, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "Password should be 8 charachters or less";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxPassword.Location = new System.Drawing.Point(259, 251);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(170, 26);
            this.textBoxPassword.TabIndex = 39;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 32);
            this.label5.TabIndex = 38;
            this.label5.Text = "New Password:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(477, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 40);
            this.button3.TabIndex = 42;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonCloseViewUtilities
            // 
            this.buttonCloseViewUtilities.BackColor = System.Drawing.Color.Red;
            this.buttonCloseViewUtilities.FlatAppearance.BorderSize = 0;
            this.buttonCloseViewUtilities.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonCloseViewUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseViewUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseViewUtilities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseViewUtilities.Location = new System.Drawing.Point(38, 38);
            this.buttonCloseViewUtilities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseViewUtilities.Name = "buttonCloseViewUtilities";
            this.buttonCloseViewUtilities.Size = new System.Drawing.Size(40, 45);
            this.buttonCloseViewUtilities.TabIndex = 43;
            this.buttonCloseViewUtilities.Text = "X";
            this.buttonCloseViewUtilities.UseVisualStyleBackColor = false;
            this.buttonCloseViewUtilities.Click += new System.EventHandler(this.buttonCloseViewUtilities_Click);
            // 
            // UpdateVetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(649, 546);
            this.Controls.Add(this.buttonCloseViewUtilities);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateVetPassword";
            this.Text = "UpdateVetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCloseViewUtilities;
    }
}