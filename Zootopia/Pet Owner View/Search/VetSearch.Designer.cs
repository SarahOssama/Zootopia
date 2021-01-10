
namespace Zootopia
{
    partial class VetSearch
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
            this.VRateSearchComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPriceRange = new System.Windows.Forms.Label();
            this.VPriceSearchComboBox = new System.Windows.Forms.ComboBox();
            this.VLocationSearchComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCloseVetSearch = new System.Windows.Forms.Button();
            this.VetSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonSearchForVet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VetSearchDataGrid)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.VLocationSearchComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 185);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelRateRange);
            this.panel2.Controls.Add(this.VRateSearchComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(316, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 57);
            this.panel2.TabIndex = 23;
            // 
            // labelRateRange
            // 
            this.labelRateRange.AutoSize = true;
            this.labelRateRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRateRange.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateRange.ForeColor = System.Drawing.Color.Red;
            this.labelRateRange.Location = new System.Drawing.Point(0, 24);
            this.labelRateRange.Name = "labelRateRange";
            this.labelRateRange.Size = new System.Drawing.Size(165, 17);
            this.labelRateRange.TabIndex = 52;
            this.labelRateRange.Text = "Please choose a price range";
            // 
            // VRateSearchComboBox
            // 
            this.VRateSearchComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.VRateSearchComboBox.FormattingEnabled = true;
            this.VRateSearchComboBox.Items.AddRange(new object[] {
            "1-2",
            "2-3",
            "3-4",
            "4-5"});
            this.VRateSearchComboBox.Location = new System.Drawing.Point(0, 0);
            this.VRateSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VRateSearchComboBox.Name = "VRateSearchComboBox";
            this.VRateSearchComboBox.Size = new System.Drawing.Size(307, 24);
            this.VRateSearchComboBox.TabIndex = 7;
            this.VRateSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.VRateSearchComboBox_TextChange);
            this.VRateSearchComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RateRangeComboBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPriceRange);
            this.panel1.Controls.Add(this.VPriceSearchComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(316, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 57);
            this.panel1.TabIndex = 23;
            // 
            // labelPriceRange
            // 
            this.labelPriceRange.AutoSize = true;
            this.labelPriceRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPriceRange.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceRange.ForeColor = System.Drawing.Color.Red;
            this.labelPriceRange.Location = new System.Drawing.Point(0, 24);
            this.labelPriceRange.Name = "labelPriceRange";
            this.labelPriceRange.Size = new System.Drawing.Size(165, 17);
            this.labelPriceRange.TabIndex = 51;
            this.labelPriceRange.Text = "Please choose a price range";
            // 
            // VPriceSearchComboBox
            // 
            this.VPriceSearchComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.VPriceSearchComboBox.FormattingEnabled = true;
            this.VPriceSearchComboBox.Items.AddRange(new object[] {
            "100-200",
            "200-300",
            "300-400",
            "400-500"});
            this.VPriceSearchComboBox.Location = new System.Drawing.Point(0, 0);
            this.VPriceSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VPriceSearchComboBox.Name = "VPriceSearchComboBox";
            this.VPriceSearchComboBox.Size = new System.Drawing.Size(307, 24);
            this.VPriceSearchComboBox.TabIndex = 6;
            this.VPriceSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.VPriceSearchComboBox_TextChange);
            this.VPriceSearchComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PriceRangeComboBox_Click);
            // 
            // VLocationSearchComboBox
            // 
            this.VLocationSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VLocationSearchComboBox.FormattingEnabled = true;
            this.VLocationSearchComboBox.Location = new System.Drawing.Point(316, 2);
            this.VLocationSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VLocationSearchComboBox.Name = "VLocationSearchComboBox";
            this.VLocationSearchComboBox.Size = new System.Drawing.Size(307, 24);
            this.VLocationSearchComboBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 27);
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
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Range";
            // 
            // buttonCloseVetSearch
            // 
            this.buttonCloseVetSearch.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseVetSearch.FlatAppearance.BorderSize = 0;
            this.buttonCloseVetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseVetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseVetSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseVetSearch.Location = new System.Drawing.Point(11, 11);
            this.buttonCloseVetSearch.Name = "buttonCloseVetSearch";
            this.buttonCloseVetSearch.Size = new System.Drawing.Size(36, 34);
            this.buttonCloseVetSearch.TabIndex = 22;
            this.buttonCloseVetSearch.Text = "X";
            this.buttonCloseVetSearch.UseVisualStyleBackColor = false;
            this.buttonCloseVetSearch.Click += new System.EventHandler(this.buttonCloseVetSearch_Click);
            // 
            // VetSearchDataGrid
            // 
            this.VetSearchDataGrid.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.VetSearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VetSearchDataGrid.Location = new System.Drawing.Point(67, 373);
            this.VetSearchDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VetSearchDataGrid.Name = "VetSearchDataGrid";
            this.VetSearchDataGrid.RowHeadersWidth = 62;
            this.VetSearchDataGrid.RowTemplate.Height = 28;
            this.VetSearchDataGrid.Size = new System.Drawing.Size(581, 176);
            this.VetSearchDataGrid.TabIndex = 20;
            // 
            // buttonSearchForVet
            // 
            this.buttonSearchForVet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchForVet.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonSearchForVet.FlatAppearance.BorderSize = 0;
            this.buttonSearchForVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchForVet.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchForVet.ForeColor = System.Drawing.Color.MintCream;
            this.buttonSearchForVet.Location = new System.Drawing.Point(516, 306);
            this.buttonSearchForVet.Name = "buttonSearchForVet";
            this.buttonSearchForVet.Size = new System.Drawing.Size(176, 49);
            this.buttonSearchForVet.TabIndex = 19;
            this.buttonSearchForVet.Text = "Search";
            this.buttonSearchForVet.UseVisualStyleBackColor = false;
            this.buttonSearchForVet.Click += new System.EventHandler(this.buttonSearchForVet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(52, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "Result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(52, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "Filter";
            // 
            // VetSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(743, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonCloseVetSearch);
            this.Controls.Add(this.VetSearchDataGrid);
            this.Controls.Add(this.buttonSearchForVet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(743, 640);
            this.Name = "VetSearch";
            this.Text = "VetSearch";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VetSearchDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox VRateSearchComboBox;
        private System.Windows.Forms.ComboBox VPriceSearchComboBox;
        private System.Windows.Forms.ComboBox VLocationSearchComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCloseVetSearch;
        private System.Windows.Forms.DataGridView VetSearchDataGrid;
        private System.Windows.Forms.Button buttonSearchForVet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPriceRange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRateRange;
    }
}