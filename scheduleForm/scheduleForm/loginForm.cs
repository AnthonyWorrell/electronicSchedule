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
    public partial class loginForm : Form
    {

        #region<class variables>

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=X:\Data\npEmployeeDb.accdb;
                                            Jet OLEDB:Database Password=NBHCdata;";
        private bool firstLogin;
        private string username;

        private OleDbConnection conn = new OleDbConnection(conString);
        private OleDbCommand cmd;
        private OleDbCommand cmd2;
        private scheduleMakerForm sf;

        #endregion</class variables>

        #region<class drivers and constructors>
         
        public loginForm()
        {
            InitializeComponent();
        }

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

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            //paramaterized query statement
            string cmdText = "select count(*) from [npEmployeeTest] where [Username]=? and [Password]=?";
            string name;
            int rank;
            conn.Open();
            cmd = new OleDbCommand(cmdText, conn);

            cmd.Parameters.AddWithValue("?", txt_username.Text);
            cmd.Parameters.AddWithValue("?", txt_password.Text);

            int result = (int)cmd.ExecuteScalar();

            if (result > 0)//if valid log in
            {
                MessageBox.Show("Log in Successful");

                string selectCmd = "select * from [npEmployeeTest] where [Username] =? and [Password] =?";
                OleDbCommand selcmd = new OleDbCommand(selectCmd, conn);

                //qyery parameters
                selcmd.Parameters.AddWithValue("?", txt_username.Text);
                selcmd.Parameters.AddWithValue("?", txt_password.Text);

                OleDbDataReader reader = selcmd.ExecuteReader();
                reader.Read();
                name = reader["Last"].ToString() + ", " + reader["First"].ToString();
                username = reader["Username"].ToString();
                firstLogin = (bool)reader["FirstLogin"];

                if (firstLogin)
                {
                    changePasswordForm cf = new changePasswordForm(username);
                    cf.ShowDialog();
                }

                rank = Convert.ToInt32(reader["rank"]);

                //send logged in employee info to menu form
                sf = new scheduleMakerForm(name,rank);

                this.Hide();//hide log in form
                sf.ShowDialog();
                this.Dispose();
                this.Close();//close program                  
            }
            else//if invalid log in
                MessageBox.Show("invalid username or password");
            conn.Close();
        }

        #endregion</event handlers>

    }
}
