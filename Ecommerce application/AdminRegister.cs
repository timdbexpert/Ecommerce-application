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
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_Leave(object sender, EventArgs e)
        {
            txtFName.Text = txtFName.Text.Substring(0, 1).ToUpper() + txtFName.Text.Substring(1).ToLower();
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            txtLName.Text = txtLName.Text.Substring(0, 1).ToUpper() + txtLName.Text.Substring(1).ToLower();
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
