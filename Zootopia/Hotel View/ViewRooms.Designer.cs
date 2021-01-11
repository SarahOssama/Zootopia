
namespace Zootopia
{
    partial class ViewRooms
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
            this.ButtonViewRooms = new System.Windows.Forms.Button();
            this.buttonCloseViewRoom = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNumTextBox = new System.Windows.Forms.TextBox();
            this.RoomPriceTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonViewRooms
            // 
            this.ButtonViewRooms.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ButtonViewRooms.FlatAppearance.BorderSize = 0;
            this.ButtonViewRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonViewRooms.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewRooms.ForeColor = System.Drawing.Color.MintCream;
            this.ButtonViewRooms.Location = new System.Drawing.Point(621, 264);
            this.ButtonViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonViewRooms.Name = "ButtonViewRooms";
            this.ButtonViewRooms.Size = new System.Drawing.Size(145, 61);
            this.ButtonViewRooms.TabIndex = 17;
            this.ButtonViewRooms.Text = "View";
            this.ButtonViewRooms.UseVisualStyleBackColor = false;
            this.ButtonViewRooms.Click += new System.EventHandler(this.ButtonViewRooms_Click);
            // 
            // buttonCloseViewRoom
            // 
            this.buttonCloseViewRoom.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseViewRoom.FlatAppearance.BorderSize = 0;
            this.buttonCloseViewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseViewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseViewRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseViewRoom.Location = new System.Drawing.Point(12, 13);
            this.buttonCloseViewRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseViewRoom.Name = "buttonCloseViewRoom";
            this.buttonCloseViewRoom.Size = new System.Drawing.Size(40, 45);
            this.buttonCloseViewRoom.TabIndex = 15;
            this.buttonCloseViewRoom.Text = "X";
            this.buttonCloseViewRoom.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RoomNumTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RoomPriceTextBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 139);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price of each Room";
            // 
            // RoomNumTextBox
            // 
            this.RoomNumTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.RoomNumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomNumTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomNumTextBox.Enabled = false;
            this.RoomNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNumTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RoomNumTextBox.Location = new System.Drawing.Point(356, 3);
            this.RoomNumTextBox.Name = "RoomNumTextBox";
            this.RoomNumTextBox.Size = new System.Drawing.Size(348, 19);
            this.RoomNumTextBox.TabIndex = 4;
            // 
            // RoomPriceTextBox
            // 
            this.RoomPriceTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.RoomPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomPriceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPriceTextBox.Enabled = false;
            this.RoomPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomPriceTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.RoomPriceTextBox.Location = new System.Drawing.Point(356, 72);
            this.RoomPriceTextBox.Name = "RoomPriceTextBox";
            this.RoomPriceTextBox.Size = new System.Drawing.Size(348, 19);
            this.RoomPriceTextBox.TabIndex = 5;
            // 
            // ViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(895, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ButtonViewRooms);
            this.Controls.Add(this.buttonCloseViewRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewRooms";
            this.Text = "ViewRooms";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonViewRooms;
        private System.Windows.Forms.Button buttonCloseViewRoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RoomNumTextBox;
        private System.Windows.Forms.TextBox RoomPriceTextBox;
    }
}