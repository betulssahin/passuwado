namespace PasswordManager
{
    partial class MainForm
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

        //private System.Windows.Forms.ProgressBar progressBar;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dgvPasswords = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPasswords).BeginInit();
            SuspendLayout();
            // 
            // dgvPasswords
            // 
            dgvPasswords.AllowUserToAddRows = false;
            dgvPasswords.BackgroundColor = Color.WhiteSmoke;
            dgvPasswords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasswords.GridColor = Color.Gainsboro;
            dgvPasswords.Location = new Point(31, 65);
            dgvPasswords.Name = "dgvPasswords";
            dgvPasswords.ReadOnly = true;
            dgvPasswords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPasswords.Size = new Size(443, 240);
            dgvPasswords.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(59, 348);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MidnightBlue;
            btnEdit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEdit.ForeColor = Color.WhiteSmoke;
            btnEdit.Location = new Point(194, 348);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(92, 36);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MidnightBlue;
            btnDelete.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.WhiteSmoke;
            btnDelete.Location = new Point(333, 348);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 36);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(500, 449);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvPasswords);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ForeColor = Color.MidnightBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password List";
            ((System.ComponentModel.ISupportInitialize)dgvPasswords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPasswords;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
    }
}