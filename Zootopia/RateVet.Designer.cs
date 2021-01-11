namespace Zootopia
{
    partial class RateVet
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
            this.buttonCloseDeletePet = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonRate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseDeletePet
            // 
            this.buttonCloseDeletePet.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseDeletePet.FlatAppearance.BorderSize = 0;
            this.buttonCloseDeletePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseDeletePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseDeletePet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseDeletePet.Location = new System.Drawing.Point(12, 12);
            this.buttonCloseDeletePet.Name = "buttonCloseDeletePet";
            this.buttonCloseDeletePet.Size = new System.Drawing.Size(36, 36);
            this.buttonCloseDeletePet.TabIndex = 3;
            this.buttonCloseDeletePet.Text = "X";
            this.buttonCloseDeletePet.UseVisualStyleBackColor = false;
            this.buttonCloseDeletePet.Click += new System.EventHandler(this.buttonCloseDeletePet_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(435, 89);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(189, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // buttonRate
            // 
            this.buttonRate.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonRate.FlatAppearance.BorderSize = 0;
            this.buttonRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRate.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRate.ForeColor = System.Drawing.Color.MintCream;
            this.buttonRate.Location = new System.Drawing.Point(495, 158);
            this.buttonRate.Name = "buttonRate";
            this.buttonRate.Size = new System.Drawing.Size(129, 49);
            this.buttonRate.TabIndex = 13;
            this.buttonRate.Text = "Rate";
            this.buttonRate.UseVisualStyleBackColor = false;
            this.buttonRate.Click += new System.EventHandler(this.buttonRate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(126, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Rate";
            // 
            // RateVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRate);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonCloseDeletePet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RateVet";
            this.Text = "RateVet";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseDeletePet;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonRate;
        private System.Windows.Forms.Label label3;
    }
}