﻿
namespace Ecommerce_application
{
    partial class Merchant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merchant));
            this.panel3 = new System.Windows.Forms.Panel();
            this.MinMer = new System.Windows.Forms.Button();
            this.CloseM = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.MinMer);
            this.panel3.Controls.Add(this.CloseM);
            this.panel3.Location = new System.Drawing.Point(578, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 23);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // MinMer
            // 
            this.MinMer.BackColor = System.Drawing.Color.Transparent;
            this.MinMer.BackgroundImage = global::Ecommerce_application.Properties.Resources.minimize;
            this.MinMer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MinMer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinMer.ForeColor = System.Drawing.SystemColors.Control;
            this.MinMer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinMer.Location = new System.Drawing.Point(8, -1);
            this.MinMer.Margin = new System.Windows.Forms.Padding(2);
            this.MinMer.Name = "MinMer";
            this.MinMer.Size = new System.Drawing.Size(25, 25);
            this.MinMer.TabIndex = 13;
            this.MinMer.UseVisualStyleBackColor = false;
            this.MinMer.Click += new System.EventHandler(this.MinMer_Click);
            // 
            // CloseM
            // 
            this.CloseM.BackColor = System.Drawing.Color.Transparent;
            this.CloseM.BackgroundImage = global::Ecommerce_application.Properties.Resources.close_tab3;
            this.CloseM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseM.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseM.Location = new System.Drawing.Point(46, 0);
            this.CloseM.Margin = new System.Windows.Forms.Padding(2);
            this.CloseM.Name = "CloseM";
            this.CloseM.Size = new System.Drawing.Size(25, 25);
            this.CloseM.TabIndex = 14;
            this.CloseM.UseVisualStyleBackColor = false;
            this.CloseM.Click += new System.EventHandler(this.CloseM_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(122)))), ((int)(((byte)(91)))));
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Location = new System.Drawing.Point(0, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 491);
            this.panel4.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(0, 92);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "Sell";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(0, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cart";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Buy";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(50, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(600, 489);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Merchant
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(651, 512);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Merchant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Merchant_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minMerchant;
        private System.Windows.Forms.Button closeMerchant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button CloseM;
        private System.Windows.Forms.Button MinMer;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}