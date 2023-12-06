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
    public partial class AccToAcc : UserControl
    {
        public AccToAcc()
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
        public decimal FRbalance =0;
        public decimal TObalance =0;


        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFR.Checked)
            {
                if (txtAccountNoFR.Text != "")
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "select * from accounts where Account_No = " + txtAccountNoFR.Text + ";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    //check if some thing is found
                    if (myDataReader.Read())
                    {
                        txtFullnameFR.Text = myDataReader[0].ToString();
                        txtphoneNoFR.Text = myDataReader[3].ToString();
                        FRbalance = decimal.Parse(myDataReader[8].ToString());
                        MessageBox.Show(FRbalance.ToString());



                    }
                    else
                    {
                        MessageBox.Show("Search not found.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkBoxFR.Checked = false;
                    }
                    myConnection.Close();
                }
                else
                {
                    MessageBox.Show("Empty feilds pls insert information.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxFR.Checked = false;
                }

            }
        }

        private void checkBoxTO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTO.Checked)
            {
                if (txtAccountNoTO.Text != "")
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "select * from accounts where Account_No = " + txtAccountNoTO.Text + ";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    //check if some thing is found
                    if (myDataReader.Read())
                    {
                        txtFullNameTO.Text = myDataReader[0].ToString();
                        txtphoneNoTO.Text = myDataReader[3].ToString();
                        TObalance = decimal.Parse(myDataReader[8].ToString());
                        MessageBox.Show(TObalance.ToString());




                    }
                    else
                    {
                        MessageBox.Show("Search not found.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkBoxTO.Checked = false;
                    }
                    myConnection.Close();
                }
                else
                {
                    MessageBox.Show("Empty feilds pls insert information.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxTO.Checked = false;
                }

            }
        }

        private void clear()
        {
            txtAccountNoFR.Text = "";
            txtAccountNoTO.Text = "";
            txtFullnameFR.Text = "";
            txtFullNameTO.Text = "";
            txtphoneNoFR.Text = "";
            txtphoneNoTO.Text = "";
            branchType.SelectedIndex = 0;
            txtAmount.Clear();

        }
        private void addAccTOacc()
        {
            myConnection = new SqlConnection(conn.connectionString);
            myConnection.Open();
            commandString = "INSERT INTO accTOacc  VALUES(GETDATE(),'" + branchType.Text + "'," + txtAccountNoFR.Text + ",'" + txtFullnameFR.Text + "'," + txtphoneNoFR.Text + "," + txtAccountNoTO.Text + ",'" + txtFullNameTO.Text + "'," + txtphoneNoTO.Text + "," + txtAmount.Text + ");";
            myCommand = new SqlCommand(commandString, myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxFR.Checked && checkBoxTO.Checked && txtAmount.Text != "" && branchType.SelectedIndex!=0 )
                {
                    if (txtFullNameTO.Text != txtFullnameFR.Text)
                    {
                        if (FRbalance == 0 || decimal.Parse(txtAmount.Text) > FRbalance )
                        {
                        MessageBox.Show("Account of " + txtFullnameFR.Text + " not enougt money.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        {
                        addAccTOacc();
                        SqlConnection connection = new SqlConnection(conn.connectionString);
                        FRbalance = FRbalance -decimal.Parse(txtAmount.Text);
                        TObalance = TObalance +decimal.Parse(txtAmount.Text);
                        connection.Open();
                        SqlCommand myCommand1 = new SqlCommand("UPDATE accounts SET Balance = CASE Account_No WHEN "+txtAccountNoFR.Text+" THEN "+FRbalance+"  WHEN "+txtAccountNoTO.Text+" THEN "+TObalance+" END WHERE account_no in ("+txtAccountNoFR.Text+", "+txtAccountNoTO.Text+");", connection);
                        myCommand1.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("successfull operation", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        this.accTOaccTableAdapter.Fill(this.bANK_M_SDataSet1.accTOacc);

                        }
                }
                    else
                    {
                        MessageBox.Show("the same accounts cannot send to each other.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                    MessageBox.Show("Empty feilds pls insert information.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AccToAcc_Load(object sender, EventArgs e)
        {
            Dashboard form = new Dashboard();
            lblDate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            this.accTOaccTableAdapter.Fill(this.bANK_M_SDataSet1.accTOacc);

          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
