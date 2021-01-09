
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
            this.ViewRoomsDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonCloseViewRoom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewRoomsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonViewRooms
            // 
            this.ButtonViewRooms.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ButtonViewRooms.FlatAppearance.BorderSize = 0;
            this.ButtonViewRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonViewRooms.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewRooms.ForeColor = System.Drawing.Color.MintCream;
            this.ButtonViewRooms.Location = new System.Drawing.Point(382, 453);
            this.ButtonViewRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonViewRooms.Name = "ButtonViewRooms";
            this.ButtonViewRooms.Size = new System.Drawing.Size(145, 61);
            this.ButtonViewRooms.TabIndex = 17;
            this.ButtonViewRooms.Text = "View";
            this.ButtonViewRooms.UseVisualStyleBackColor = false;
            // 
            // ViewRoomsDataGrid
            // 
            this.ViewRoomsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewRoomsDataGrid.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.ViewRoomsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewRoomsDataGrid.Location = new System.Drawing.Point(59, 71);
            this.ViewRoomsDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewRoomsDataGrid.MinimumSize = new System.Drawing.Size(562, 358);
            this.ViewRoomsDataGrid.Name = "ViewRoomsDataGrid";
            this.ViewRoomsDataGrid.RowHeadersWidth = 62;
            this.ViewRoomsDataGrid.RowTemplate.Height = 28;
            this.ViewRoomsDataGrid.Size = new System.Drawing.Size(855, 358);
            this.ViewRoomsDataGrid.TabIndex = 16;
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
            // ViewRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(988, 589);
            this.Controls.Add(this.ButtonViewRooms);
            this.Controls.Add(this.ViewRoomsDataGrid);
            this.Controls.Add(this.buttonCloseViewRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewRooms";
            this.Text = "ViewRooms";
            ((System.ComponentModel.ISupportInitialize)(this.ViewRoomsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonViewRooms;
        private System.Windows.Forms.DataGridView ViewRoomsDataGrid;
        private System.Windows.Forms.Button buttonCloseViewRoom;
    }
}