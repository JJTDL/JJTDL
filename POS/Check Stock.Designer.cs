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
            extbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)grdvStock).BeginInit();
            SuspendLayout();
            // 
            // grdvStock
            // 
            grdvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdvStock.Location = new Point(32, 65);
            grdvStock.Name = "grdvStock";
            grdvStock.Size = new Size(734, 331);
            grdvStock.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(673, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // extbtn
            // 
            extbtn.Location = new Point(704, 416);
            extbtn.Name = "extbtn";
            extbtn.Size = new Size(75, 23);
            extbtn.TabIndex = 2;
            extbtn.Text = "Exit";
            extbtn.UseVisualStyleBackColor = true;
            extbtn.Click += button1_Click;
            // 
            // Check_Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(extbtn);
            Controls.Add(textBox1);
            Controls.Add(grdvStock);
            Name = "Check_Stock";
            Text = "Check_Stock";
            Load += Check_Stock_Load;
            ((System.ComponentModel.ISupportInitialize)grdvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdvStock;
        private TextBox textBox1;
        private Button extbtn;
    }
}