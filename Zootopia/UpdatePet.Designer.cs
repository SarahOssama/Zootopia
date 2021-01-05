namespace Zootopia
{
    partial class UpdatePet
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
            this.buttonCloseUpdate = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCloseUpdate
            // 
            this.buttonCloseUpdate.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseUpdate.FlatAppearance.BorderSize = 0;
            this.buttonCloseUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseUpdate.Location = new System.Drawing.Point(12, 12);
            this.buttonCloseUpdate.Name = "buttonCloseUpdate";
            this.buttonCloseUpdate.Size = new System.Drawing.Size(36, 36);
            this.buttonCloseUpdate.TabIndex = 1;
            this.buttonCloseUpdate.Text = "X";
            this.buttonCloseUpdate.UseVisualStyleBackColor = false;
            this.buttonCloseUpdate.Click += new System.EventHandler(this.buttonCloseUpdate_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.MintCream;
            this.buttonUpdate.Location = new System.Drawing.Point(522, 375);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(129, 49);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // UpdatePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(697, 603);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCloseUpdate);
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePet";
            this.Text = "UpdatePet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseUpdate;
        private System.Windows.Forms.Button buttonUpdate;
    }
}