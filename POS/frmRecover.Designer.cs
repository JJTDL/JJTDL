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
            txtEmail = new TextBox();
            lblStudNum = new Label();
            lblPass = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveCaption;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(21, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 27);
            txtEmail.TabIndex = 10;
            // 
            // lblStudNum
            // 
            lblStudNum.AutoSize = true;
            lblStudNum.BackColor = SystemColors.ActiveCaptionText;
            lblStudNum.ForeColor = SystemColors.ControlLightLight;
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
            btnSubmit.Location = new Point(109, 83);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(131, 41);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "&Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmRecover
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(256, 144);
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(lblStudNum);
            Controls.Add(lblPass);
            Name = "frmRecover";
            Text = "frmRecover";
            FormClosed += frmRecover_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblStudNum;
        private Label lblPass;
        private Button btnSubmit;
    }
}