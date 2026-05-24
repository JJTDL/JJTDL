namespace POS
{
    partial class Check_Stock
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
            grdvStock = new DataGridView();
            textBox1 = new TextBox();
            btnExit = new Button();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)grdvStock).BeginInit();
            SuspendLayout();
            // 
            // grdvStock
            // 
            grdvStock.BackgroundColor = SystemColors.ActiveCaption;
            grdvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdvStock.Location = new Point(42, 100);
            grdvStock.Margin = new Padding(3, 5, 3, 5);
            grdvStock.Name = "grdvStock";
            grdvStock.RowHeadersWidth = 51;
            grdvStock.Size = new Size(627, 223);
            grdvStock.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(42, 40);
            textBox1.Margin = new Padding(3, 5, 3, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(627, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(572, 349);
            btnExit.Margin = new Padding(3, 5, 3, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 36);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = SystemColors.ActiveCaptionText;
            lblSearch.ForeColor = SystemColors.ControlLightLight;
            lblSearch.Location = new Point(42, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(131, 23);
            lblSearch.TabIndex = 6;
            lblSearch.Text = "Search for Item:";
            // 
            // Check_Stock
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(691, 397);
            Controls.Add(lblSearch);
            Controls.Add(btnExit);
            Controls.Add(textBox1);
            Controls.Add(grdvStock);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(3, 5, 3, 5);
            Name = "Check_Stock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check_Stock";
            Load += Check_Stock_Load;
            ((System.ComponentModel.ISupportInitialize)grdvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdvStock;
        private TextBox textBox1;
        private Button btnExit;
        private Label lblSearch;
    }
}