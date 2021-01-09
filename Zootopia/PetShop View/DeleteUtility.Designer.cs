namespace Zootopia
{
    partial class DeleteUtility
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
            this.buttonCloseViewUtilities = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonDeleteUtility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCloseViewUtilities
            // 
            this.buttonCloseViewUtilities.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseViewUtilities.FlatAppearance.BorderSize = 0;
            this.buttonCloseViewUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseViewUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseViewUtilities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseViewUtilities.Location = new System.Drawing.Point(12, 12);
            this.buttonCloseViewUtilities.Name = "buttonCloseViewUtilities";
            this.buttonCloseViewUtilities.Size = new System.Drawing.Size(36, 36);
            this.buttonCloseViewUtilities.TabIndex = 4;
            this.buttonCloseViewUtilities.Text = "X";
            this.buttonCloseViewUtilities.UseVisualStyleBackColor = false;
            this.buttonCloseViewUtilities.Click += new System.EventHandler(this.buttonCloseViewUtilities_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(60, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Utility Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(60, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Utility Category";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(331, 159);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(331, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // buttonDeleteUtility
            // 
            this.buttonDeleteUtility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDeleteUtility.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUtility.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUtility.ForeColor = System.Drawing.Color.MintCream;
            this.buttonDeleteUtility.Location = new System.Drawing.Point(357, 231);
            this.buttonDeleteUtility.Name = "buttonDeleteUtility";
            this.buttonDeleteUtility.Size = new System.Drawing.Size(129, 49);
            this.buttonDeleteUtility.TabIndex = 9;
            this.buttonDeleteUtility.Text = "Delete";
            this.buttonDeleteUtility.UseVisualStyleBackColor = false;
            // 
            // DeleteUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(588, 545);
            this.Controls.Add(this.buttonDeleteUtility);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCloseViewUtilities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteUtility";
            this.Text = "DeleteUtility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseViewUtilities;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonDeleteUtility;
    }
}