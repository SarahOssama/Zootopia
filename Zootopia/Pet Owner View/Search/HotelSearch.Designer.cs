
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
            this.buttonCloseUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearchForHotel = new System.Windows.Forms.Button();
            this.HotelSearchDataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HRateSearchComboBox = new System.Windows.Forms.ComboBox();
            this.HPriceSearchComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HLocationSearchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.HotelSearchDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCloseUpdate
            // 
            this.buttonCloseUpdate.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseUpdate.FlatAppearance.BorderSize = 0;
            this.buttonCloseUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseUpdate.Location = new System.Drawing.Point(12, 13);
            this.buttonCloseUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseUpdate.Name = "buttonCloseUpdate";
            this.buttonCloseUpdate.Size = new System.Drawing.Size(40, 42);
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
            this.label5.Location = new System.Drawing.Point(58, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(58, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result";
            // 
            // buttonSearchForHotel
            // 
            this.buttonSearchForHotel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearchForHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonSearchForHotel.FlatAppearance.BorderSize = 0;
            this.buttonSearchForHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchForHotel.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchForHotel.ForeColor = System.Drawing.Color.MintCream;
            this.buttonSearchForHotel.Location = new System.Drawing.Point(581, 383);
            this.buttonSearchForHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearchForHotel.Name = "buttonSearchForHotel";
            this.buttonSearchForHotel.Size = new System.Drawing.Size(198, 61);
            this.buttonSearchForHotel.TabIndex = 8;
            this.buttonSearchForHotel.Text = "Search";
            this.buttonSearchForHotel.UseVisualStyleBackColor = false;
            this.buttonSearchForHotel.Click += new System.EventHandler(this.buttonSearchForHotel_Click);
            // 
            // HotelSearchDataGrid
            // 
            this.HotelSearchDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HotelSearchDataGrid.Location = new System.Drawing.Point(75, 466);
            this.HotelSearchDataGrid.Name = "HotelSearchDataGrid";
            this.HotelSearchDataGrid.RowHeadersWidth = 62;
            this.HotelSearchDataGrid.RowTemplate.Height = 28;
            this.HotelSearchDataGrid.Size = new System.Drawing.Size(654, 220);
            this.HotelSearchDataGrid.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HRateSearchComboBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.HPriceSearchComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.HLocationSearchComboBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 127);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 231);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // HRateSearchComboBox
            // 
            this.HRateSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HRateSearchComboBox.FormattingEnabled = true;
            this.HRateSearchComboBox.Location = new System.Drawing.Point(355, 157);
            this.HRateSearchComboBox.Name = "HRateSearchComboBox";
            this.HRateSearchComboBox.Size = new System.Drawing.Size(346, 28);
            this.HRateSearchComboBox.TabIndex = 6;
            // 
            // HPriceSearchComboBox
            // 
            this.HPriceSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HPriceSearchComboBox.FormattingEnabled = true;
            this.HPriceSearchComboBox.Location = new System.Drawing.Point(355, 80);
            this.HPriceSearchComboBox.Name = "HPriceSearchComboBox";
            this.HPriceSearchComboBox.Size = new System.Drawing.Size(346, 28);
            this.HPriceSearchComboBox.TabIndex = 5;
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
            // HLocationSearchComboBox
            // 
            this.HLocationSearchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HLocationSearchComboBox.FormattingEnabled = true;
            this.HLocationSearchComboBox.Location = new System.Drawing.Point(355, 3);
            this.HLocationSearchComboBox.Name = "HLocationSearchComboBox";
            this.HLocationSearchComboBox.Size = new System.Drawing.Size(346, 28);
            this.HLocationSearchComboBox.TabIndex = 4;
            // 
            // HotelSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(836, 800);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HotelSearchDataGrid);
            this.Controls.Add(this.buttonSearchForHotel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCloseUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(836, 800);
            this.Name = "HotelSearch";
            this.Text = "HotelSearch";
            this.Load += new System.EventHandler(this.HotelSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HotelSearchDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
    }
}