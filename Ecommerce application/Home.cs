﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_application
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string constr = "Server = LAPTOP-RS59N8IM; database = Ecommerce; interated security = true;";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

       /* private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String [] itemsCatagory = {"Alcohol","Bikes","Books","Cars","Phone","Cleaning supplies","Clothing","Electronics","Exercise Equipment","Furniture"
                    ,"Jewelry","Medicine","Musical Instruments","Sporting goods","Tools and Home Care","Toys & Games","Watches","Other"}; 
            comboBox1.Items.AddRange(itemsCatagory);
        }
*/
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void CloseM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {

        }

        private void CloseM_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            bunifuThinButton21.Visible = false;
        }

        private void bunifuThinButton21_MouseEnter(object sender, EventArgs e)
        {
            bunifuThinButton21.Visible = true;
        }

        private void bunifuThinButton21_MouseLeave(object sender, EventArgs e)
        {
            bunifuThinButton21.Visible = false ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sign_UP_new s = new Sign_UP_new();
            panel3.Controls.Clear();
            s.Dock = DockStyle.Fill;
            panel3.Controls.Add(s.panel4);
            panel3.Show();
            panel3.BringToFront();
        }
    }
}
