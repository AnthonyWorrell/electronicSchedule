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
        #region<class variables>

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Test Databases\TestEmployeeDb.accdb;
                                            Jet OLEDB:Database Password=changeMe;";

        private string username;
        private string hashedPassword;

        private OleDbConnection conn = new OleDbConnection(conString);
        private OleDbCommand cmd;
        private SecurePasswordHasher hasher;

        #endregion</class variables>

        #region<class drivers and constructors>
        /// <summary>
        /// New password change form, requires username for sql
        /// </summary>
        /// <param name="Username">username</param>
        public changePasswordForm(string Username)
        {
            InitializeComponent();
            username = Username;
        }
        /// <summary>
        /// checks connection to database on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        #endregion</class drivers and constructors>

        #region<event handlers>
        /// <summary>
        /// if valid password and passwords match, update password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string cmdText = "update [npEmployeeTest] set [HashedPassword] = ?, [FirstLogin] = 0 where [Username] = ?";
            conn.Open();

            cmd = new OleDbCommand(cmdText, conn);            

            if (txt_pword.Text == txt_pwordConfirm.Text)
            {
                hasher = new SecurePasswordHasher();

                hashedPassword = hasher.Hash(txt_pword.Text.ToString());

                cmd.Parameters.AddWithValue("?", hashedPassword);
                cmd.Parameters.AddWithValue("?", username);

                cmd.ExecuteScalar();

                MessageBox.Show("Password changed");

                this.Close();
            }
            else
                MessageBox.Show("passwords do not match");

            conn.Close();
        }
        #endregion</event handlers>

    }
}

