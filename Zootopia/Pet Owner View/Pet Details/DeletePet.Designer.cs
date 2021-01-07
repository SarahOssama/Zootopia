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
            this.DeletePetNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeletePetTypeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCloseDeletePet
            // 
            this.buttonCloseDeletePet.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseDeletePet.FlatAppearance.BorderSize = 0;
            this.buttonCloseDeletePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseDeletePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseDeletePet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseDeletePet.Location = new System.Drawing.Point(14, 15);
            this.buttonCloseDeletePet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseDeletePet.Name = "buttonCloseDeletePet";
            this.buttonCloseDeletePet.Size = new System.Drawing.Size(40, 45);
            this.buttonCloseDeletePet.TabIndex = 1;
            this.buttonCloseDeletePet.Text = "X";
            this.buttonCloseDeletePet.UseVisualStyleBackColor = false;
            this.buttonCloseDeletePet.Click += new System.EventHandler(this.buttonCloseDelete_Click);
            // 
            // buttonDeletePet
            // 
            this.buttonDeletePet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDeletePet.FlatAppearance.BorderSize = 0;
            this.buttonDeletePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePet.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePet.ForeColor = System.Drawing.Color.MintCream;
            this.buttonDeletePet.Location = new System.Drawing.Point(493, 324);
            this.buttonDeletePet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeletePet.Name = "buttonDeletePet";
            this.buttonDeletePet.Size = new System.Drawing.Size(145, 61);
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
            this.label1.Location = new System.Drawing.Point(66, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Pet Name";
            // 
            // DeletePetNameTextBox
            // 
            this.DeletePetNameTextBox.Location = new System.Drawing.Point(414, 155);
            this.DeletePetNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeletePetNameTextBox.Name = "DeletePetNameTextBox";
            this.DeletePetNameTextBox.Size = new System.Drawing.Size(223, 26);
            this.DeletePetNameTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(66, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Pet type";
            // 
            // DeletePetTypeTextBox
            // 
            this.DeletePetTypeTextBox.Location = new System.Drawing.Point(414, 230);
            this.DeletePetTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeletePetTypeTextBox.Name = "DeletePetTypeTextBox";
            this.DeletePetTypeTextBox.Size = new System.Drawing.Size(223, 26);
            this.DeletePetTypeTextBox.TabIndex = 7;
            // 
            // DeletePet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(836, 800);
            this.Controls.Add(this.DeletePetTypeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeletePetNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeletePet);
            this.Controls.Add(this.buttonCloseDeletePet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(836, 800);
            this.Name = "DeletePet";
            this.Text = "DeletePet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseDeletePet;
        private System.Windows.Forms.Button buttonDeletePet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DeletePetNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeletePetTypeTextBox;
    }
}