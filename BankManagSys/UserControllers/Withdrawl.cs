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
    public partial class Withdrawl : UserControl
    {
        public Withdrawl()
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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
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
                            txtPhoneNo.Text = myDataReader[3].ToString();
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
        }

        private void txtBranch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccountNo.Text == "" || txtAmount.Text == "" || txtFullname.Text == "" || txtPhoneNo.Text == "" || branchType.SelectedIndex == 0)
                {
                    MessageBox.Show("empty feilds", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (bTBalance == 0 || decimal.Parse(txtAmount.Text) > bTBalance)
                    {
                        MessageBox.Show("the Account of" + txtFullname.Text + " is not enough....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        balance = bTBalance - decimal.Parse(txtAmount.Text);
                        myConnection = new SqlConnection(conn.connectionString);
                        myConnection.Open();
                        commandString = "insert into transTbl values(GETDATE(),'" + branchType.Text + "'," + txtAccountNo.Text + ",'" + txtFullname.Text + "'," + txtPhoneNo.Text + "," + txtAmount.Text + ",0," + bTBalance + "," + balance + ",1)";
                        myCommand = new SqlCommand(commandString, myConnection);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        myConnection.Open();
                        SqlCommand myCommand1 = new SqlCommand("update accounts set Balance = " + balance + " where Account_No = " + txtAccountNo.Text + ";", myConnection);
                        myCommand1.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("successfull operation", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFullname.Text = "";
                        txtAccountNo.Text = "";
                        txtAmount.Clear();
                        txtPhoneNo.Text = "";
                        branchType.SelectedIndex = 0;

                    }
                    //clear
                    myConnection.Close();
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }


      
    }
    

