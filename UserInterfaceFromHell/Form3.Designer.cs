namespace UserInterfaceFromHell
{
    partial class Form3
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.pass1 = new System.Windows.Forms.Label();
            this.user1 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(328, 246);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(126, 44);
            this.logoutButton.TabIndex = 17;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pass1
            // 
            this.pass1.AutoSize = true;
            this.pass1.Location = new System.Drawing.Point(272, 203);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(78, 20);
            this.pass1.TabIndex = 16;
            this.pass1.Text = "Password";
            this.pass1.Click += new System.EventHandler(this.pass1_Click);
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.Location = new System.Drawing.Point(272, 155);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(83, 20);
            this.user1.TabIndex = 15;
            this.user1.Text = "Username";
            this.user1.Click += new System.EventHandler(this.user1_Click);
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(361, 197);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(133, 26);
            this.passBox.TabIndex = 14;
            this.passBox.TextChanged += new System.EventHandler(this.passBox_TextChanged);
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(361, 149);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(133, 26);
            this.userBox.TabIndex = 13;
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Enter Your Info to Logout";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.user1);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.userBox);
            this.Name = "Form3";
            this.Text = "Log Out";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label pass1;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label label1;
    }
}