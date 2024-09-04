using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ScdMergeWizard.Formz
{
    public partial class ConnectDbForm : Form
    {
        SqlConnection _cnn = null;
        string _ConnectionString = "";

        public ConnectDbForm(string connectionString)
        {
            InitializeComponent();
            txtLoginWindows.Text = Environment.UserDomainName + @"\" + Environment.UserName;
            cmbAuthentication.SelectedIndex = 0;    //Windows Auth
            txtServerName.Text = "localhost";
            comboBox1.SelectedIndex = 0;
            RestoreSettings(connectionString);
        }

        private void RestoreSettings(string connectionString)
        {
            SqlConnectionStringBuilder b = new SqlConnectionStringBuilder(connectionString);
            int AuthIndex = 0;
            if (b.Authentication == SqlAuthenticationMethod.ActiveDirectoryInteractive)
                AuthIndex = 2;
            if (b.Authentication == SqlAuthenticationMethod.SqlPassword)
                AuthIndex = 1;
            cmbAuthentication.SelectedIndex = AuthIndex;
            txtLoginSQL.Text = b.UserID;
            txtPassword.Text = b.Password;
            txtServerName.Text = b.DataSource;
            cmbDatabase.Text = b.InitialCatalog;
        }

        private void cmbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSqlMode = cmbAuthentication.SelectedIndex == 1;
            bool isEntraMFAmode = cmbAuthentication.SelectedIndex == 2;
            lblLogin.Enabled = isSqlMode;
            lblPassword.Enabled = isSqlMode;
            if (!isSqlMode) chkRememberPwd.Checked = false;
            chkRememberPwd.Enabled = isSqlMode;
            txtLoginSQL.Enabled = true;
            txtLoginSQL.Visible = isSqlMode || isEntraMFAmode;
            txtLoginWindows.Visible = !isSqlMode && !isEntraMFAmode;
            txtPassword.Enabled = isSqlMode;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder();

            switch (cmbAuthentication.SelectedIndex)
            {
                case 0:
                    cb.IntegratedSecurity = true;
                    break;
                case 1:
                    cb.IntegratedSecurity = false;
                    cb.UserID = txtLoginSQL.Text;
                    cb.Password = txtPassword.Text;
                    break;
                case 2:
                    cb.Authentication = SqlAuthenticationMethod.ActiveDirectoryInteractive;
                    cb.UserID = txtLoginSQL.Text;
                    break;
            }
            cb.DataSource = txtServerName.Text;
            cb.InitialCatalog = cmbDatabase.Text;
            try
            {
                _ConnectionString = cb.ConnectionString;
                _cnn = new SqlConnection(cb.ConnectionString);
                _cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public SqlConnection Connection
        {
            get { return _cnn; } 
        }

        public string ConnectionString
        {
            get { return _ConnectionString; }
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {
            cmbDatabase.Items.Clear();
        }

        private void cmbDatabase_DropDown(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            btnConnect_Click(sender, e);
            if (_cnn.State == ConnectionState.Open && cmbDatabase.Items.Count == 0)
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT [name] FROM sys.databases ORDER BY [name];", _cnn);
                da.Fill(t);
                foreach (DataRow row in t.Rows)
                {
                    cmbDatabase.Items.Add(row[0].ToString());
                }
            }
        }

        private void ConnectDbForm_Load(object sender, EventArgs e)
        {

        }

        private void chkRememberPwd_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
