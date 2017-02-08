using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scheduleForm
{
    public partial class loginForm : Form
    {
        #region<class variables>

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Test Databases\TestEmployeeDb.accdb;
                                            Jet OLEDB:Database Password=changeMe;";
        private bool firstLogin;

        private string cmdText;
        private string tempPassword = "changeMe";
        private string password;
        private string hashedPassword;
        private string user;

        private int rank;

        private changePasswordForm cf;
        private scheduleMakerForm sf;
        private SecurePasswordHasher hasher;

        private OleDbConnection conn = new OleDbConnection(conString);
        private OleDbCommand cmd;
        private OleDbDataReader reader;

        #endregion</class variables>

        #region<class drivers and constructors>

        public loginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// check database connection on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lbl_connection.ForeColor = Color.Green;
                lbl_connection.Text = "Connected";
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
        /// verify valid username and password
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_logIn_Click(object sender, EventArgs e)
        {
            //paramaterized query
            cmdText = "select * from [npEmployeeTest] where [Username]=?";

            conn.Open();

            cmd = new OleDbCommand(cmdText, conn);

            cmd.Parameters.AddWithValue("?", txt_username.Text);
            reader = cmd.ExecuteReader();

            if (reader.Read())//if valid user name
            {
                firstLogin = (bool)reader["FirstLogin"];

                if (firstLogin)
                {
                    password = tempPassword;//hard coded temp password for first time users

                    if (txt_password.Text.ToString().Equals(password))
                    {
                        cf = new changePasswordForm(reader["Username"].ToString());
                        cf.ShowDialog();
                    }
                    else
                        MessageBox.Show("invalid username or password");
                }
                else
                {
                    hasher = new SecurePasswordHasher();
                    password = txt_password.Text.ToString();

                    //get hashed password from database
                    hashedPassword = reader["HashedPassword"].ToString();

                    if (hasher.Verify(password, hashedPassword))
                    {
                        MessageBox.Show("login successful");
                        user = reader["Last"].ToString() + ", " + reader["First"].ToString();
                        rank = (int)reader["Rank"];
                        sf = new scheduleMakerForm(user, rank);
                        this.Hide();
                        sf.ShowDialog();
                        conn.Close();
                        txt_username.Text = "";
                        txt_password.Text = "";
                        this.ShowDialog();
                    }
                    else
                        MessageBox.Show("invalid username or password");
                }

            }
            else//if invalid log in
                MessageBox.Show("invalid username or password");

            conn.Close();
        }

        #endregion</event handlers>

        #region<void functions>

        #endregion</void functions>
        
    }
}
