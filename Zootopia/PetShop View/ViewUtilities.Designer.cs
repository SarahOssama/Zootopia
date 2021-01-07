namespace Zootopia
{
    partial class ViewUtilities
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
            this.ViewUtilitiesDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonviewUtilities = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUtilitiesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseViewUtilities
            // 
            this.buttonCloseViewUtilities.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseViewUtilities.FlatAppearance.BorderSize = 0;
            this.buttonCloseViewUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseViewUtilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseViewUtilities.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseViewUtilities.Location = new System.Drawing.Point(14, 15);
            this.buttonCloseViewUtilities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseViewUtilities.Name = "buttonCloseViewUtilities";
            this.buttonCloseViewUtilities.Size = new System.Drawing.Size(40, 45);
            this.buttonCloseViewUtilities.TabIndex = 3;
            this.buttonCloseViewUtilities.Text = "X";
            this.buttonCloseViewUtilities.UseVisualStyleBackColor = false;
            this.buttonCloseViewUtilities.Click += new System.EventHandler(this.buttonCloseView_Click);
            // 
            // ViewUtilitiesDataGrid
            // 
            this.ViewUtilitiesDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewUtilitiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewUtilitiesDataGrid.Location = new System.Drawing.Point(62, 76);
            this.ViewUtilitiesDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewUtilitiesDataGrid.Name = "ViewUtilitiesDataGrid";
            this.ViewUtilitiesDataGrid.RowHeadersWidth = 62;
            this.ViewUtilitiesDataGrid.RowTemplate.Height = 28;
            this.ViewUtilitiesDataGrid.Size = new System.Drawing.Size(591, 362);
            this.ViewUtilitiesDataGrid.TabIndex = 10;
            // 
            // buttonviewUtilities
            // 
            this.buttonviewUtilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonviewUtilities.FlatAppearance.BorderSize = 0;
            this.buttonviewUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonviewUtilities.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonviewUtilities.ForeColor = System.Drawing.Color.MintCream;
            this.buttonviewUtilities.Location = new System.Drawing.Point(384, 455);
            this.buttonviewUtilities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonviewUtilities.Name = "buttonviewUtilities";
            this.buttonviewUtilities.Size = new System.Drawing.Size(145, 61);
            this.buttonviewUtilities.TabIndex = 11;
            this.buttonviewUtilities.Text = "View";
            this.buttonviewUtilities.UseVisualStyleBackColor = false;
            // 
            // ViewUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(836, 800);
            this.Controls.Add(this.buttonviewUtilities);
            this.Controls.Add(this.ViewUtilitiesDataGrid);
            this.Controls.Add(this.buttonCloseViewUtilities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(836, 800);
            this.Name = "ViewUtilities";
            this.Text = "ViewUtilities";
            ((System.ComponentModel.ISupportInitialize)(this.ViewUtilitiesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseViewUtilities;
        private System.Windows.Forms.DataGridView ViewUtilitiesDataGrid;
        private System.Windows.Forms.Button buttonviewUtilities;
    }
}