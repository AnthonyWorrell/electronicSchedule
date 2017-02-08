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
    public partial class appointmentForm : Form
    {

        #region<class variables>

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Test Databases\TestscheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);

        private OleDbCommand cmd;
        private OleDbCommand cmd2;
        private OleDbDataReader reader;
        private Appointment app;
        private int rank;

        private string user;
        private string name;
        private string room;
        private string cmdText;

        private DateTime current;        
        private DateTime[] endTimes;

        private List<DateTime> startTimes;
        private List<DateTime> timeRange;

        #endregion</class variables>

        #region<class drivers and constructors>
        /// <summary>
        /// Pass needed data
        /// </summary>
        /// <param name="currentTime">Time selected in schedule maker form</param>
        /// <param name="Name">server name</param>
        /// <param name="Room">room name</param>
        /// <param name="PossibleAppointmentTimes">all possible appointment times</param>
        /// <param name="Rank">user rank</param>
        /// <param name="User">user name</param>
        public appointmentForm(DateTime currentTime, string Name, string Room, List<DateTime> PossibleAppointmentTimes, int Rank, string User)
        {
            InitializeComponent();
            current = currentTime;
            name = Name;
            room = Room;
            rank = Rank;
            user = User;
            startTimes = PossibleAppointmentTimes;
            endTimes = new DateTime[startTimes.Count];
            startTimes.CopyTo(endTimes);
        }
        /// <summary>
        /// checks connection to database on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appointmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lbl_name.Text = name + ", " + room;
                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                cmb_start.DataSource = startTimes;
                cmb_end.DataSource = endTimes;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                conn.Close();
            }
        }
        #endregion</class drivers and constructors>

        #region<event handlers>
        private void btn_schedule_Click(object sender, EventArgs e)
        {
            string cmdText = @"insert into [CenterSchedule] ([CurrentDate], [Server], [Room], [Time In], [Time Out])
                              values (?,?,?,?,?)";

            cmd2 = new OleDbCommand(cmdText, conn);

            //check if start > end or if the desired appoint intercepts existing appointments
            if (isValidAppointment())
            {
                conn.Open();//open

                cmd2.Parameters.AddWithValue("?", current);
                cmd2.Parameters.AddWithValue("?", name);
                cmd2.Parameters.AddWithValue("?", room);
                cmd2.Parameters.AddWithValue("?", cmb_start.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("?", cmb_end.SelectedItem.ToString());
                cmd2.ExecuteNonQuery();

                conn.Close();//close

                MessageBox.Show("Appointment scheduled for " + name + "\nfrom " + Convert.ToDateTime(cmb_start.SelectedItem).ToString("t") + " to " + Convert.ToDateTime(cmb_end.SelectedItem).ToString("t") +
                " on " + current.ToShortDateString());
            }
            
        }
        #endregion</event handlers>

        #region<non-void functions>

        /// <summary>
        /// O(n^2) possibly needs refinement.
        /// Checks appointments on a given day
        /// </summary>
        /// <returns>If the appoint is possible</returns>
        private bool isValidAppointment()
        {
            //desired appointment
            app = new Appointment(Convert.ToDateTime(cmb_start.SelectedItem),
                                  Convert.ToDateTime(cmb_end.SelectedItem));

            //if start is greater then end, invalid appointment
            if(app.end <= app.start)
            {
                MessageBox.Show("Error: start time can not be less then or equal to end time");
                return false;
            }
            else
            {
                if (room != "")
                {
                    cmdText = @"select * from [CenterSchedule]                     
                            where [CurrentDate] = ? 
                           AND [Server] = '" + name + "' OR [Room] = '" + room + "' ";
                }
                else
                {
                    cmdText = @"select * from [CenterSchedule]                     
                            where [CurrentDate] = ? 
                            AND [Server] = '" + name + "'";
                }

                cmd = new OleDbCommand(cmdText, conn);

                cmd.Parameters.AddWithValue("?", current);

                conn.Open();
                reader = cmd.ExecuteReader();
                //temp appointment, used to store appointments in database
                Appointment temp;

                while (reader.Read())
                {
                    //give temp a value
                    temp = new Appointment(Convert.ToDateTime(reader["Time In"]),
                                                  Convert.ToDateTime(reader["Time Out"]));

                    //get the time range of the selected appointment and put it in a list
                    timeRange = startTimes.GetRange(startTimes.IndexOf(temp.start),
                                              startTimes.IndexOf(temp.end) - startTimes.IndexOf(temp.start));

                    //check if any of those times intersept the desired appointment
                    //if so, return false
                    for (int i = 0; i < timeRange.Count; i++)
                    {
                        if (app.isIntercepted(timeRange[i]))
                        {
                            conn.Close();
                            MessageBox.Show("time unavailable");
                            return false;
                        }
                    }
                }
                conn.Close();
                return true;
            } 
        }
        #endregion</non-void functions>

    }
}
