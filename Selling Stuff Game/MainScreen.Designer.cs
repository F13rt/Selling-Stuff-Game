namespace Selling_Stuff_Game
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            this.DumpsterBox = new System.Windows.Forms.GroupBox();
            this.Eat = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.InventoryData = new System.Windows.Forms.DataGridView();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.SellAll = new System.Windows.Forms.Button();
            this.SellOne = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LevelUp = new System.Windows.Forms.Button();
            this.Health = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.SearchDelay = new System.Windows.Forms.Timer(this.components);
            this.EatDelay = new System.Windows.Forms.Timer(this.components);
            this.Extras = new System.Windows.Forms.Button();
            this.DumpsterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryData)).BeginInit();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DumpsterBox
            // 
            this.DumpsterBox.Controls.Add(this.Eat);
            this.DumpsterBox.Controls.Add(this.Search);
            this.DumpsterBox.ForeColor = System.Drawing.Color.White;
            this.DumpsterBox.Location = new System.Drawing.Point(583, 52);
            this.DumpsterBox.Name = "DumpsterBox";
            this.DumpsterBox.Size = new System.Drawing.Size(119, 81);
            this.DumpsterBox.TabIndex = 0;
            this.DumpsterBox.TabStop = false;
            this.DumpsterBox.Text = "The Dumpster";
            // 
            // Eat
            // 
            this.Eat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Eat.ForeColor = System.Drawing.Color.Black;
            this.Eat.Location = new System.Drawing.Point(6, 48);
            this.Eat.Name = "Eat";
            this.Eat.Size = new System.Drawing.Size(107, 23);
            this.Eat.TabIndex = 1;
            this.Eat.Text = "Eat Food";
            this.Eat.UseVisualStyleBackColor = false;
            this.Eat.Click += new System.EventHandler(this.Eat_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Search.ForeColor = System.Drawing.Color.Black;
            this.Search.Location = new System.Drawing.Point(6, 19);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(107, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // InventoryData
            // 
            this.InventoryData.AllowUserToAddRows = false;
            this.InventoryData.AllowUserToDeleteRows = false;
            this.InventoryData.AllowUserToResizeColumns = false;
            this.InventoryData.AllowUserToResizeRows = false;
            this.InventoryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InventoryData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InventoryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.InventoryData.Location = new System.Drawing.Point(6, 14);
            this.InventoryData.Name = "InventoryData";
            this.InventoryData.Size = new System.Drawing.Size(438, 352);
            this.InventoryData.TabIndex = 1;
            this.InventoryData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.InventoryData_RowPrePaint);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.BackColor = System.Drawing.Color.Black;
            this.MainGroupBox.Controls.Add(this.SellAll);
            this.MainGroupBox.Controls.Add(this.SellOne);
            this.MainGroupBox.Controls.Add(this.InventoryData);
            this.MainGroupBox.ForeColor = System.Drawing.Color.White;
            this.MainGroupBox.Location = new System.Drawing.Point(12, 52);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(542, 372);
            this.MainGroupBox.TabIndex = 2;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Inventory:";
            // 
            // SellAll
            // 
            this.SellAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SellAll.ForeColor = System.Drawing.Color.Black;
            this.SellAll.Location = new System.Drawing.Point(450, 48);
            this.SellAll.Name = "SellAll";
            this.SellAll.Size = new System.Drawing.Size(86, 23);
            this.SellAll.TabIndex = 6;
            this.SellAll.Text = "Sell All Items";
            this.SellAll.UseVisualStyleBackColor = false;
            this.SellAll.Click += new System.EventHandler(this.SellAll_Click);
            // 
            // SellOne
            // 
            this.SellOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SellOne.ForeColor = System.Drawing.Color.Black;
            this.SellOne.Location = new System.Drawing.Point(450, 19);
            this.SellOne.Name = "SellOne";
            this.SellOne.Size = new System.Drawing.Size(86, 23);
            this.SellOne.TabIndex = 5;
            this.SellOne.Text = "Sell Item";
            this.SellOne.UseVisualStyleBackColor = false;
            this.SellOne.Click += new System.EventHandler(this.SellOne_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Save.Location = new System.Drawing.Point(560, 421);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save Game";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.Location = new System.Drawing.Point(641, 421);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LevelUp
            // 
            this.LevelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LevelUp.Location = new System.Drawing.Point(641, 392);
            this.LevelUp.Name = "LevelUp";
            this.LevelUp.Size = new System.Drawing.Size(75, 23);
            this.LevelUp.TabIndex = 6;
            this.LevelUp.Text = "Level Up";
            this.LevelUp.UseVisualStyleBackColor = false;
            this.LevelUp.Visible = false;
            this.LevelUp.Click += new System.EventHandler(this.LevelUp_Click);
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Health.ForeColor = System.Drawing.Color.White;
            this.Health.Location = new System.Drawing.Point(8, 9);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(121, 24);
            this.Health.TabIndex = 7;
            this.Health.Text = "Health: 100 /";
            // 
            // Money
            // 
            this.Money.AutoSize = true;
            this.Money.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money.ForeColor = System.Drawing.Color.White;
            this.Money.Location = new System.Drawing.Point(187, 9);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(76, 24);
            this.Money.TabIndex = 8;
            this.Money.Text = "Money: ";
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Restart.Location = new System.Drawing.Point(641, 12);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Reset";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // SearchDelay
            // 
            this.SearchDelay.Interval = 1000;
            // 
            // EatDelay
            // 
            this.EatDelay.Interval = 1000;
            // 
            // Extras
            // 
            this.Extras.BackColor = System.Drawing.Color.Yellow;
            this.Extras.Location = new System.Drawing.Point(560, 392);
            this.Extras.Name = "Extras";
            this.Extras.Size = new System.Drawing.Size(75, 23);
            this.Extras.TabIndex = 10;
            this.Extras.Text = "Extras";
            this.Extras.UseVisualStyleBackColor = false;
            this.Extras.Click += new System.EventHandler(this.Extras_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(710, 441);
            this.Controls.Add(this.Extras);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.LevelUp);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.DumpsterBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main ";
            this.DumpsterBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryData)).EndInit();
            this.MainGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DumpsterBox;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Eat;
        private System.Windows.Forms.DataGridView InventoryData;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.Button SellAll;
        private System.Windows.Forms.Button SellOne;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button LevelUp;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.Label Money;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Timer SearchDelay;
        private System.Windows.Forms.Timer EatDelay;
        private System.Windows.Forms.Button Extras;
    }
}

