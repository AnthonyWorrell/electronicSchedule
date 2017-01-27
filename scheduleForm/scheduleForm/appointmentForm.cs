﻿using System;
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

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=X:\Data\scheduleDB.accdb;
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
        private List<DateTime> openTimes;
        private DateTime[] endTimes;
        private List<DateTime> check;

        #endregion</class variables>

        #region<class drivers and constructors>

        public appointmentForm(DateTime c, string n, string r, List<DateTime> ot, int ra, string u)
        {
            InitializeComponent();
            current = c;
            name = n;
            room = r;
            rank = ra;
            user = u;
            openTimes = ot;
            endTimes = new DateTime[openTimes.Count];
            openTimes.CopyTo(endTimes);
        }

        private void appointmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lbl_name.Text = name + ", " + room;
                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                cmb_start.DataSource = openTimes;
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
        private bool isValidAppointment()
        {
            app = new Appointment(Convert.ToDateTime(cmb_start.SelectedItem),
                                  Convert.ToDateTime(cmb_end.SelectedItem));

            if(app.end <= app.start)
            {
                MessageBox.Show("Error: start time can not be less then or equal to end time");
                return false;
            }else
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
                Appointment temp;
                while (reader.Read())
                {
                    temp = new Appointment(Convert.ToDateTime(reader["Time In"]),
                                                  Convert.ToDateTime(reader["Time Out"]));

                    check = openTimes.GetRange(openTimes.IndexOf(temp.start),
                                              openTimes.IndexOf(temp.end) - openTimes.IndexOf(temp.start));

                    for (int i = 0; i < check.Count; i++)
                    {
                        if (app.isIntercepted(check[i]))
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
