namespace POS
{
    partial class frmDashboard
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
            btnSellAnItem = new Button();
            btnCheckStock = new Button();
            btnAddStock = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSellAnItem
            // 
            btnSellAnItem.BackColor = SystemColors.ActiveCaption;
            btnSellAnItem.FlatStyle = FlatStyle.Flat;
            btnSellAnItem.Location = new Point(25, 33);
            btnSellAnItem.Margin = new Padding(3, 4, 3, 4);
            btnSellAnItem.Name = "btnSellAnItem";
            btnSellAnItem.Size = new Size(153, 44);
            btnSellAnItem.TabIndex = 0;
            btnSellAnItem.Text = "Sell An Item";
            btnSellAnItem.UseVisualStyleBackColor = false;
            btnSellAnItem.Click += btnSellAnItem_Click;
            // 
            // btnCheckStock
            // 
            btnCheckStock.FlatStyle = FlatStyle.Flat;
            btnCheckStock.Location = new Point(25, 137);
            btnCheckStock.Margin = new Padding(3, 4, 3, 4);
            btnCheckStock.Name = "btnCheckStock";
            btnCheckStock.Size = new Size(153, 48);
            btnCheckStock.TabIndex = 1;
            btnCheckStock.Text = "Check Stock";
            btnCheckStock.UseVisualStyleBackColor = true;
            btnCheckStock.Click += btnCheckStock_Click;
            // 
            // btnAddStock
            // 
            btnAddStock.FlatStyle = FlatStyle.Flat;
            btnAddStock.Location = new Point(25, 85);
            btnAddStock.Margin = new Padding(3, 4, 3, 4);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(153, 44);
            btnAddStock.TabIndex = 5;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(194, 154);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 6;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(295, 201);
            Controls.Add(btnExit);
            Controls.Add(btnAddStock);
            Controls.Add(btnCheckStock);
            Controls.Add(btnSellAnItem);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSellAnItem;
        private Button btnCheckStock;
        private Button btnDailyTransaction;
        private Button btnMonthlyTransaction;
        private Button btnAddStock;
        private Button btnExit;
    }
}