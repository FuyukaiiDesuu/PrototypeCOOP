﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AMC
{
    public partial class ViewSavings : Form
    {
        public MySqlConnection conn;
        public MainForm reftomain;
        int accountstatus = 1;

        public ViewSavings(MainForm main)
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=amc;Uid=root;Pwd=root;");
            reftomain = main;
        }

        private void ViewSavings_Load(object sender, EventArgs e)
        {
            loadCbxYears();
            cbxMonth.SelectedIndex = Convert.ToInt32(DateTime.Now.Month) - 1;

            loadMonthAccounts(cbxMonth.SelectedIndex + 1, cbxYear.Text, "%");
            loadIntRate((cbxMonth.SelectedIndex + 1).ToString(), cbxYear.Text);

        }

        private void loadMonthAccounts(int mn, string yr, string like)
        {
            lblDate.Text = "Month of " + cbxMonth.Text + " " + yr;
            accountstatus = checkStatus();
            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                if (mn % 3 == 0)
                    comm.CommandText = "displayQuarterMonthTable";
                else
                    comm.CommandText = "displayMonthTable";
                comm.Parameters.AddWithValue("@mn", mn);
                comm.Parameters.AddWithValue("@yr", yr);
                comm.Parameters.AddWithValue("@accountstatus", accountstatus);
                comm.Parameters.AddWithValue("@likephrase", like);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    dgvAccounts.DataSource = dt;
                    dgvAccounts.CurrentCell.Selected = false;
                    dgvAccounts.Columns["member_id"].Visible = false;
                    conn.Close();
                }
                else
                {
                    dgvAccounts.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
            dgvAccounts.ClearSelection();
        }

        private void loadYearAccounts(string yr, string like)
        {
            lblDate.Text = "Year Summary Report for " + yr;
            accountstatus = checkStatus();
            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "displayYearTable";
                comm.Parameters.AddWithValue("@yr", yr);
                comm.Parameters.AddWithValue("@accountstatus", accountstatus);
                comm.Parameters.AddWithValue("@likephrase", like);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    dgvAccounts.DataSource = dt;
                    dgvAccounts.CurrentCell.Selected = false;
                    dgvAccounts.Columns["member_id"].Visible = false;
                    conn.Close();
                }
                else
                {
                    dgvAccounts.DataSource = dt;
                }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
            dgvAccounts.ClearSelection();
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (rdMonth.Checked == true)
                loadMonthAccounts(cbxMonth.SelectedIndex + 1, cbxYear.Text, "%");
            else
                loadYearAccounts(cbxYear.Text, "%");

            loadIntRate((cbxMonth.SelectedIndex + 1).ToString(), cbxYear.Text);
        }

        private void rdYear_Click(object sender, EventArgs e)
        {
            cbxMonth.Enabled = false;
            loadYearAccounts(cbxYear.Text, "%");
        }

        private void rdMonth_Click(object sender, EventArgs e)
        {
            cbxMonth.SelectedIndex = Convert.ToInt32(DateTime.Now.Month) - 1;
            cbxMonth.Enabled = true;
            loadMonthAccounts(cbxMonth.SelectedIndex + 1, cbxYear.Text, "%");
        }

        private int checkStatus()
        {
            if (rdOpen.Checked == true)
                return 1;
            else
                return 0;
        }

        private void rdOpen_Click(object sender, EventArgs e)
        {
            if (rdMonth.Checked == true)
                loadMonthAccounts(cbxMonth.SelectedIndex + 1, cbxYear.Text, "%");
            else
                loadYearAccounts(cbxYear.Text, "%");
        }

        private void rdClosed_Click(object sender, EventArgs e)
        {
            if (rdMonth.Checked == true)
                loadMonthAccounts(cbxMonth.SelectedIndex + 1, cbxYear.Text, "%");
            else
                loadYearAccounts(cbxYear.Text, "&");
        }

        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (rdMonth.Checked == true)
                loadMonthAccounts(cbxMonth.SelectedIndex + 1, cbxYear.Text, ("%" + tbSearch.Text + "%"));
            else
                loadYearAccounts(cbxYear.Text, ("%" + tbSearch.Text + "%"));
        }

        private void loadCbxYears()
        {
            string query; Int32 min = DateTime.Today.Year;
            cbxYear.Items.Clear();
            query = "SELECT YEAR(date) AS 'Year' FROM savings_transaction ORDER BY date ASC LIMIT 1";

            try
            {

                conn.Open();

                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    min = Convert.ToInt32(dt.Rows[0]["Year"]);
                }
                else
                { }
                conn.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }

            for (int i = DateTime.Today.Year; i >= min; i--)
                cbxYear.Items.Add(i.ToString());
            cbxYear.SelectedIndex = 0;
        }

        private void loadIntRate(string mn, string yr)
        {
            string rr;
            try
            {
                conn.Open();
                string query;
                if (rdMonth.Checked == true)
                    query = "SELECT COALESCE(interest_rate * 100,0) FROM interest_rate_log WHERE MONTH(date) <=" + mn +
                        " AND YEAR(date) <= " + yr + " ORDER BY date DESC LIMIT 1 ";
                else
                    query = "SELECT COALESCE(interest_rate * 100,0) FROM interest_rate_log WHERE" +
                        " YEAR(date) <= " + yr + " ORDER BY date DESC LIMIT 1 ";

                MySqlCommand ins = new MySqlCommand(query, conn);
                rr = ins.ExecuteScalar().ToString() + "%";
                lblInterest.Text = rr;
                conn.Close();
            }
            catch (Exception ee)
            {
                conn.Close();
            }
        }

        private void dgvAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mid, mname;
            mid = dgvAccounts.Rows[e.RowIndex].Cells["Acc. No."].Value.ToString();
            mname = dgvAccounts.Rows[e.RowIndex].Cells["Member Name"].Value.ToString();
            try
            {
                reftomain.Enabled = false;

                ViewSavingsProfile sav = new ViewSavingsProfile(reftomain, conn, mid, mname);
                sav.Show();
            }
            catch (Exception ee)
            {

            }

        }

    }
}
