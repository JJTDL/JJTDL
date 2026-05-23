namespace POS
{
    partial class frmLogin
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
            btnShowPass = new Button();
            btnSubmit = new Button();
            txtPass = new TextBox();
            lblPass = new Label();
            lblStudNum = new Label();
            txtUserName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = SystemColors.ActiveCaption;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPass.Location = new Point(13, 364);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(260, 48);
            btnShowPass.TabIndex = 1;
            btnShowPass.Text = "Show/Hide Password";
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(359, 364);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(132, 48);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(13, 316);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(260, 27);
            txtPass.TabIndex = 3;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(12, 293);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(189, 20);
            lblPass.TabIndex = 4;
            lblPass.Text = "Please enter your password";
            // 
            // lblStudNum
            // 
            lblStudNum.AutoSize = true;
            lblStudNum.Location = new Point(13, 230);
            lblStudNum.Name = "lblStudNum";
            lblStudNum.Size = new Size(193, 20);
            lblStudNum.TabIndex = 5;
            lblStudNum.Text = "Please enter your username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 263);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(261, 27);
            txtUserName.TabIndex = 6;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 434);
            Controls.Add(txtUserName);
            Controls.Add(lblStudNum);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(btnSubmit);
            Controls.Add(btnShowPass);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            FormClosed += frmLogin_FormClosed;
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnShowPass;
        private Button btnSubmit;
        private TextBox txtPass;
        private Label lblPass;
        private Label lblStudNum;
        private TextBox txtUserName;
    }
}