namespace POS
{
    partial class frmRecover
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
            txtUserName = new TextBox();
            lblStudNum = new Label();
            lblPass = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(21, 50);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(261, 27);
            txtUserName.TabIndex = 10;
            // 
            // lblStudNum
            // 
            lblStudNum.AutoSize = true;
            lblStudNum.Location = new Point(22, 17);
            lblStudNum.Name = "lblStudNum";
            lblStudNum.Size = new Size(218, 20);
            lblStudNum.TabIndex = 9;
            lblStudNum.Text = "Please enter your email address";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(21, 80);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(0, 20);
            lblPass.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(22, 93);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(174, 48);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmRecover
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 183);
            Controls.Add(btnSubmit);
            Controls.Add(txtUserName);
            Controls.Add(lblStudNum);
            Controls.Add(lblPass);
            Name = "frmRecover";
            Text = "frmRecover";
            FormClosed += frmRecover_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUserName;
        private Label lblStudNum;
        private Label lblPass;
        private Button btnSubmit;
    }
}