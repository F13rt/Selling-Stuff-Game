namespace Selling_Stuff_Game
{
    partial class Extras
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
            this.ExportData1 = new System.Windows.Forms.Button();
            this.ExportData2 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExportData1
            // 
            this.ExportData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExportData1.ForeColor = System.Drawing.Color.Black;
            this.ExportData1.Location = new System.Drawing.Point(58, 83);
            this.ExportData1.Name = "ExportData1";
            this.ExportData1.Size = new System.Drawing.Size(96, 23);
            this.ExportData1.TabIndex = 11;
            this.ExportData1.Text = "Export Stats";
            this.ExportData1.UseVisualStyleBackColor = false;
            this.ExportData1.Click += new System.EventHandler(this.ExportData1_Click);
            // 
            // ExportData2
            // 
            this.ExportData2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ExportData2.ForeColor = System.Drawing.Color.Black;
            this.ExportData2.Location = new System.Drawing.Point(58, 112);
            this.ExportData2.Name = "ExportData2";
            this.ExportData2.Size = new System.Drawing.Size(96, 23);
            this.ExportData2.TabIndex = 12;
            this.ExportData2.Text = "Export Inventory";
            this.ExportData2.UseVisualStyleBackColor = false;
            this.ExportData2.Click += new System.EventHandler(this.ExportData2_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Lime;
            this.Back.ForeColor = System.Drawing.Color.Black;
            this.Back.Location = new System.Drawing.Point(156, 204);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(52, 23);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(207, 226);
            this.ControlBox = false;
            this.Controls.Add(this.Back);
            this.Controls.Add(this.ExportData2);
            this.Controls.Add(this.ExportData1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Extras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExportData1;
        private System.Windows.Forms.Button ExportData2;
        private System.Windows.Forms.Button Back;
    }
}