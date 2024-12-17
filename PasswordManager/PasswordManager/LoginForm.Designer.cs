namespace PasswordManager
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usrnameBox = new TextBox();
            passwordBox = new TextBox();
            loginBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // usrnameBox
            // 
            usrnameBox.BackColor = Color.WhiteSmoke;
            usrnameBox.Location = new Point(102, 146);
            usrnameBox.Name = "usrnameBox";
            usrnameBox.Size = new Size(267, 23);
            usrnameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.WhiteSmoke;
            passwordBox.Location = new Point(102, 222);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(267, 23);
            passwordBox.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.MidnightBlue;
            loginBtn.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            loginBtn.ForeColor = Color.WhiteSmoke;
            loginBtn.Location = new Point(156, 298);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(136, 36);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(102, 118);
            label1.Name = "label1";
            label1.Size = new Size(90, 16);
            label1.TabIndex = 3;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(102, 194);
            label2.Name = "label2";
            label2.Size = new Size(86, 16);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(500, 449);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginBtn);
            Controls.Add(passwordBox);
            Controls.Add(usrnameBox);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usrnameBox;
        private TextBox passwordBox;
        private Button loginBtn;
        private Label label1;
        private Label label2;
    }
}
