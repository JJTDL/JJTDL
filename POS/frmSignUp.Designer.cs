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
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = SystemColors.ActiveCaption;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPass.Location = new Point(305, 335);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(137, 62);
            btnShowPass.TabIndex = 2;
            btnShowPass.Text = "Show/Hide Password";
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.ActiveCaption;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(13, 41);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(261, 27);
            txtUserName.TabIndex = 10;
            // 
            // lblStudNum
            // 
            lblStudNum.AutoSize = true;
            lblStudNum.BackColor = SystemColors.ActiveCaptionText;
            lblStudNum.ForeColor = SystemColors.ControlLightLight;
            lblStudNum.Location = new Point(13, 9);
            lblStudNum.Name = "lblStudNum";
            lblStudNum.Size = new Size(193, 20);
            lblStudNum.TabIndex = 9;
            lblStudNum.Text = "Please enter your username:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = SystemColors.ActiveCaptionText;
            lblName.ForeColor = SystemColors.ControlLightLight;
            lblName.Location = new Point(13, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(166, 20);
            lblName.TabIndex = 14;
            lblName.Text = "Please enter your name:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ActiveCaption;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(13, 113);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 27);
            txtName.TabIndex = 13;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.BackColor = SystemColors.ActiveCaptionText;
            lblSurname.ForeColor = SystemColors.ControlLightLight;
            lblSurname.Location = new Point(13, 144);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(182, 20);
            lblSurname.TabIndex = 16;
            lblSurname.Text = "Please enter your surname";
            // 
            // txtSurname
            // 
            txtSurname.BackColor = SystemColors.ActiveCaption;
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Location = new Point(13, 177);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(260, 27);
            txtSurname.TabIndex = 15;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = SystemColors.ActiveCaptionText;
            lblEmail.ForeColor = SystemColors.ControlLightLight;
            lblEmail.Location = new Point(13, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(163, 20);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Please enter your email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveCaption;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(13, 256);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(260, 27);
            txtEmail.TabIndex = 17;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = SystemColors.ActiveCaptionText;
            lblPass.ForeColor = SystemColors.ControlLightLight;
            lblPass.Location = new Point(13, 302);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(189, 20);
            lblPass.TabIndex = 20;
            lblPass.Text = "Please enter your password";
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.ActiveCaption;
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(13, 335);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(260, 27);
            txtPass.TabIndex = 19;
            txtPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(17, 377);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 22;
            label1.Text = "Please confirm your password:";
            // 
            // txtCPass
            // 
            txtCPass.BackColor = SystemColors.ActiveCaption;
            txtCPass.BorderStyle = BorderStyle.FixedSingle;
            txtCPass.Location = new Point(17, 410);
            txtCPass.Name = "txtCPass";
            txtCPass.Size = new Size(260, 27);
            txtCPass.TabIndex = 21;
            txtCPass.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(486, 393);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(92, 48);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ilblPssInfo
            // 
            ilblPssInfo.AutoSize = true;
            ilblPssInfo.BackColor = SystemColors.ActiveCaption;
            ilblPssInfo.ForeColor = SystemColors.ControlLightLight;
            ilblPssInfo.Location = new Point(305, 421);
            ilblPssInfo.Name = "ilblPssInfo";
            ilblPssInfo.Size = new Size(152, 20);
            ilblPssInfo.TabIndex = 24;
            ilblPssInfo.TabStop = true;
            ilblPssInfo.Text = "Password Information";
            ilblPssInfo.LinkClicked += ilblPssInfo_LinkClicked;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(486, 335);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 41);
            btnBack.TabIndex = 25;
            btnBack.Text = "&Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(590, 450);
            Controls.Add(btnBack);
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
        private Button btnBack;
    }
}