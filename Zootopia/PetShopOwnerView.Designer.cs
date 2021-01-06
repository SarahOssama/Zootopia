namespace Zootopia
{
    partial class PetShopOwnerView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddUtility = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonDeleteUtility = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(173)))), ((int)(((byte)(162)))));
            this.panel1.Controls.Add(this.buttonDeleteUtility);
            this.panel1.Controls.Add(this.buttonView);
            this.panel1.Controls.Add(this.buttonAddUtility);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 545);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 81);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zootopia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonAddUtility
            // 
            this.buttonAddUtility.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddUtility.FlatAppearance.BorderSize = 0;
            this.buttonAddUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUtility.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUtility.ForeColor = System.Drawing.Color.DimGray;
            this.buttonAddUtility.Location = new System.Drawing.Point(0, 81);
            this.buttonAddUtility.Name = "buttonAddUtility";
            this.buttonAddUtility.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAddUtility.Size = new System.Drawing.Size(212, 58);
            this.buttonAddUtility.TabIndex = 2;
            this.buttonAddUtility.Text = "Add Utility";
            this.buttonAddUtility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddUtility.UseVisualStyleBackColor = true;
            this.buttonAddUtility.Click += new System.EventHandler(this.buttonAddUtility_Click);
            // 
            // buttonView
            // 
            this.buttonView.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.DimGray;
            this.buttonView.Location = new System.Drawing.Point(0, 139);
            this.buttonView.Name = "buttonView";
            this.buttonView.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonView.Size = new System.Drawing.Size(212, 90);
            this.buttonView.TabIndex = 3;
            this.buttonView.Text = "View List of utilities";
            this.buttonView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonDeleteUtility
            // 
            this.buttonDeleteUtility.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeleteUtility.FlatAppearance.BorderSize = 0;
            this.buttonDeleteUtility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUtility.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUtility.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDeleteUtility.Location = new System.Drawing.Point(0, 229);
            this.buttonDeleteUtility.Name = "buttonDeleteUtility";
            this.buttonDeleteUtility.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDeleteUtility.Size = new System.Drawing.Size(212, 58);
            this.buttonDeleteUtility.TabIndex = 4;
            this.buttonDeleteUtility.Text = "Delete Utility";
            this.buttonDeleteUtility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteUtility.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.LightGray;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(212, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(588, 545);
            this.panelChildForm.TabIndex = 1;
            // 
            // PetShopOwnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "PetShopOwnerView";
            this.Text = "PetShopOwnerView";
            this.Load += new System.EventHandler(this.PetShopOwnerView_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteUtility;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonAddUtility;
        private System.Windows.Forms.Panel panelChildForm;
    }
}