
namespace Zootopia
{
    partial class PetShopSearch
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRateRange = new System.Windows.Forms.Label();
            this.PSRateSearchComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPriceRange = new System.Windows.Forms.Label();
            this.PSPriceSearchComboBox = new System.Windows.Forms.ComboBox();
            this.PSLocationSearchComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PetshopSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonSearchForPetShop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCloseUpdate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetshopSearchDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PSLocationSearchComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 126);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 231);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelRateRange);
            this.panel2.Controls.Add(this.PSRateSearchComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(355, 156);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 73);
            this.panel2.TabIndex = 17;
            // 
            // labelRateRange
            // 
            this.labelRateRange.AutoSize = true;
            this.labelRateRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRateRange.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateRange.ForeColor = System.Drawing.Color.Red;
            this.labelRateRange.Location = new System.Drawing.Point(0, 28);
            this.labelRateRange.Name = "labelRateRange";
            this.labelRateRange.Size = new System.Drawing.Size(173, 19);
            this.labelRateRange.TabIndex = 52;
            this.labelRateRange.Text = "Please choose a rate range";
            // 
            // PSRateSearchComboBox
            // 
            this.PSRateSearchComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSRateSearchComboBox.FormattingEnabled = true;
            this.PSRateSearchComboBox.Location = new System.Drawing.Point(0, 0);
            this.PSRateSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PSRateSearchComboBox.Name = "PSRateSearchComboBox";
            this.PSRateSearchComboBox.Size = new System.Drawing.Size(346, 28);
            this.PSRateSearchComboBox.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPriceRange);
            this.panel1.Controls.Add(this.PSPriceSearchComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(355, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 73);
            this.panel1.TabIndex = 17;
            // 
            // labelPriceRange
            // 
            this.labelPriceRange.AutoSize = true;
            this.labelPriceRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPriceRange.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceRange.ForeColor = System.Drawing.Color.Red;
            this.labelPriceRange.Location = new System.Drawing.Point(0, 28);
            this.labelPriceRange.Name = "labelPriceRange";
            this.labelPriceRange.Size = new System.Drawing.Size(179, 19);
            this.labelPriceRange.TabIndex = 51;
            this.labelPriceRange.Text = "Please choose a price range";
            // 
            // PSPriceSearchComboBox
            // 
            this.PSPriceSearchComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PSPriceSearchComboBox.FormattingEnabled = true;
            this.PSPriceSearchComboBox.Location = new System.Drawing.Point(0, 0);
            this.PSPriceSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PSPriceSearchComboBox.Name = "PSPriceSearchComboBox";
            this.PSPriceSearchComboBox.Size = new System.Drawing.Size(346, 28);
            this.PSPriceSearchComboBox.TabIndex = 6;
            // 
            // PSLocationSearchComboBox
            // 
            this.PSLocationSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSLocationSearchComboBox.FormattingEnabled = true;
            this.PSLocationSearchComboBox.Location = new System.Drawing.Point(355, 2);
            this.PSLocationSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PSLocationSearchComboBox.Name = "PSLocationSearchComboBox";
            this.PSLocationSearchComboBox.Size = new System.Drawing.Size(346, 28);
            this.PSLocationSearchComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Range";
            // 
            // PetshopSearchDataGrid
            // 
            this.PetshopSearchDataGrid.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.PetshopSearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PetshopSearchDataGrid.Location = new System.Drawing.Point(75, 465);
            this.PetshopSearchDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PetshopSearchDataGrid.Name = "PetshopSearchDataGrid";
            this.PetshopSearchDataGrid.RowHeadersWidth = 62;
            this.PetshopSearchDataGrid.RowTemplate.Height = 28;
            this.PetshopSearchDataGrid.Size = new System.Drawing.Size(654, 220);
            this.PetshopSearchDataGrid.TabIndex = 14;
            // 
            // buttonSearchForPetShop
            // 
            this.buttonSearchForPetShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchForPetShop.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonSearchForPetShop.FlatAppearance.BorderSize = 0;
            this.buttonSearchForPetShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchForPetShop.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchForPetShop.ForeColor = System.Drawing.Color.MintCream;
            this.buttonSearchForPetShop.Location = new System.Drawing.Point(580, 382);
            this.buttonSearchForPetShop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearchForPetShop.Name = "buttonSearchForPetShop";
            this.buttonSearchForPetShop.Size = new System.Drawing.Size(198, 61);
            this.buttonSearchForPetShop.TabIndex = 13;
            this.buttonSearchForPetShop.Text = "Search";
            this.buttonSearchForPetShop.UseVisualStyleBackColor = false;
            this.buttonSearchForPetShop.Click += new System.EventHandler(this.buttonSearchForPetShop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(58, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(58, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter";
            // 
            // buttonCloseUpdate
            // 
            this.buttonCloseUpdate.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseUpdate.FlatAppearance.BorderSize = 0;
            this.buttonCloseUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseUpdate.Location = new System.Drawing.Point(12, 12);
            this.buttonCloseUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseUpdate.Name = "buttonCloseUpdate";
            this.buttonCloseUpdate.Size = new System.Drawing.Size(40, 42);
            this.buttonCloseUpdate.TabIndex = 16;
            this.buttonCloseUpdate.Text = "X";
            this.buttonCloseUpdate.UseVisualStyleBackColor = false;
            this.buttonCloseUpdate.Click += new System.EventHandler(this.buttonCloseUpdate_Click);
            // 
            // PetShopSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(836, 800);
            this.Controls.Add(this.buttonCloseUpdate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PetshopSearchDataGrid);
            this.Controls.Add(this.buttonSearchForPetShop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(836, 800);
            this.Name = "PetShopSearch";
            this.Text = "PetShopSearch";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PetshopSearchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PetshopSearchDataGrid;
        private System.Windows.Forms.Button buttonSearchForPetShop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCloseUpdate;
        private System.Windows.Forms.ComboBox PSRateSearchComboBox;
        private System.Windows.Forms.ComboBox PSPriceSearchComboBox;
        private System.Windows.Forms.ComboBox PSLocationSearchComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPriceRange;
        private System.Windows.Forms.Label labelRateRange;
    }
}