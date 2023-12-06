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
    public partial class Deposit : UserControl
    {
        public Deposit()
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
        decimal balance = 0;
        decimal bTBalance = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                try
                {
                    //check if empty
                    if (txtAccountNo.Text != "")
                    {
                        myConnection = new SqlConnection(conn.connectionString);
                        myConnection.Open();
                        commandString = "select * from accounts where Account_No = " + txtAccountNo.Text + ";";
                        myCommand = new SqlCommand(commandString, myConnection);
                        myDataReader = myCommand.ExecuteReader();
                        //check if some thing is found
                        if (myDataReader.Read())
                        {
                            txtFullname.Text = myDataReader[0].ToString();
                            txtPhoneNO.Text = myDataReader[3].ToString();
                            bTBalance = decimal.Parse(myDataReader[8].ToString());
                            checkBox.Checked = false;



                        }
                        else
                        {
                            MessageBox.Show("Search not found.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            checkBox.Checked = false;
                        }
                        myConnection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Search feild is empty.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        checkBox.Checked = false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {



                if (txtAccountNo.Text == "" || txtAmount.Text == "" || txtFullname.Text == "" || txtPhoneNO.Text == "" || branchType.SelectedIndex == 0)
                {
                    MessageBox.Show("empty feilds", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    balance = bTBalance + decimal.Parse(txtAmount.Text);
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "insert into transTbl values(GETDATE(),'" + branchType.Text + "'," + txtAccountNo.Text + ",'" + txtFullname.Text + "'," + txtPhoneNO.Text + ",0,"+txtAmount.Text+","+bTBalance+","+balance+",2)";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    myConnection.Open();
                    SqlCommand myCommand1 = new SqlCommand("update accounts set Balance = " + balance + " where Account_No = " + txtAccountNo.Text + ";", myConnection);
                    myCommand1.ExecuteNonQuery();
                    myConnection.Close();
                    MessageBox.Show("successfull operation", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //clear
                    txtFullname.Text = "";
                    txtAccountNo.Text = "";
                    txtAmount.Clear();
                    txtPhoneNO.Text = "";
                    branchType.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

     
    }
}
