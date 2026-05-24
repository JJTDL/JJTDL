namespace POS
{
    partial class Salebox
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
            grdselectedstock = new DataGridView();
            btnSell = new Button();
            salexitbtn = new Button();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)grdvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdselectedstock).BeginInit();
            SuspendLayout();
            // 
            // grdvStock
            // 
            grdvStock.BackgroundColor = SystemColors.ActiveCaption;
            grdvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdvStock.Location = new Point(24, 77);
            grdvStock.Margin = new Padding(3, 4, 3, 4);
            grdvStock.Name = "grdvStock";
            grdvStock.RowHeadersWidth = 51;
            grdvStock.Size = new Size(579, 235);
            grdvStock.TabIndex = 0;
            grdvStock.CellDoubleClick += grdvStock_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(24, 39);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(460, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // grdselectedstock
            // 
            grdselectedstock.BackgroundColor = SystemColors.ActiveCaption;
            grdselectedstock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdselectedstock.Location = new Point(24, 320);
            grdselectedstock.Margin = new Padding(3, 4, 3, 4);
            grdselectedstock.Name = "grdselectedstock";
            grdselectedstock.RowHeadersWidth = 51;
            grdselectedstock.Size = new Size(579, 264);
            grdselectedstock.TabIndex = 2;
            // 
            // btnSell
            // 
            btnSell.BackColor = SystemColors.ActiveCaption;
            btnSell.FlatStyle = FlatStyle.Flat;
            btnSell.Location = new Point(380, 594);
            btnSell.Margin = new Padding(3, 4, 3, 4);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(115, 35);
            btnSell.TabIndex = 3;
            btnSell.Text = "Sell Stock";
            btnSell.UseVisualStyleBackColor = false;
            btnSell.Click += btnSell_Click;
            // 
            // salexitbtn
            // 
            salexitbtn.BackColor = SystemColors.ActiveCaption;
            salexitbtn.FlatStyle = FlatStyle.Flat;
            salexitbtn.Location = new Point(501, 596);
            salexitbtn.Margin = new Padding(3, 4, 3, 4);
            salexitbtn.Name = "salexitbtn";
            salexitbtn.Size = new Size(102, 31);
            salexitbtn.TabIndex = 4;
            salexitbtn.Text = "Exit Sale";
            salexitbtn.UseVisualStyleBackColor = false;
            salexitbtn.Click += salexitbtn_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = SystemColors.ActiveCaptionText;
            lblSearch.ForeColor = SystemColors.ControlLightLight;
            lblSearch.Location = new Point(22, 7);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(113, 20);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search for Item:";
            // 
            // Salebox
            // 
            AcceptButton = btnSell;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(620, 639);
            Controls.Add(lblSearch);
            Controls.Add(salexitbtn);
            Controls.Add(btnSell);
            Controls.Add(grdselectedstock);
            Controls.Add(textBox1);
            Controls.Add(grdvStock);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Salebox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salebox";
            Load += Salebox_Load;
            ((System.ComponentModel.ISupportInitialize)grdvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdselectedstock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdvStock;
        private TextBox textBox1;
        private DataGridView grdselectedstock;
        private Button btnSell;
        private Button salexitbtn;
        private Label lblSearch;
    }
}