using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankManagSys.UserControllers
{
    public partial class accountUpdate : UserControl
    {
        public accountUpdate()
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


    private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btndele_Click(object sender, EventArgs e)
        {
            try
            {
                //check if empty
                if (txtsearch.Text != "")
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "select * from accounts where Account_No = " + txtsearch.Text + ";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    //check if some thing is found
                    if (myDataReader.Read())
                    {
                        txtFullname.Text = myDataReader[0].ToString();
                        txtAccountNo.Text = myDataReader[1].ToString();
                        txtPhoneNo.Text = myDataReader[3].ToString();
                        txtDOB.Text = myDataReader[4].ToString();
                        txtAddress.Text = myDataReader[5].ToString();
                        txtDistrict.Text = myDataReader[6].ToString();
                        GenderType.SelectedIndex = (myDataReader[7].ToString().Equals("MALE") ? GenderType.SelectedIndex = 1 : GenderType.SelectedIndex = 2);
                        myConnection.Close();



                    }
                    else
                    {
                        MessageBox.Show("Search not found.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    myConnection.Close();
                }
                else
                {
                    MessageBox.Show("Search feild is empty.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GenderType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDistrict_TextChanged(object sender, EventArgs e)
        {

        }

        private void accountUpdate_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.bANK_M_SDataSet1.accounts);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                //check if 
                if (txtFullname.Text != "" || txtAccountNo.Text != "" || txtPhoneNo.Text != "" || GenderType.SelectedIndex != 0 || txtAddress.Text != "" || txtDistrict.Text != "" || txtDOB.Text != "")
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "update accounts set FullName = '"+txtFullname.Text+"',Account_No = "+txtAccountNo.Text+",Phone_No = "+txtPhoneNo.Text+",DOB= '"+txtDOB.Text+"',Address = '"+txtAddress.Text+"',District ='"+txtDistrict.Text+"',gender = '"+GenderType.Text+"' where Account_No = "+txtsearch.Text+";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("successfull updated the account ", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFullname.Text = "";
                    txtAccountNo.Text = "";
                    txtPhoneNo.Text = "";
                    GenderType.SelectedIndex = 0;
                    txtAddress.Text = "";
                    txtDistrict.Text = "";
                    txtDOB.Text = "";
                    txtsearch.Clear();
                    this.accountsTableAdapter.Fill(this.bANK_M_SDataSet1.accounts);
                    //check if some thing is found
                }
                else
                {
                    MessageBox.Show("Search feild is empty.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "";
            txtAccountNo.Text = "";
            txtPhoneNo.Text = "";
            GenderType.SelectedIndex = 0;
            txtAddress.Text = "";
            txtDistrict.Text = "";
            txtDOB.Text = "";
            txtsearch.Clear();

        }
    }
}
