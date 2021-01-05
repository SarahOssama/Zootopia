namespace Zootopia
{
    partial class PetOwnerView
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelPetDetailsSubMenu = new System.Windows.Forms.Panel();
            this.buttonDeletePet = new System.Windows.Forms.Button();
            this.buttonUpdatePet = new System.Windows.Forms.Button();
            this.buttonInsertPet = new System.Windows.Forms.Button();
            this.buttonPetDetail = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelPetDetailsSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.AutoScroll = true;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(161)))), ((int)(((byte)(171)))));
            this.panelLeft.Controls.Add(this.panelPetDetailsSubMenu);
            this.panelLeft.Controls.Add(this.buttonPetDetail);
            this.panelLeft.Controls.Add(this.panelLogo);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(231, 603);
            this.panelLeft.TabIndex = 0;
            // 
            // panelPetDetailsSubMenu
            // 
            this.panelPetDetailsSubMenu.BackColor = System.Drawing.Color.White;
            this.panelPetDetailsSubMenu.Controls.Add(this.buttonDeletePet);
            this.panelPetDetailsSubMenu.Controls.Add(this.buttonUpdatePet);
            this.panelPetDetailsSubMenu.Controls.Add(this.buttonInsertPet);
            this.panelPetDetailsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPetDetailsSubMenu.Location = new System.Drawing.Point(0, 118);
            this.panelPetDetailsSubMenu.Name = "panelPetDetailsSubMenu";
            this.panelPetDetailsSubMenu.Size = new System.Drawing.Size(231, 137);
            this.panelPetDetailsSubMenu.TabIndex = 2;
            this.panelPetDetailsSubMenu.Visible = false;
            // 
            // buttonDeletePet
            // 
            this.buttonDeletePet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeletePet.FlatAppearance.BorderSize = 0;
            this.buttonDeletePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeletePet.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePet.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDeletePet.Location = new System.Drawing.Point(0, 80);
            this.buttonDeletePet.Name = "buttonDeletePet";
            this.buttonDeletePet.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonDeletePet.Size = new System.Drawing.Size(231, 40);
            this.buttonDeletePet.TabIndex = 2;
            this.buttonDeletePet.Text = "Delete Pet";
            this.buttonDeletePet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeletePet.UseVisualStyleBackColor = true;
            this.buttonDeletePet.Click += new System.EventHandler(this.buttonDeletePet_Click);
            // 
            // buttonUpdatePet
            // 
            this.buttonUpdatePet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUpdatePet.FlatAppearance.BorderSize = 0;
            this.buttonUpdatePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdatePet.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdatePet.ForeColor = System.Drawing.Color.DimGray;
            this.buttonUpdatePet.Location = new System.Drawing.Point(0, 40);
            this.buttonUpdatePet.Name = "buttonUpdatePet";
            this.buttonUpdatePet.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonUpdatePet.Size = new System.Drawing.Size(231, 40);
            this.buttonUpdatePet.TabIndex = 1;
            this.buttonUpdatePet.Text = "Update Pet";
            this.buttonUpdatePet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUpdatePet.UseVisualStyleBackColor = true;
            this.buttonUpdatePet.Click += new System.EventHandler(this.buttonUpdatePet_Click);
            // 
            // buttonInsertPet
            // 
            this.buttonInsertPet.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInsertPet.FlatAppearance.BorderSize = 0;
            this.buttonInsertPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInsertPet.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertPet.ForeColor = System.Drawing.Color.DimGray;
            this.buttonInsertPet.Location = new System.Drawing.Point(0, 0);
            this.buttonInsertPet.Name = "buttonInsertPet";
            this.buttonInsertPet.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonInsertPet.Size = new System.Drawing.Size(231, 40);
            this.buttonInsertPet.TabIndex = 0;
            this.buttonInsertPet.Text = "Insert Pet";
            this.buttonInsertPet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInsertPet.UseVisualStyleBackColor = true;
            this.buttonInsertPet.Click += new System.EventHandler(this.buttonInsertPet_Click);
            // 
            // buttonPetDetail
            // 
            this.buttonPetDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPetDetail.FlatAppearance.BorderSize = 0;
            this.buttonPetDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPetDetail.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPetDetail.ForeColor = System.Drawing.Color.DimGray;
            this.buttonPetDetail.Location = new System.Drawing.Point(0, 73);
            this.buttonPetDetail.Name = "buttonPetDetail";
            this.buttonPetDetail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPetDetail.Size = new System.Drawing.Size(231, 45);
            this.buttonPetDetail.TabIndex = 1;
            this.buttonPetDetail.Text = "Pet Details";
            this.buttonPetDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPetDetail.UseVisualStyleBackColor = true;
            this.buttonPetDetail.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(231, 73);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zootopia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.LightGray;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(231, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(697, 603);
            this.panelChildForm.TabIndex = 1;
            // 
            // PetOwnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 603);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelLeft);
            this.Name = "PetOwnerView";
            this.Text = "PetOwnerView";
            this.panelLeft.ResumeLayout(false);
            this.panelPetDetailsSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelPetDetailsSubMenu;
        private System.Windows.Forms.Button buttonDeletePet;
        private System.Windows.Forms.Button buttonUpdatePet;
        private System.Windows.Forms.Button buttonInsertPet;
        private System.Windows.Forms.Button buttonPetDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChildForm;
    }
}