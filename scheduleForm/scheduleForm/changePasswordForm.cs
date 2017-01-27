using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace scheduleForm
{
    public partial class changePasswordForm : Form
    {
        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=X:\Data\npEmployeeDb.accdb;
                                            Jet OLEDB:Database Password=NBHCdata;";

        private string username;

        private OleDbConnection conn = new OleDbConnection(conString);
        private OleDbCommand cmd;

        public changePasswordForm(string u)
        {
            InitializeComponent();
            username = u;
        }

        private void changePasswordForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lbl_connection.ForeColor = Color.Green;
                lbl_connection.Text = "Connected";
                MessageBox.Show("Your password must be changed.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string cmdText = "update [npEmployeeTest] set [Password] = ?, [FirstLogin] = 0 where [Username] = ?";
            conn.Open();
            cmd = new OleDbCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("?", txt_pword.Text);
            cmd.Parameters.AddWithValue("?", username);
            if (txt_pword.Text == txt_pwordConfirm.Text)
            {
                cmd.ExecuteScalar();
                MessageBox.Show("Password changed");
                this.Close();
            }
            else
                MessageBox.Show("passwords do not match");
            conn.Close();
        }
        
    }
}

