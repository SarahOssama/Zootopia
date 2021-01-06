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
            this.buttonCloseView = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCloseView
            // 
            this.buttonCloseView.BackColor = System.Drawing.Color.Maroon;
            this.buttonCloseView.FlatAppearance.BorderSize = 0;
            this.buttonCloseView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCloseView.Location = new System.Drawing.Point(12, 12);
            this.buttonCloseView.Name = "buttonCloseView";
            this.buttonCloseView.Size = new System.Drawing.Size(36, 36);
            this.buttonCloseView.TabIndex = 3;
            this.buttonCloseView.Text = "X";
            this.buttonCloseView.UseVisualStyleBackColor = false;
            this.buttonCloseView.Click += new System.EventHandler(this.buttonCloseView_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 61);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(415, 286);
            this.dataGridView1.TabIndex = 10;
            // 
            // buttonview
            // 
            this.buttonview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonview.FlatAppearance.BorderSize = 0;
            this.buttonview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonview.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonview.ForeColor = System.Drawing.Color.MintCream;
            this.buttonview.Location = new System.Drawing.Point(341, 364);
            this.buttonview.Name = "buttonview";
            this.buttonview.Size = new System.Drawing.Size(129, 49);
            this.buttonview.TabIndex = 11;
            this.buttonview.Text = "View";
            this.buttonview.UseVisualStyleBackColor = false;
            // 
            // ViewUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(552, 451);
            this.Controls.Add(this.buttonview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCloseView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewUtilities";
            this.Text = "ViewUtilities";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCloseView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonview;
    }
}