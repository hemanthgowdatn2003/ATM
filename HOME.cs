﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM21
{
    public partial class HOME : Form
    {
        public object AccNumLbl { get; private set; }

        public HOME()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            bal.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MiniStatement Min = new MiniStatement();
            Min.Show();
            this.Hide();
        }

        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumLbL.Text = "Account Number : "+ Login.accountNum;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit dep = new Deposit();
            dep.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin CPin = new ChangePin();
            CPin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FastCash fc = new FastCash();
            fc.Show();
            this.Hide();
        }
    }
}
