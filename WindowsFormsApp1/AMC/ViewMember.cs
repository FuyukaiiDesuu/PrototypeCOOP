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
    public partial class ViewMember : Form
    {
        public MySqlConnection conn;
        public ViewMember()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost;Database=amc;Uid=root;Pwd=root;");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            Rifrish();
        }
        private void Rifrish()
        {
            try
            {
                conn.Open();
                MySqlCommand comm = new MySqlCommand("SELECT concat(family_name, ', ',first_name) as Name FROM members ", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Height = (dataGridView1.GetRowDisplayRectangle(0, true).Bottom) * dataGridView1.RowCount + dataGridView1.ColumnHeadersHeight;
                dataGridView1.Columns["member_id"].Visible = false;
                conn.Close();
               // MessageBox.Show("" + dataGridView1.RowCount+ dataGridView1.ColumnHeadersHeight);
            }
            catch (Exception ee)
            {
                //MessageBox.Show(ee.ToString());
                conn.Close();
            }
            dataGridView1.ClearSelection();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text != "")
            {
                try
                {
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT * FROM members WHERE family_name LIKE '" + tbSearch.Text + "%'", conn);
                    MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Height = (dataGridView1.GetRowDisplayRectangle(0, true).Bottom) * dataGridView1.RowCount + dataGridView1.ColumnHeadersHeight;
                    conn.Close();
                }
                catch (Exception ee)
                {
                    //MessageBox.Show(ee.ToString());
                    conn.Close();
                }
            }
            else
            {
                Rifrish();
                Rifrish();
            }
        }
    }
}
