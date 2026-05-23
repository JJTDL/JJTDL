namespace POS
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            btnSignUp = new Button();
            btnLogin = new Button();
            btnClose = new Button();
            pictureBox1 = new PictureBox();
            btnRecover = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 151);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ActiveCaption;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(130, 361);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(112, 59);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(12, 361);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 59);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaption;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(391, 361);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 59);
            btnClose.TabIndex = 9;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 334);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnRecover
            // 
            btnRecover.BackColor = SystemColors.ActiveCaption;
            btnRecover.FlatStyle = FlatStyle.Flat;
            btnRecover.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecover.Location = new Point(248, 361);
            btnRecover.Name = "btnRecover";
            btnRecover.Size = new Size(137, 59);
            btnRecover.TabIndex = 11;
            btnRecover.Text = "Recover Login details";
            btnRecover.UseVisualStyleBackColor = false;
            btnRecover.Click += btnRecover_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 432);
            Controls.Add(btnRecover);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "Form1";
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnSignUp;
        private Button btnLogin;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnRecover;
    }
}
