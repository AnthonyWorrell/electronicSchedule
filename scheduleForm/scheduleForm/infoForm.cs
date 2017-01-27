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
    public partial class infoForm : Form
    {
        #region <class variables>

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=X:\Data\scheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);

        private OleDbCommand cmd;
        private OleDbDataReader reader;
        private DateTime defaultTime;
        private DateTime current;
        private Appointment app;

        private int rank;

        private string user;
        private string cmdText;

        private List<string> servers;
        private List<string> rooms;
        private List<DateTime> openTimes;
        private List<Appointment> appointments;

        #endregion</class variables>

        #region<class drivers and constructors>

        public infoForm(DateTime c, int r, string u)
        {
            InitializeComponent();
            rank = r;
            user = u;
            current = c;
            servers = new List<string>();
            rooms = new List<string>();
            openTimes = new List<DateTime>();
            appointments = new List<Appointment>();
        }

        private void infoForm_Load(object sender, EventArgs e)
        {
            initData();
        }

        //mini driver method. calls all load methods
        private void initData()
        {
            try
            {
                conn.Open();//open connection

                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                initServers();
                initRooms();
                initTimes();

                conn.Close();//close connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                conn.Close();
            }
        }

        #endregion</class drivers and constructors>

        #region<event handlers>

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (rad_servers.Checked)
            {
                checkServers();
            }
            else if (rad_rooms.Checked)
            {
                checkRooms();
            }
            else if (rad_both.Checked)
            {
                checkBoth();
            }
            else
            {
                MessageBox.Show("No Search Type Selected");
            }
        }

        //reset controls
        private void btn_resetTimes_Click(object sender, EventArgs e)
        {
            cmb_times.DataSource = null;
            cmb_servers.SelectedItem = "";
            cmb_rooms.SelectedItem = "";
        }

        //pass in required paramaters to appointForm
        private void btn_schedule_Click(object sender, EventArgs e)
        {
            appointmentForm af = new appointmentForm(current,
                                cmb_servers.SelectedItem.ToString(), cmb_rooms.SelectedItem.ToString(),
                                openTimes, rank, user);
            af.ShowDialog();
        }

        //delete appointment if the user has that level of control
        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string message = "Are you sure you want to delete This Appointment?";
            string caption = "Warning";
            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                deleteAppointment();
            }

        }

        #endregion</event handlers>

        #region<void functions>

        //Method used to load servers into a list
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

        //Method to load rooms into a list
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
            cmb_rooms.DataSource = rooms;
        }

        //Method used to load all possible times in a list
        private void initTimes()
        {
            openTimes.Clear();
            defaultTime = new DateTime(2017, current.Month, current.Day, 9, 0, 0);

            for (int i = 0; i <= 48; i++)
            {
                openTimes.Add(defaultTime);
                defaultTime = defaultTime.AddHours(.25);
            }
        }
        private void checkBoth()
        {
            cmb_times.DataSource = null;
            appointments.Clear();

            string temp = @"select * from [CenterSchedule]                     
                        where [CurrentDate] = ? AND [Server] = '" + cmb_servers.SelectedItem.ToString() +
                        "' OR [Room] = '" + cmb_rooms.SelectedItem.ToString() + "' ";

            if (cmb_servers.SelectedItem.ToString() != "" && cmb_rooms.SelectedItem.ToString() != "")
            {
                getCurrentAppointments(temp);
            }
            else
            {
                MessageBox.Show("incomplete field");
            }
        }

        private void checkServers()
        {
            cmb_times.DataSource = null;
            appointments.Clear(); ;

            string temp = @"select * from [CenterSchedule]                     
                        where [CurrentDate] = ? AND [Server] = '" + cmb_servers.SelectedItem.ToString() + "'";

            if (cmb_servers.SelectedItem.ToString() != "")
            {
                getCurrentAppointments(temp);
            }
            else
            {
                MessageBox.Show("incomplete field");
            }
        }

        private void checkRooms()
        {
            cmb_times.DataSource = null;
            appointments.Clear();

            string temp = @"select * from [CenterSchedule]                     
                         where [CurrentDate] = ? 
                         AND [Room] = '" + cmb_rooms.SelectedItem.ToString() + "' ";

            if (cmb_rooms.SelectedItem.ToString() != "")
            {
                getCurrentAppointments(temp);
            }
            else
            {
                MessageBox.Show("incomplete field");
            }
        }
        private void cmb_servers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_times.DataSource = null;
        }

        private void cmb_rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_times.DataSource = null;
        }

        //check for unavialable times and remove them from the open times list
        private void getCurrentAppointments(string c)
        {
            cmdText = c;

            cmd = new OleDbCommand(cmdText, conn);

            conn.Open();//open     

            cmd.Parameters.AddWithValue("?", current);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (!DBNull.Value.Equals(reader["Time In"]) && !DBNull.Value.Equals(reader["Time Out"]))
                {
                    app = new Appointment(Convert.ToDateTime(reader["Time In"]),
                                              Convert.ToDateTime(reader["Time Out"]), reader["Server"].ToString(), reader["Room"].ToString());
                    appointments.Add(app);
                }
            }
            appointments.Sort();
            cmb_times.DataSource = appointments;

            conn.Close();//close
        }

        private void deleteAppointment()
        {
            app = (Appointment)cmb_times.SelectedItem;
            string cmdText = @"delete from [CenterSchedule]
                               where [CurrentDate] = ? AND [Time In] =? AND [Time Out] =? AND [Server] = '" + cmb_servers.SelectedItem.ToString() +
                               "' AND [Room] = '" + cmb_rooms.SelectedItem.ToString() + "' ";

            cmd = new OleDbCommand(cmdText, conn);

            conn.Open();

            cmd.Parameters.AddWithValue("?", current);
            cmd.Parameters.AddWithValue("?", app.start);
            cmd.Parameters.AddWithValue("?", app.end);

            cmd.ExecuteScalar();

            conn.Close();

            MessageBox.Show("Appointment info: "+app+"has been deleted");
            appointments.Remove(app);

            cmb_times.DataSource = null;
            cmb_times.DataSource = appointments;
        }

        #endregion</void functions>      
    }
}
