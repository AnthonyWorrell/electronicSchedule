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
        #region<class variables>

        private static string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=P:\Test Databases\TestscheduleDB.accdb;
                                            Persist Security Info=False;";

        private OleDbConnection conn = new OleDbConnection(conString);

        private int rank;

        private string user;

        #endregion</class variables>

        #region<class drivers and constructors>

        public scheduleMakerForm(string n, int r)
        {
            InitializeComponent();
            user = n;
            rank = r;
        }
        /// <summary>
        /// checked connection to database on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void scheduleMakerForm_Load(object sender, EventArgs e)
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
            
            if(rank > 0)
            {
                btn_editData.Visible = true;
            }                           
        }

        #endregion</class drivers and constructors>

        #region<event handlers>
        private void btn_enter_Click(object sender, EventArgs e)
        {
            infoForm inf = new infoForm(mtc_calender.SelectionRange.Start, rank, user);
            inf.ShowDialog();
        }

        private void btn_editData_Click(object sender, EventArgs e)
        {
            editForm ef = new editForm(user);
            ef.ShowDialog();
        }
        #endregion</event handlers>
    }
}
