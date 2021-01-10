namespace Zootopia
{
    partial class DeletePet
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
            this.buttonDeletePet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.buttonCloseDeletePet.TabIndex = 1;
            this.buttonCloseDeletePet.Text = "X";
            this.buttonCloseDeletePet.UseVisualStyleBackColor = false;
            this.buttonCloseDeletePet.Click += new System.EventHandler(this.buttonCloseDelete_Click);
            // 
            // buttonDeletePet
            // 
            this.buttonDeletePet.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonDeletePet.FlatAppearance.BorderSize = 0;
            this.buttonDeletePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePet.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePet.ForeColor = System.Drawing.Color.MintCream;
            this.buttonDeletePet.Location = new System.Drawing.Point(500, 212);
            this.buttonDeletePet.Name = "buttonDeletePet";
            this.buttonDeletePet.Size = new System.Drawing.Size(129, 49);
            this.buttonDeletePet.TabIndex = 3;
            this.buttonDeletePet.Text = "Delete";
            this.buttonDeletePet.UseVisualStyleBackColor = false;
            this.buttonDeletePet.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(59, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Pet Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(409, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // DeletePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(743, 640);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeletePet);
            this.Controls.Add(this.buttonCloseDeletePet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(743, 640);
            this.Name = "DeletePet";
            this.Text = "DeletePet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseDeletePet;
        private System.Windows.Forms.Button buttonDeletePet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}