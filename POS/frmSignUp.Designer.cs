namespace POS
{
    partial class frmSignUp
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
            btnShowPass = new Button();
            txtUserName = new TextBox();
            lblStudNum = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblSurname = new Label();
            txtSurname = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPass = new Label();
            txtPass = new TextBox();
            label1 = new Label();
            txtCPass = new TextBox();
            btnSubmit = new Button();
            ilblPssInfo = new LinkLabel();
            SuspendLayout();
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = SystemColors.ActiveCaption;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPass.Location = new Point(305, 335);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(215, 45);
            btnShowPass.TabIndex = 2;
            btnShowPass.Text = "Show/Hide Password";
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(12, 42);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(261, 27);
            txtUserName.TabIndex = 10;
            // 
            // lblStudNum
            // 
            lblStudNum.AutoSize = true;
            lblStudNum.Location = new Point(13, 9);
            lblStudNum.Name = "lblStudNum";
            lblStudNum.Size = new Size(193, 20);
            lblStudNum.TabIndex = 9;
            lblStudNum.Text = "Please enter your username:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(13, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(166, 20);
            lblName.TabIndex = 14;
            lblName.Text = "Please enter your name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(13, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 27);
            txtName.TabIndex = 13;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new Point(13, 144);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(182, 20);
            lblSurname.TabIndex = 16;
            lblSurname.Text = "Please enter your surname";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(13, 177);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(260, 27);
            txtSurname.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(13, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(163, 20);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Please enter your email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(13, 256);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 17;
            txtEmail.TextChanged += txtPass_TextChanged;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(13, 302);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(189, 20);
            lblPass.TabIndex = 20;
            lblPass.Text = "Please enter your password";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(13, 335);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(260, 27);
            txtPass.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 377);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 22;
            label1.Text = "Please confirm your password:";
            label1.Click += label1_Click;
            // 
            // txtCPass
            // 
            txtCPass.Location = new Point(17, 410);
            txtCPass.Name = "txtCPass";
            txtCPass.Size = new Size(260, 27);
            txtCPass.TabIndex = 21;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(305, 164);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(200, 48);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ilblPssInfo
            // 
            ilblPssInfo.AutoSize = true;
            ilblPssInfo.Location = new Point(309, 407);
            ilblPssInfo.Name = "ilblPssInfo";
            ilblPssInfo.Size = new Size(152, 20);
            ilblPssInfo.TabIndex = 24;
            ilblPssInfo.TabStop = true;
            ilblPssInfo.Text = "Password Information";
            ilblPssInfo.LinkClicked += ilblPssInfo_LinkClicked;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(ilblPssInfo);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtCPass);
            Controls.Add(lblPass);
            Controls.Add(txtPass);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblSurname);
            Controls.Add(txtSurname);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(txtUserName);
            Controls.Add(lblStudNum);
            Controls.Add(btnShowPass);
            Name = "frmSignUp";
            Text = "frmSignUp";
            FormClosed += frmSignUp_FormClosed;
            Load += frmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowPass;
        private TextBox txtUserName;
        private Label lblStudNum;
        private Label lblName;
        private TextBox txtName;
        private Label lblSurname;
        private TextBox txtSurname;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPass;
        private TextBox txtPass;
        private Label label1;
        private TextBox txtCPass;
        private Button btnSubmit;
        private LinkLabel ilblPssInfo;
    }
}