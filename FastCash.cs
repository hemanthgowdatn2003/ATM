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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hemanth gowda T N\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        int blance, newBlance,amount=0;
        public void GetBlacnceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Blance from AccountTbl where AccNum='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BlanceLbl.Text = "Balance RS: " + dt.Rows[0][0].ToString();
            blance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void AddTransctionMethod()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl Values('" + Acc + "','" + transactionType + "'," + amount + ",'" + DateTime.Today.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Account Created Successfuly");
                con.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                con.Close();
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(blance<100)
            {
                MessageBox.Show("Balance can't be negative ");
            }
            else
            {
                amount = 100;
                newBlance = blance - 100;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Blance=" + newBlance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfuly withdraw");
                    con.Close();
                    AddTransctionMethod();
                    HOME home = new HOME();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (blance < 500)
            {
                MessageBox.Show("Balance can't be negative ");
            }
            else
            {
                amount = 500;
                newBlance = blance - 500;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Blance=" + newBlance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfuly withdraw");
                    AddTransctionMethod();
                    con.Close();
                    HOME home = new HOME();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (blance < 1000)
            {
                MessageBox.Show("Balance can't be negative ");
            }
            else
            {
                amount = 1000;
                newBlance = blance - 1000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Blance=" + newBlance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfuly withdraw");
                    AddTransctionMethod();
                    con.Close();
                    HOME home = new HOME();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (blance < 2000)
            {
                MessageBox.Show("Balance can't be negative ");
            }
            else
            {
                amount = 2000;
                newBlance = blance - 2000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Blance=" + newBlance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfuly withdraw");
                    AddTransctionMethod();
                    con.Close();
                    HOME home = new HOME();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (blance < 5000)
            {
                MessageBox.Show("Balance can't be negative ");
            }
            else
            {
                amount = 5000;
                newBlance = blance - 5000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Blance=" + newBlance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfuly withdraw");
                    AddTransctionMethod();
                    con.Close();
                    HOME home = new HOME();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (blance < 10000)
            {
                MessageBox.Show("Balance can't be negative ");
            }
            else
            {
                amount = 10000;
                newBlance = blance - 10000;
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Blance=" + newBlance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfuly withdraw");
                    AddTransctionMethod();
                    con.Close();
                    HOME home = new HOME();
                    this.Hide();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetBlacnceMethod();
        }
    }
}
