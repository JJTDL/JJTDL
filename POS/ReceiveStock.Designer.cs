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
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 1;
            label2.Text = "Invoice No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 2;
            label3.Text = "Item Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 195);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 5;
            label4.Text = "Cost(Inc Vat)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 160);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 4;
            label5.Text = "Cost(Exc Vat)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(12, 125);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 3;
            label6.Text = "Quantity Received";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(12, 230);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 7;
            label8.Text = "Selling(Exc Vat)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(15, 265);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 6;
            label9.Text = "Selling(Inc Vat)";
            // 
            // supplierbox
            // 
            supplierbox.BackColor = SystemColors.ActiveCaption;
            supplierbox.BorderStyle = BorderStyle.FixedSingle;
            supplierbox.Location = new Point(153, 13);
            supplierbox.Margin = new Padding(3, 4, 3, 4);
            supplierbox.Name = "supplierbox";
            supplierbox.Size = new Size(220, 27);
            supplierbox.TabIndex = 9;
            // 
            // invoicebox
            // 
            invoicebox.BackColor = SystemColors.ActiveCaption;
            invoicebox.BorderStyle = BorderStyle.FixedSingle;
            invoicebox.Location = new Point(153, 48);
            invoicebox.Margin = new Padding(3, 4, 3, 4);
            invoicebox.Name = "invoicebox";
            invoicebox.Size = new Size(220, 27);
            invoicebox.TabIndex = 10;
            invoicebox.TextChanged += invoicebox_TextChanged;
            // 
            // descbox
            // 
            descbox.BackColor = SystemColors.ActiveCaption;
            descbox.BorderStyle = BorderStyle.FixedSingle;
            descbox.Location = new Point(153, 83);
            descbox.Margin = new Padding(3, 4, 3, 4);
            descbox.Name = "descbox";
            descbox.Size = new Size(220, 27);
            descbox.TabIndex = 11;
            // 
            // qtyreceived
            // 
            qtyreceived.BackColor = SystemColors.ActiveCaption;
            qtyreceived.BorderStyle = BorderStyle.FixedSingle;
            qtyreceived.Location = new Point(153, 118);
            qtyreceived.Margin = new Padding(3, 4, 3, 4);
            qtyreceived.Name = "qtyreceived";
            qtyreceived.Size = new Size(220, 27);
            qtyreceived.TabIndex = 12;
            qtyreceived.KeyPress += qtyreceived_KeyPress;
            // 
            // costexcbox
            // 
            costexcbox.BackColor = SystemColors.ActiveCaption;
            costexcbox.BorderStyle = BorderStyle.FixedSingle;
            costexcbox.Location = new Point(153, 153);
            costexcbox.Margin = new Padding(3, 4, 3, 4);
            costexcbox.Name = "costexcbox";
            costexcbox.ReadOnly = true;
            costexcbox.Size = new Size(220, 27);
            costexcbox.TabIndex = 13;
            // 
            // costincvat
            // 
            costincvat.BackColor = SystemColors.ActiveCaption;
            costincvat.BorderStyle = BorderStyle.FixedSingle;
            costincvat.Location = new Point(153, 188);
            costincvat.Margin = new Padding(3, 4, 3, 4);
            costincvat.Name = "costincvat";
            costincvat.Size = new Size(220, 27);
            costincvat.TabIndex = 14;
            costincvat.TextChanged += costincvat_TextChanged;
            costincvat.KeyPress += costincvat_KeyPress;
            // 
            // sellingexc
            // 
            sellingexc.BackColor = SystemColors.ActiveCaption;
            sellingexc.BorderStyle = BorderStyle.FixedSingle;
            sellingexc.Location = new Point(153, 223);
            sellingexc.Margin = new Padding(3, 4, 3, 4);
            sellingexc.Name = "sellingexc";
            sellingexc.ReadOnly = true;
            sellingexc.Size = new Size(220, 27);
            sellingexc.TabIndex = 16;
            // 
            // sellinginc
            // 
            sellinginc.BackColor = SystemColors.ActiveCaption;
            sellinginc.BorderStyle = BorderStyle.FixedSingle;
            sellinginc.Location = new Point(153, 258);
            sellinginc.Margin = new Padding(3, 4, 3, 4);
            sellinginc.Name = "sellinginc";
            sellinginc.Size = new Size(220, 27);
            sellinginc.TabIndex = 17;
            sellinginc.TextChanged += sellinginc_TextChanged;
            sellinginc.KeyPress += sellinginc_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(287, 293);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add Item";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(153, 294);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ReceiveStock
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(385, 338);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReceiveStock";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnAdd;
        private Button btnCancel;
    }
}