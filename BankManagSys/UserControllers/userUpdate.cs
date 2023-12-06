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
    public partial class userUpdate : UserControl
    {
        public userUpdate()
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
    
   

    private void userUpdate_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.bANK_M_SDataSet1.users);
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
                    commandString = "select * from users where ID = " + txtsearch.Text + ";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    //check if some thing is found
                    if (myDataReader.Read())
                    {
                        txtID.Text = myDataReader[0].ToString();
                        txtFullname.Text = myDataReader[1].ToString();
                        txtUserName.Text = myDataReader[2].ToString();
                        GenderType.SelectedIndex = (myDataReader[3].ToString().Equals("MALE") ? cmUserType.SelectedIndex = 1 : cmUserType.SelectedIndex = 2);
                        txtPassword.Text = myDataReader[4].ToString();
                        cmUserType.SelectedIndex = (myDataReader[5].ToString().Equals("ADMIN")? cmUserType.SelectedIndex=1:cmUserType.SelectedIndex=2);
                        txtSecQue.Text = myDataReader[6].ToString();
                        txtSecAns.Text = myDataReader[7].ToString();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //check if empty
                if (txtID.Text != "" || txtFullname.Text != "" || txtUserName.Text != "" || GenderType.SelectedIndex ==0|| cmUserType.SelectedIndex != 0 || txtPassword.Text != "" ||  txtSecQue.Text != "" || txtSecAns.Text != "")
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "update users set ID = "+txtID.Text+",FullName = '"+txtFullname.Text+"',UserName = '"+txtUserName.Text+"',Gender = '"+GenderType.Text+"',Password= "+txtPassword.Text+",UserType = '"+cmUserType.Text+"',SecreteQue ='"+txtSecQue.Text+"',SecreteAns = '"+txtSecAns.Text+"' where ID = "+txtID.Text+";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    this.usersTableAdapter.Fill(this.bANK_M_SDataSet1.users);
                    MessageBox.Show("successfull updated the user ", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFullname.Text = "";
                    txtID.Text = "";
                    txtUserName.Text = "";
                    cmUserType.SelectedIndex = 0;
                    txtPassword.Text = "";
                    txtSecAns.Text = "";
                    txtSecQue.Text = "";
                    txtsearch.Clear();
                    GenderType.SelectedIndex = 0;
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

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "";
            txtID.Text = "";
            txtUserName.Text = "";
            cmUserType.SelectedIndex = 0;
            txtPassword.Text = "";
            txtSecAns.Text = "";
            txtSecQue.Text = "";
            GenderType.SelectedIndex = 0;
            txtsearch.Clear();
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
