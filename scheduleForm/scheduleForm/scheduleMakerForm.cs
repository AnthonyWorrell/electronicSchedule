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
    public partial class scheduleMakerForm : Form
    {
        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\scheduleForm\scheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);

        private OleDbCommand cmd;
        private string month;
        public scheduleMakerForm()
        {
            InitializeComponent();
        }

        private void scheduleMakerForm_Load(object sender, EventArgs e)
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
        private void launchDayForm()
        {
            dayForm df = new dayForm(month);
            df.ShowDialog();
        }
        private void btn_jan_Click(object sender, EventArgs e)
        {
            month = btn_jan.Text.ToString();
            launchDayForm();
        }

        private void btn_feb_Click(object sender, EventArgs e)
        {
            month = btn_feb.Text.ToString();
            launchDayForm();
        }

        private void btn_march_Click(object sender, EventArgs e)
        {
            month = btn_march.Text.ToString();
            launchDayForm();
        }
    }
}
