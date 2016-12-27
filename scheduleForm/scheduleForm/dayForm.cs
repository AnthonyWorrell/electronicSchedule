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
    public partial class dayForm : Form
    {
        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\scheduleForm\scheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);
        private OleDbCommand cmd;
        private Button[] days;
        private string month;
        private string textString;
        private string[] dayDate;

        public dayForm(string s)
        {            
            InitializeComponent();
            month = s;
            days = new Button[] {button1, button2, button3, button4, button5, button6,
            button7, button8, button9, button10, button11, button12, button13, button14, button15,
            button16, button17, button18, button19, button20, button21, button22, button23, button24,
            button25, button26, button27, button28, button29, button30, button31};            
        }

        private void dayForm_Load(object sender, EventArgs e)
        {
            string cmdText = @"select * from ["+month+"]";
            int i = 0;
            try
            {
                conn.Open();
                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                lbl_month.Text = month;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                conn.Close();
            }            
            conn.Open();
                cmd = new OleDbCommand(cmdText, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    days[i].Visible = true;
                    days[i].Text = reader["Day"].ToString() +"\n" + reader["Date"].ToString();          
                    i++;                
                }           
            conn.Close();
        }

        private void initCommand()
        {
            string cmdText = @"select * from [CenterSchedule]
                               where ([Month] = ?) AND ([Day] = ?) AND ([Date] = ?)";

            string insert = @"insert into [CenterSchedule] ([Month], [Day], [Date])
                              values (?,?,?)";

            cmd = new OleDbCommand(cmdText, conn);
            OleDbCommand cmd2 = new OleDbCommand(insert, conn);
            cmd.Parameters.AddWithValue("?", month);
            cmd.Parameters.AddWithValue("?", dayDate[0]);
            cmd.Parameters.AddWithValue("?", dayDate[1]);

            cmd2.Parameters.AddWithValue("?", month);
            cmd2.Parameters.AddWithValue("?", dayDate[0]);
            cmd2.Parameters.AddWithValue("?", dayDate[1]);
            conn.Open();

            int numEntries = 0;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                numEntries++;
            }
           
            if (numEntries <= 0)
            {
                cmd2.ExecuteNonQuery();
            }            
            conn.Close();
            infoForm inf = new infoForm(month, dayDate[0],dayDate[1]);
            inf.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textString = button1.Text;
            dayDate = textString.Split('\n');
            initCommand();
        }
    }
}
