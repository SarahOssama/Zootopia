namespace Zootopia
{
    partial class UpdateVetLocation
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
            this.textBoxNewLocation = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCloseViewUtilities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewLocation
            // 
            this.textBoxNewLocation.Location = new System.Drawing.Point(273, 285);
            this.textBoxNewLocation.Name = "textBoxNewLocation";
            this.textBoxNewLocation.Size = new System.Drawing.Size(170, 26);
            this.textBoxNewLocation.TabIndex = 40;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(187, 285);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 26);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Other";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(273, 242);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 28);
            this.comboBox1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "New Location:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(473, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 40);
            this.button3.TabIndex = 41;
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
            this.buttonCloseViewUtilities.Location = new System.Drawing.Point(41, 36);
            this.buttonCloseViewUtilities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseViewUtilities.Name = "buttonCloseViewUtilities";
            this.buttonCloseViewUtilities.Size = new System.Drawing.Size(40, 45);
            this.buttonCloseViewUtilities.TabIndex = 42;
            this.buttonCloseViewUtilities.Text = "X";
            this.buttonCloseViewUtilities.UseVisualStyleBackColor = false;
            this.buttonCloseViewUtilities.Click += new System.EventHandler(this.buttonCloseViewUtilities_Click);
            // 
            // UpdateVetLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(649, 546);
            this.Controls.Add(this.buttonCloseViewUtilities);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxNewLocation);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateVetLocation";
            this.Text = "UpdateVetLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewLocation;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCloseViewUtilities;
    }
}