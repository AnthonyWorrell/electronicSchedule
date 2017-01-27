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
using System.Collections;

namespace scheduleForm
{
    public partial class editForm : Form
    {
        #region <class variables>

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=X:\Data\scheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);
        private OleDbCommand cmd;
        private string user;
        private string cmdText;

        #endregion </class variables>

        #region <class drivers and constructors>

        public editForm(string n)
        {
            InitializeComponent();
            user = n;
        }

        private void editForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                lbl_name.Text = "Signed in as: " + user;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                conn.Close();
            }
        }

        #endregion </class drivers and constructors>

        #region <event handlers>
        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            addRoom();
        }

        private void btn_addServer_Click(object sender, EventArgs e)
        {
            addServer();
        }

        #endregion </event handlers>

        #region <void functions>

        private void addRoom()
        {
            cmdText = @"insert into [Rooms] ([RoomName]) values(?)";

            conn.Open();

            cmd = new OleDbCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("?", txt_room.Text.ToString());
            cmd.ExecuteScalar();
            MessageBox.Show("The room, "+txt_room.Text.ToString()+" has been added");
            
            conn.Close();
        }

        private void addServer()
        {
            cmdText = @"insert into [Servers] ([serverName]) values(?)";

            conn.Open();

            cmd = new OleDbCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("?", txt_server.Text.ToString());
            cmd.ExecuteScalar();
            MessageBox.Show("The server, " + txt_server.Text.ToString() + " has been added");

            conn.Close();
        }

        #endregion /void functions>        
       
    }
}
