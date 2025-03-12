using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM21
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hemanth gowda T N\OneDrive\Documents\ATMDB.mdf"";Integrated Security=True;Connect Timeout=30");
        
        public void GetBlacnceMethod()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Blance from AccountTbl where AccNum='" + AccNumLbl.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BlanceLbl.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccNumLbl.Text = Login.accountNum;
            GetBlacnceMethod();
        }

        private void AccNumLbl_Click(object sender, EventArgs e)
        {
            AccNumLbl.Text = Login.accountNum;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
