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
    public partial class MainForm : Form
    {
        private SQLiteConnection dbConnection;

       
                
        public MainForm()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadPasswords();


        }

        private void InitializeDatabase()
        {
            dbConnection = new SQLiteConnection("Data Source = pass.db");
            dbConnection.Open();

            string createTablequery = @"create table if not exists Passwords (Id integer primary key, Source text not null, Username text not null, Password text not null);";

            SQLiteCommand command = new SQLiteCommand(createTablequery, dbConnection);
            command.ExecuteNonQuery();


        }

        private void LoadPasswords()
        {
            string query = "select * from Passwords";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, dbConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvPasswords.DataSource = table;

            if (dgvPasswords.Columns["Id"] != null)
            {
                dgvPasswords.Columns["Id"].Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PasswordForm passwordForm = new PasswordForm(dbConnection);
            passwordForm.ShowDialog();
            LoadPasswords();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPasswords.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPasswords.SelectedRows[0].Cells["Id"].Value);
                string deleteQuery = "delete from Passwords where Id = @id";
                SQLiteCommand command = new SQLiteCommand(deleteQuery, dbConnection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                LoadPasswords();
            }
            else
            {
                MessageBox.Show("select the row you want to delete");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPasswords.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPasswords.SelectedRows[0].Cells["Id"].Value);
                string source = dgvPasswords.SelectedRows[0].Cells["Source"].Value.ToString();
                string username = dgvPasswords.SelectedRows[0].Cells["Username"].Value.ToString();
                string password = dgvPasswords.SelectedRows[0].Cells["Password"].Value.ToString();

                PasswordForm passwordForm = new PasswordForm(dbConnection, id, source, username, password);
                passwordForm.ShowDialog();
                LoadPasswords();


            }
            else
            {
                MessageBox.Show("select a row to edit");
            }
        }

        
    }
}
