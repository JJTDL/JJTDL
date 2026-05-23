namespace POS
{
    partial class Bankingpanel
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(67, 38);
            button1.Name = "button1";
            button1.Size = new Size(75, 57);
            button1.TabIndex = 0;
            button1.Text = "Check Applicants";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(158, 38);
            button2.Name = "button2";
            button2.Size = new Size(75, 61);
            button2.TabIndex = 1;
            button2.Text = "View Users";
            button2.UseVisualStyleBackColor = true;
            // 
            // Bankingpanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bankingpanel";
            Text = "Bankingpanel";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}