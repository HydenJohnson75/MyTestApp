using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ConnectDB
{

    public partial class frmConnectDB : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public frmConnectDB()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
                conn.Open();
                lblStatus.Text = "Connection Open";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            conn.Close();
            lblStatus.Text = "Connection Closed";
        }
    }
}
