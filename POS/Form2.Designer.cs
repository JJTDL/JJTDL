namespace POS
{
    partial class FrontPanel
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
            btnDailyTransaction = new Button();
            btnMonthlyTransaction = new Button();
            btnAddStock = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // btnSellAnItem
            // 
            btnSellAnItem.Location = new Point(22, 25);
            btnSellAnItem.Name = "btnSellAnItem";
            btnSellAnItem.Size = new Size(75, 50);
            btnSellAnItem.TabIndex = 0;
            btnSellAnItem.Text = "Sell An Item";
            btnSellAnItem.UseVisualStyleBackColor = true;
            btnSellAnItem.Click += btnSellAnItem_Click;
            // 
            // btnCheckStock
            // 
            btnCheckStock.Location = new Point(117, 25);
            btnCheckStock.Name = "btnCheckStock";
            btnCheckStock.Size = new Size(75, 50);
            btnCheckStock.TabIndex = 1;
            btnCheckStock.Text = "Check Stock";
            btnCheckStock.UseVisualStyleBackColor = true;
            // 
            // btnDailyTransaction
            // 
            btnDailyTransaction.Location = new Point(210, 25);
            btnDailyTransaction.Name = "btnDailyTransaction";
            btnDailyTransaction.Size = new Size(79, 50);
            btnDailyTransaction.TabIndex = 3;
            btnDailyTransaction.Text = "Daily Transactions";
            btnDailyTransaction.UseVisualStyleBackColor = true;
            // 
            // btnMonthlyTransaction
            // 
            btnMonthlyTransaction.Location = new Point(304, 25);
            btnMonthlyTransaction.Name = "btnMonthlyTransaction";
            btnMonthlyTransaction.Size = new Size(77, 50);
            btnMonthlyTransaction.TabIndex = 4;
            btnMonthlyTransaction.Text = "Monthly Transactions";
            btnMonthlyTransaction.UseVisualStyleBackColor = true;
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(22, 90);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(65, 46);
            btnAddStock.TabIndex = 5;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(378, 214);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = true;
            // 
            // FrontPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 261);
            Controls.Add(button3);
            Controls.Add(btnAddStock);
            Controls.Add(btnMonthlyTransaction);
            Controls.Add(btnDailyTransaction);
            Controls.Add(btnCheckStock);
            Controls.Add(btnSellAnItem);
            Name = "FrontPanel";
            Text = "Form2";
            Load += FrontPanel_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSellAnItem;
        private Button btnCheckStock;
        private Button btnDailyTransaction;
        private Button btnMonthlyTransaction;
        private Button btnAddStock;
        private Button button3;
    }
}