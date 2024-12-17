namespace PasswordManager
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            srcBox = new TextBox();
            usrBox = new TextBox();
            passBox = new TextBox();
            btnSave = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // srcBox
            // 
            srcBox.BackColor = Color.WhiteSmoke;
            srcBox.Location = new Point(96, 79);
            srcBox.Name = "srcBox";
            srcBox.Size = new Size(308, 23);
            srcBox.TabIndex = 0;
            // 
            // usrBox
            // 
            usrBox.Location = new Point(96, 164);
            usrBox.Name = "usrBox";
            usrBox.Size = new Size(308, 23);
            usrBox.TabIndex = 1;
            // 
            // passBox
            // 
            passBox.Location = new Point(96, 253);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(308, 23);
            passBox.TabIndex = 2;
            passBox.TextChanged += passBox_TextChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MidnightBlue;
            btnSave.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Location = new Point(307, 321);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(97, 25);
            btnSave.TabIndex = 3;
            btnSave.Text = "save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.ForestGreen;
            progressBar1.Location = new Point(96, 321);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(170, 25);
            progressBar1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(96, 46);
            label1.Name = "label1";
            label1.Size = new Size(70, 16);
            label1.TabIndex = 5;
            label1.Text = "Source : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(96, 128);
            label2.Name = "label2";
            label2.Size = new Size(94, 16);
            label2.TabIndex = 6;
            label2.Text = "Username : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(96, 220);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 7;
            label3.Text = "Password : ";
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(500, 449);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btnSave);
            Controls.Add(passBox);
            Controls.Add(usrBox);
            Controls.Add(srcBox);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Save";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox srcBox;
        private TextBox usrBox;
        private TextBox passBox;
        private Button btnSave;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}