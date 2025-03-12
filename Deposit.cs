using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM21
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hemanth gowda T N\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        int oldBlance, newBlance;
        string Acc = Login.accountNum;
        public void GetBlacnceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Blance from AccountTbl where AccNum='" + Acc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBlance = Convert.ToInt32(dt.Rows[0][0].ToString());
            con.Close();
        }
        private void AddTransctionMethod()
        {
            string transactionType = "Deposit";
            try
            {
                con.Open();
                string query = "insert into TransactionTbl Values('" + Acc + "','" + transactionType + "'," + DepositAmtLbl.Text + ",'" + DateTime.Today.ToString() + "')";
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(DepositAmtLbl.Text==""|| Convert.ToInt32(DepositAmtLbl.Text)<=0)
            {
                MessageBox.Show("Enter Amount To Deposit");
            }
            else
            {
               
                newBlance = oldBlance + Convert.ToInt32(DepositAmtLbl.Text);
                try
                {
                    con.Open();
                    string query = "update AccountTbl set Blance=" + newBlance + "where AccNum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Successfuly Deposited");
                    con.Close();
                    AddTransctionMethod();
                    HOME home = new HOME();
                    this.Hide();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DepositAmtLbl_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBlacnceMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
