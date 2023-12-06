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

namespace BankManagSys.UserControllers
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataAdapter myDataAdapter;
        DataTable myDataTable = new DataTable();
        SqlDataReader myDataReader;
        SqlCommandBuilder myCommandBuilder;
        string commandString;
        int userGen,accGen;
        decimal totMon;
        private void bullData()
        {
            myConnection = new SqlConnection(conn.connectionString);
            myConnection.Open();
            commandString = "select  COUNT(*),COUNT(case when gender='male' then 1 end), COUNT(case when gender='female' then 1 end) from users ;";
            myCommand = new SqlCommand(commandString, myConnection);
            myDataReader = myCommand.ExecuteReader();
            //check if some thing is found
            if (myDataReader.Read())
            {
                lblUser.Text = myDataReader[0].ToString();
                progUser.Maximum = int.Parse(myDataReader[0].ToString());
                progUser.Value = int.Parse(myDataReader[1].ToString());
              



            }
            myConnection.Close();
            myConnection.Open();
            commandString = "select SUM(balance), COUNT(*), COUNT(case when gender='male' then 1 end),COUNT(case when gender='female' then 1 end) from accounts ;";
            myCommand = new SqlCommand(commandString, myConnection);
            myDataReader = myCommand.ExecuteReader();
            if (myDataReader.Read())
            {
                lblMon.Text = myDataReader[0].ToString();
                lblAcc.Text = myDataReader[1].ToString();
                progAcc.Maximum = int.Parse(myDataReader[1].ToString());
                progAcc.Value = int.Parse(myDataReader[3].ToString());
            }
            myConnection.Close();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.transTblTableAdapter.Fill(bANK_M_SDataSet1.transTbl);
            bullData();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
    }
}
