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

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Test Databases\TestscheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);
        private OleDbCommand cmd;
        private OleDbDataReader reader;

        private string user;
        private string cmdText;

        private List<string> servers;
        private List<string> rooms;

        #endregion </class variables>

        #region <class drivers and constructors>
        /// <summary>
        /// 
        /// </summary>
        /// <param name="User">Username</param>
        public editForm(string User)
        {
            InitializeComponent();
            user = User;
            servers = new List<string>();
            rooms = new List<string>();
        }
        /// <summary>
        /// checks database connection on load
        /// initialize data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                lbl_name.Text = "Signed in as: " + user;
                initRooms();
                initServers();
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

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {
            removeRoom();
        }

        private void btn_deleteServer_Click(object sender, EventArgs e)
        {
            removeServer();
        }

        #endregion </event handlers>

        #region <void functions>
        /// <summary>
        /// Adds a room to the database
        /// </summary>
        private void addRoom()
        {
            cmdText = @"insert into [Rooms] ([RoomName]) values(?)";

            conn.Open();

            cmd = new OleDbCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("?", txt_room.Text.ToString());

            if (txt_room.Text.ToString().Contains("'") || string.IsNullOrWhiteSpace(txt_room.Text.ToString()))
                MessageBox.Show("invalid entry");
            else
            {
                cmd.ExecuteScalar();
                rooms.Add(txt_room.Text.ToString());
                cmb_Rooms.DataSource = null;
                cmb_Rooms.DataSource = rooms;
                MessageBox.Show("The room, " + txt_room.Text.ToString() + " has been added");
            }
                                      
            conn.Close();
        }
        /// <summary>
        /// Removes a room from the database
        /// </summary>
        private void removeRoom()
        {
            cmdText = @"delete from [Rooms] where [RoomName] = ?";

            conn.Open();

            cmd = new OleDbCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("?", cmb_Rooms.SelectedItem.ToString());
            MessageBox.Show("The room " + cmb_Rooms.SelectedItem.ToString() + " Has been deleted.");
            cmd.ExecuteScalar();

            rooms.Remove(cmb_Rooms.SelectedItem.ToString());
            cmb_Rooms.DataSource = null;
            cmb_Rooms.DataSource = rooms;

            conn.Close();
        }
        /// <summary>
        /// Add a server to the database
        /// </summary>
        private void addServer()
        {
            cmdText = @"insert into [Servers] ([serverName]) values(?)";

            conn.Open();

            cmd = new OleDbCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("?", txt_server.Text.ToString());

            if (txt_server.Text.ToString().Contains("'") || string.IsNullOrWhiteSpace(txt_server.Text.ToString()))
                MessageBox.Show("invalid entry");
            else
            {
                cmd.ExecuteScalar();
                servers.Add(cmb_servers.SelectedItem.ToString());
                cmb_servers.DataSource = null;
                cmb_servers.DataSource = servers;
                MessageBox.Show("The server, " + txt_server.Text.ToString() + " has been added");
            }
                
            conn.Close();
        }
        /// <summary>
        /// Remove a server from the database
        /// </summary>
        private void removeServer()
        {

            cmdText = @"delete from [Servers] where [serverName] = ?";
            conn.Open();
            cmd = new OleDbCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("?", cmb_servers.SelectedItem.ToString());
            MessageBox.Show("The room " + cmb_servers.SelectedItem.ToString() + " Has been deleted.");
            cmd.ExecuteScalar();

            servers.Remove(cmb_servers.SelectedItem.ToString());
            cmb_servers.DataSource = null;
            cmb_servers.DataSource = servers;

            conn.Close();
        }
        /// <summary>
        /// initialize room list
        /// </summary>
        private void initRooms()
        {
            int count = 0;
            cmdText = @"select * from [Rooms]";

            cmd = new OleDbCommand(cmdText, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (count == 0)
                    rooms.Add("");

                rooms.Add(reader["RoomName"].ToString());
                count++;
            }

            rooms.Sort();
            cmb_Rooms.DataSource = rooms;
        }
        /// <summary>
        /// initialize server list
        /// </summary>
        private void initServers()
        {
            int count = 0;
            cmdText = @"select * from [Servers]";

            cmd = new OleDbCommand(cmdText, conn);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (count == 0)
                    servers.Add("");
                servers.Add(reader["serverName"].ToString());
                count++;
            }

            servers.Sort();
            cmb_servers.DataSource = servers;
        }

        #endregion /void functions>        
      
    }
}
