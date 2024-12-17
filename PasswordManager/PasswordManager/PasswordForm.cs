using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PasswordManager
{
    public partial class PasswordForm : Form
    {

        private SQLiteConnection dbConnection;
        private int? passwordId;

        public PasswordForm(SQLiteConnection connection, int? id = null, string source = "", string username = "", string password = "")
        {
            InitializeComponent();
            dbConnection = connection;
            passwordId = id;
            srcBox.Text = source;
            usrBox.Text = username;
            passBox.Text = password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string source = srcBox.Text;
            string username = usrBox.Text;
            string password = passBox.Text;


            if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("fill the all space");
                return;
            }



            if (passwordId == null)
            {
                string insertQuery = "insert into Passwords (Source, Username, Password) values (@source, @username, @password)";
                SQLiteCommand command = new SQLiteCommand(insertQuery, dbConnection);
                command.Parameters.AddWithValue("@source", source);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();

            }
            else
            {
                string updateQuery = "update Passwords set Source = @source, Username = @username, Password = @password where Id = @id";
                SQLiteCommand command = new SQLiteCommand(updateQuery, dbConnection);
                command.Parameters.AddWithValue("@source", source);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@id", passwordId);
                command.ExecuteNonQuery();

            }
            this.Close();
        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {
            UpdatePasswordStrength(passBox.Text);
        }

        private void UpdatePasswordStrength(string password)
        {
            int strength = PasswordStrength.CalcPassStrength(password);

            progressBar1.Maximum = 10;
            progressBar1.Value = Math.Min(strength, progressBar1.Maximum);

        }
    }
}
