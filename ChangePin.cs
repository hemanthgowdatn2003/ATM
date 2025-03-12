using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM21
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hemanth gowda T N\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        private void button2_Click(object sender, EventArgs e)
        {
            if (Pin1Tb.Text == "" || Pin2Tb.Text =="") 
            {
                MessageBox.Show("Enter New and Confirm Pin Number");
            }
            else if(Pin2Tb.Text !=Pin1Tb.Text)
            {
                MessageBox.Show("New Pin and Confirm Pin are Differet");

            }
            else
            {

               
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Pin=" + Pin1Tb.Text + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Change Successfuly");
                    con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Close();
        }
    }

}