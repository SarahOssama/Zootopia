
namespace Zootopia
{
    partial class HotelSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCloseUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchForHotel = new System.Windows.Forms.Button();
            this.HotelSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HLocationSearchComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPriceRange = new System.Windows.Forms.Label();
            this.HPriceSearchComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRateRange = new System.Windows.Forms.Label();
            this.HRateSearchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HotelSearchDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseUpdate
            // 
            this.buttonCloseUpdate.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseUpdate.FlatAppearance.BorderSize = 0;
            this.buttonCloseUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseUpdate.Location = new System.Drawing.Point(11, 10);
            this.buttonCloseUpdate.Name = "buttonCloseUpdate";
            this.buttonCloseUpdate.Size = new System.Drawing.Size(36, 34);
            this.buttonCloseUpdate.TabIndex = 2;
            this.buttonCloseUpdate.Text = "X";
            this.buttonCloseUpdate.UseVisualStyleBackColor = false;
            this.buttonCloseUpdate.Click += new System.EventHandler(this.buttonCloseUpdate_Click);
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
            this.label5.TabIndex = 6;
            this.label5.Text = "Filter";
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
            this.label1.TabIndex = 7;
            this.label1.Text = "Result";
            // 
            // buttonSearchForHotel
            // 
            this.buttonSearchForHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchForHotel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.buttonSearchForHotel.FlatAppearance.BorderSize = 0;
            this.buttonSearchForHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchForHotel.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchForHotel.ForeColor = System.Drawing.Color.MintCream;
            this.buttonSearchForHotel.Location = new System.Drawing.Point(516, 306);
            this.buttonSearchForHotel.Name = "buttonSearchForHotel";
            this.buttonSearchForHotel.Size = new System.Drawing.Size(176, 49);
            this.buttonSearchForHotel.TabIndex = 8;
            this.buttonSearchForHotel.Text = "Search";
            this.buttonSearchForHotel.UseVisualStyleBackColor = false;
            this.buttonSearchForHotel.Click += new System.EventHandler(this.buttonSearchForHotel_Click);
            // 
            // HotelSearchDataGrid
            // 
            this.HotelSearchDataGrid.AllowUserToAddRows = false;
            this.HotelSearchDataGrid.AllowUserToDeleteRows = false;
            this.HotelSearchDataGrid.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.HotelSearchDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HotelSearchDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.HotelSearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelSearchDataGrid.Location = new System.Drawing.Point(67, 373);
            this.HotelSearchDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HotelSearchDataGrid.Name = "HotelSearchDataGrid";
            this.HotelSearchDataGrid.ReadOnly = true;
            this.HotelSearchDataGrid.RowHeadersWidth = 62;
            this.HotelSearchDataGrid.RowTemplate.Height = 28;
            this.HotelSearchDataGrid.Size = new System.Drawing.Size(581, 176);
            this.HotelSearchDataGrid.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HLocationSearchComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(67, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 185);
            this.tableLayoutPanel1.TabIndex = 10;
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
            // HLocationSearchComboBox
            // 
            this.HLocationSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HLocationSearchComboBox.FormattingEnabled = true;
            this.HLocationSearchComboBox.Location = new System.Drawing.Point(316, 2);
            this.HLocationSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HLocationSearchComboBox.Name = "HLocationSearchComboBox";
            this.HLocationSearchComboBox.Size = new System.Drawing.Size(307, 24);
            this.HLocationSearchComboBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPriceRange);
            this.panel1.Controls.Add(this.HPriceSearchComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(316, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 57);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.labelPriceRange.TabIndex = 50;
            this.labelPriceRange.Text = "Please choose a price range";
            // 
            // HPriceSearchComboBox
            // 
            this.HPriceSearchComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HPriceSearchComboBox.FormattingEnabled = true;
            this.HPriceSearchComboBox.Items.AddRange(new object[] {
            "500-1000",
            "1000-1500",
            "1500-2000",
            "2000-2500"});
            this.HPriceSearchComboBox.Location = new System.Drawing.Point(0, 0);
            this.HPriceSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HPriceSearchComboBox.Name = "HPriceSearchComboBox";
            this.HPriceSearchComboBox.Size = new System.Drawing.Size(307, 24);
            this.HPriceSearchComboBox.TabIndex = 5;
            this.HPriceSearchComboBox.TextChanged += new System.EventHandler(this.HPriceSearchComboBox_TextChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelRateRange);
            this.panel2.Controls.Add(this.HRateSearchComboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(316, 124);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 59);
            this.panel2.TabIndex = 8;
            // 
            // labelRateRange
            // 
            this.labelRateRange.AutoSize = true;
            this.labelRateRange.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRateRange.Font = new System.Drawing.Font("Palatino Linotype", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRateRange.ForeColor = System.Drawing.Color.Red;
            this.labelRateRange.Location = new System.Drawing.Point(0, 24);
            this.labelRateRange.Name = "labelRateRange";
            this.labelRateRange.Size = new System.Drawing.Size(160, 17);
            this.labelRateRange.TabIndex = 51;
            this.labelRateRange.Text = "Please choose a rate range";
            // 
            // HRateSearchComboBox
            // 
            this.HRateSearchComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HRateSearchComboBox.FormattingEnabled = true;
            this.HRateSearchComboBox.Items.AddRange(new object[] {
            "1-2",
            "2-3",
            "3-4",
            "4-5"});
            this.HRateSearchComboBox.Location = new System.Drawing.Point(0, 0);
            this.HRateSearchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HRateSearchComboBox.Name = "HRateSearchComboBox";
            this.HRateSearchComboBox.Size = new System.Drawing.Size(307, 24);
            this.HRateSearchComboBox.TabIndex = 6;
            this.HRateSearchComboBox.TextChanged += new System.EventHandler(this.HRateSearchComboBox_TextChanged);
            this.HRateSearchComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RateRangeComboBox_Click);
            // 
            // HotelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(743, 640);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HotelSearchDataGrid);
            this.Controls.Add(this.buttonSearchForHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCloseUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(743, 640);
            this.Name = "HotelSearch";
            this.Text = "HotelSearch";
            ((System.ComponentModel.ISupportInitialize)(this.HotelSearchDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearchForHotel;
        private System.Windows.Forms.DataGridView HotelSearchDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox HLocationSearchComboBox;
        private System.Windows.Forms.ComboBox HRateSearchComboBox;
        private System.Windows.Forms.ComboBox HPriceSearchComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPriceRange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRateRange;
    }
}