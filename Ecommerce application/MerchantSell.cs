﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecommerce_application
{
    public partial class MerchantSell : Form
    {
        public MerchantSell()
        {
            InitializeComponent();
            //ADJUST THE DATETIME PCKER FOR BIRTHDAY
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Value = new DateTime(1753,1,1,1,1,1);

            //HIDE THE EXPIREDATE DATE PICKER AND ITS LABEL WHEN LOAD
            dateTimePicker1.Hide();
            label1.Hide();
            textBox4.Location = new Point(117, 245);
            label3.Location = new Point(31, 252);
        }

        //BROWSE IMAGE OF THE PRODUCT
        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Choose photo (*.jpg; *.png; *.bmp;) | " + "*.jpg; *.jpeg; *.bmp *.JFIF; *.png;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = Image.FromFile(op.FileName);
                addPhoto.Hide();
            }
        }

        //ADD PRODUCTS TO THE DATABASE
        private void button3_Click(object sender, EventArgs e)
        {
            //accessing merchant to send the user name to database
            string userName=Merchant.name;
            //TAKE THE DATE FROM THE PICKER
            string expDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            //FOR DATE STAMP (to identify latest products)
            string now = DateTime.Now.ToShortDateString();

            if (!textBox5.Text.Equals("")|| !comboBox1.Text.Equals(""))
            {
                //CONVERTING THE IMAGE TO BYTE
                MemoryStream ms = new MemoryStream();
                pictureBox1.BackgroundImage.Save(ms, pictureBox1.BackgroundImage.RawFormat);
                byte[] photo = ms.ToArray();
                ms.SetLength(0);

                //TRANSFERING THE DATA TO LAYER 2 (MERCHANTCLASS) FROM THE FEILDS
                MerchantClass mc = new MerchantClass(textBox5.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox4.Text, expDate, now, photo, userName);
                mc.Add();

                //AFTER PRODUCT ADDED SUCESSFULLY THE FIELDS WILL BE CLEARD
                textBox5.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                pictureBox1.BackgroundImage.Dispose();
                pictureBox1.BackgroundImage = global::Ecommerce_application.Properties.Resources.Asset_1353;

                if (!comboBox1.Items.Contains(""))
                {
                    comboBox1.Items.Add("");
                }
                comboBox1.Text = "";
                //INSTANTIATING MERCHANT WILL UPDATE THE PRODUCTS IN BUY AFTER NEW PRODUCT ADDED
                Merchant m = new Merchant();
            }

            else
            {
                MessageBox.Show("Please fill the required fields!");
               
            }

        }

        //WHEN CANCEL PRESSED THE FIELDS WILL BE CLEARED
        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox2.Clear();
            textBox3.Clear();
            if (!comboBox1.Items.Contains(""))
            {
                comboBox1.Items.Add("");
            }
            comboBox1.Text = "";
            textBox4.Clear();
        }

        //WHEN PRODUCTS THAT WILL EXPIRE ADDED EXPIREDATE WILL BE SHOWN OTHER WISE ITS HIDDEN
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cosmotics" || comboBox1.Text == "Medicine" || comboBox1.Text == "Cleaning supplies")
            {
                dateTimePicker1.Value = new DateTime(2022, 1, 1, 1, 1, 1);
                dateTimePicker1.Show();
                label1.Show();
                textBox4.Location = new Point(117, 282);
                label3.Location = new Point(31, 285);
            }
            else
            {
                dateTimePicker1.Hide();
                label1.Hide();
                textBox4.Location = new Point(117, 245);
                label3.Location = new Point(31, 252);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(""))
                comboBox1.Items.Remove("");
        }

        //clear picture box
        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = global::Ecommerce_application.Properties.Resources.Asset_1353;
        }
    }
}
