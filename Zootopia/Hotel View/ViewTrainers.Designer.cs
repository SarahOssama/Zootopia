
namespace Zootopia
{
    partial class ViewTrainers
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
            this.ButtonViewTrainer = new System.Windows.Forms.Button();
            this.ViewTrainersDataGrid = new System.Windows.Forms.DataGridView();
            this.buttonCloseViewTrainers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTrainersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonViewTrainer
            // 
            this.ButtonViewTrainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonViewTrainer.FlatAppearance.BorderSize = 0;
            this.ButtonViewTrainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonViewTrainer.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonViewTrainer.ForeColor = System.Drawing.Color.MintCream;
            this.ButtonViewTrainer.Location = new System.Drawing.Point(381, 450);
            this.ButtonViewTrainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonViewTrainer.Name = "ButtonViewTrainer";
            this.ButtonViewTrainer.Size = new System.Drawing.Size(145, 61);
            this.ButtonViewTrainer.TabIndex = 14;
            this.ButtonViewTrainer.Text = "View";
            this.ButtonViewTrainer.UseVisualStyleBackColor = false;
            // 
            // ViewTrainersDataGrid
            // 
            this.ViewTrainersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewTrainersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewTrainersDataGrid.Location = new System.Drawing.Point(59, 71);
            this.ViewTrainersDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewTrainersDataGrid.Name = "ViewTrainersDataGrid";
            this.ViewTrainersDataGrid.RowHeadersWidth = 62;
            this.ViewTrainersDataGrid.RowTemplate.Height = 28;
            this.ViewTrainersDataGrid.Size = new System.Drawing.Size(532, 358);
            this.ViewTrainersDataGrid.TabIndex = 13;
            // 
            // buttonCloseViewTrainers
            // 
            this.buttonCloseViewTrainers.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseViewTrainers.FlatAppearance.BorderSize = 0;
            this.buttonCloseViewTrainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseViewTrainers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseViewTrainers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseViewTrainers.Location = new System.Drawing.Point(11, 10);
            this.buttonCloseViewTrainers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCloseViewTrainers.Name = "buttonCloseViewTrainers";
            this.buttonCloseViewTrainers.Size = new System.Drawing.Size(40, 45);
            this.buttonCloseViewTrainers.TabIndex = 12;
            this.buttonCloseViewTrainers.Text = "X";
            this.buttonCloseViewTrainers.UseVisualStyleBackColor = false;
            // 
            // ViewTrainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(836, 800);
            this.Controls.Add(this.ButtonViewTrainer);
            this.Controls.Add(this.ViewTrainersDataGrid);
            this.Controls.Add(this.buttonCloseViewTrainers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(836, 800);
            this.Name = "ViewTrainers";
            this.Text = "ViewTrainers";
            ((System.ComponentModel.ISupportInitialize)(this.ViewTrainersDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonViewTrainer;
        private System.Windows.Forms.DataGridView ViewTrainersDataGrid;
        private System.Windows.Forms.Button buttonCloseViewTrainers;
    }
}