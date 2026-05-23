namespace POS
{
    partial class ReceiveStock
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            supplierbox = new TextBox();
            invoicebox = new TextBox();
            descbox = new TextBox();
            qtyreceived = new TextBox();
            costexcbox = new TextBox();
            costincvat = new TextBox();
            sellingexc = new TextBox();
            sellinginc = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 70);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Invoice No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 115);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 2;
            label3.Text = "Item Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 244);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 5;
            label4.Text = "Cost(Inc Vat)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 199);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Cost(Exc Vat)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 156);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 3;
            label6.Text = "Quantity Received";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 299);
            label8.Name = "label8";
            label8.Size = new Size(87, 15);
            label8.TabIndex = 7;
            label8.Text = "Selling(Exc Vat)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 346);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 6;
            label9.Text = "Selling(Inc Vat)";
            // 
            // supplierbox
            // 
            supplierbox.Location = new Point(149, 27);
            supplierbox.Name = "supplierbox";
            supplierbox.Size = new Size(100, 23);
            supplierbox.TabIndex = 9;
            // 
            // invoicebox
            // 
            invoicebox.Location = new Point(149, 70);
            invoicebox.Name = "invoicebox";
            invoicebox.Size = new Size(100, 23);
            invoicebox.TabIndex = 10;
            // 
            // descbox
            // 
            descbox.Location = new Point(149, 115);
            descbox.Name = "descbox";
            descbox.Size = new Size(100, 23);
            descbox.TabIndex = 11;
            // 
            // qtyreceived
            // 
            qtyreceived.Location = new Point(149, 156);
            qtyreceived.Name = "qtyreceived";
            qtyreceived.Size = new Size(100, 23);
            qtyreceived.TabIndex = 12;
            qtyreceived.KeyPress += qtyreceived_KeyPress;
            // 
            // costexcbox
            // 
            costexcbox.Location = new Point(149, 199);
            costexcbox.Name = "costexcbox";
            costexcbox.ReadOnly = true;
            costexcbox.Size = new Size(100, 23);
            costexcbox.TabIndex = 13;
            // 
            // costincvat
            // 
            costincvat.Location = new Point(149, 244);
            costincvat.Name = "costincvat";
            costincvat.Size = new Size(100, 23);
            costincvat.TabIndex = 14;
            costincvat.TextChanged += costincvat_TextChanged;
            costincvat.KeyPress += costincvat_KeyPress;
            // 
            // sellingexc
            // 
            sellingexc.Location = new Point(149, 291);
            sellingexc.Name = "sellingexc";
            sellingexc.ReadOnly = true;
            sellingexc.Size = new Size(100, 23);
            sellingexc.TabIndex = 16;
            // 
            // sellinginc
            // 
            sellinginc.Location = new Point(149, 338);
            sellinginc.Name = "sellinginc";
            sellinginc.Size = new Size(100, 23);
            sellinginc.TabIndex = 17;
            sellinginc.TextChanged += sellinginc_TextChanged;
            sellinginc.KeyPress += sellinginc_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(174, 391);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReceiveStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 450);
            Controls.Add(button1);
            Controls.Add(sellinginc);
            Controls.Add(sellingexc);
            Controls.Add(costincvat);
            Controls.Add(costexcbox);
            Controls.Add(qtyreceived);
            Controls.Add(descbox);
            Controls.Add(invoicebox);
            Controls.Add(supplierbox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReceiveStock";
            Text = "ReceiveStock";
            Load += ReceiveStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox supplierbox;
        private TextBox invoicebox;
        private TextBox descbox;
        private TextBox qtyreceived;
        private TextBox costexcbox;
        private TextBox costincvat;
        private TextBox sellingexc;
        private TextBox sellinginc;
        private Button button1;
    }
}