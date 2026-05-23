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
            button1 = new Button();
            salexitbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)grdvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdselectedstock).BeginInit();
            SuspendLayout();
            // 
            // grdvStock
            // 
            grdvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdvStock.Location = new Point(21, 58);
            grdvStock.Name = "grdvStock";
            grdvStock.Size = new Size(740, 176);
            grdvStock.TabIndex = 0;
            grdvStock.CellContentClick += grdvStock_CellContentClick;
            grdvStock.CellContentDoubleClick += grdvStock_CellContentDoubleClick;
            grdvStock.CellDoubleClick += grdvStock_CellDoubleClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // grdselectedstock
            // 
            grdselectedstock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdselectedstock.Location = new Point(21, 344);
            grdselectedstock.Name = "grdselectedstock";
            grdselectedstock.Size = new Size(740, 198);
            grdselectedstock.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(565, 582);
            button1.Name = "button1";
            button1.Size = new Size(101, 26);
            button1.TabIndex = 3;
            button1.Text = "Sell Stock";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // salexitbtn
            // 
            salexitbtn.Location = new Point(672, 584);
            salexitbtn.Name = "salexitbtn";
            salexitbtn.Size = new Size(89, 23);
            salexitbtn.TabIndex = 4;
            salexitbtn.Text = "Exit Sale";
            salexitbtn.UseVisualStyleBackColor = true;
            salexitbtn.Click += salexitbtn_Click;
            // 
            // Salebox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 635);
            Controls.Add(salexitbtn);
            Controls.Add(button1);
            Controls.Add(grdselectedstock);
            Controls.Add(textBox1);
            Controls.Add(grdvStock);
            Name = "Salebox";
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
        private Button button1;
        private Button salexitbtn;
    }
}