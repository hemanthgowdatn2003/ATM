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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hemanth gowda T N\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        string Acc = Login.accountNum;
        int blance;
        int newBlance;
        public void GetBlacnceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Blance from AccountTbl where AccNum='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BlanceLbl.Text ="Balance RS: " + dt.Rows[0][0].ToString();
            blance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void AddTransctionMethod()
        {
            string transactionType = "Withdraw";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl Values('" + Acc + "','" + transactionType + "'," + WithdrawAmtTb.Text + ",'" + DateTime.Today.ToString() + "')";
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

            private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Close();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            GetBlacnceMethod();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(WithdrawAmtTb.Text=="")
            {
                MessageBox.Show("Missing Amount");
            }
            else if(Convert.ToInt32(WithdrawAmtTb.Text)<=0)
            {
                MessageBox.Show("Enter a valid amount");
            }
            else if (Convert.ToInt32(WithdrawAmtTb.Text) >blance)
            {
                MessageBox.Show("Blance Can't be Negative");
            }
            else
            {
                newBlance = blance - Convert.ToInt32(WithdrawAmtTb.Text);
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
    }
}
