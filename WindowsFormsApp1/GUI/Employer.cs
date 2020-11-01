﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.BUS;
using WindowsFormsApp1.CLASS;

namespace WindowsFormsApp1.GUI
{
    public partial class Employer : Form
    {
        List<FOOD> lfood = new List<FOOD>();
        FOODBUS fbus = new FOODBUS();
        public Employer()
        {
            InitializeComponent();
        }

        private void Employer_Load(object sender, EventArgs e)
        {
            showdatagridview();
            showdesk();
        }
        public void showdesk()
        {
            comboBox1.DataSource = DESKBUS.GETDESK();
            comboBox1.ValueMember = "IDDESK";
        }
        public void showdatagridview()
        {
            /*    DataTable dt = new DataTable(FOODBUS.GETFOOD().ToString());
                dataGridView1.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = false;
                    dataGridView1.Rows[n].Cells[1].Value = item["ID"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["NAMEFOOD"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["SPICE"].ToString();
                }*/

            dataGridView1.DataSource = FOODBUS.GETFOOD();
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 15);
            this.dataGridView2.DefaultCellStyle.Font = new Font("Times New Roman", 15);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView2.CurrentCell.RowIndex;
            dataGridView2.Rows.RemoveAt(rowIndex);
        }

        private void exportbil_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[0].Value) == false)
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = true;
            }
            else
            {
                dataGridView1.SelectedRows[0].Cells[0].Value = false;
            }

        }

        private void addbill_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value) == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    dataGridView2.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    dataGridView2.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = FOODBUS.GETFOOD();

        }
    }
}
