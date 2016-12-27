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
    public partial class infoForm : Form
    {
        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\scheduleForm\scheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);

        private OleDbCommand cmd;

        private string month;
        private string day;
        private string date;

        public infoForm(string m, string d, string dt)
        {
            InitializeComponent();
            month = m;
            day = d;
            date = dt;
        }

        private void infoForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                lbl_connected.Text = "Connected";
                lbl_connected.ForeColor = Color.Green;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                conn.Close();
            }
        }
    }
}
