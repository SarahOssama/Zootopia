
namespace Zootopia
{
    partial class DeleteTrainer
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteTrainer = new System.Windows.Forms.Button();
            this.buttonCloseDeleteTrainer = new System.Windows.Forms.Button();
            this.DeleteTrainerNameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(64, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter Trainer Name";
            // 
            // buttonDeleteTrainer
            // 
            this.buttonDeleteTrainer.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonDeleteTrainer.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTrainer.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTrainer.ForeColor = System.Drawing.Color.MintCream;
            this.buttonDeleteTrainer.Location = new System.Drawing.Point(491, 322);
            this.buttonDeleteTrainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteTrainer.Name = "buttonDeleteTrainer";
            this.buttonDeleteTrainer.Size = new System.Drawing.Size(145, 61);
            this.buttonDeleteTrainer.TabIndex = 9;
            this.buttonDeleteTrainer.Text = "Delete";
            this.buttonDeleteTrainer.UseVisualStyleBackColor = false;
            this.buttonDeleteTrainer.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCloseDeleteTrainer
            // 
            this.buttonCloseDeleteTrainer.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseDeleteTrainer.FlatAppearance.BorderSize = 0;
            this.buttonCloseDeleteTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseDeleteTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseDeleteTrainer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseDeleteTrainer.Location = new System.Drawing.Point(12, 13);
            this.buttonCloseDeleteTrainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseDeleteTrainer.Name = "buttonCloseDeleteTrainer";
            this.buttonCloseDeleteTrainer.Size = new System.Drawing.Size(40, 45);
            this.buttonCloseDeleteTrainer.TabIndex = 8;
            this.buttonCloseDeleteTrainer.Text = "X";
            this.buttonCloseDeleteTrainer.UseVisualStyleBackColor = false;
            // 
            // DeleteTrainerNameComboBox
            // 
            this.DeleteTrainerNameComboBox.FormattingEnabled = true;
            this.DeleteTrainerNameComboBox.Location = new System.Drawing.Point(413, 153);
            this.DeleteTrainerNameComboBox.Name = "DeleteTrainerNameComboBox";
            this.DeleteTrainerNameComboBox.Size = new System.Drawing.Size(223, 28);
            this.DeleteTrainerNameComboBox.TabIndex = 14;
            // 
            // DeleteTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(884, 536);
            this.Controls.Add(this.DeleteTrainerNameComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteTrainer);
            this.Controls.Add(this.buttonCloseDeleteTrainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteTrainer";
            this.Text = "DeleteTrainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteTrainer;
        private System.Windows.Forms.Button buttonCloseDeleteTrainer;
        private System.Windows.Forms.ComboBox DeleteTrainerNameComboBox;
    }
}