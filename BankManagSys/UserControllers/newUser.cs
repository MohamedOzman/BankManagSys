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
    public partial class newUser : UserControl
    {

        Connection conn = new Connection();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataReader myDataReader;
        string commandString;
        public newUser()
        {
            InitializeComponent();
        }

        private void newUser_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.bANK_M_SDataSet1.users);

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegUser_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text;
                string fullname = txtFullname.Text;
                string username = txtUserName.Text;
                string userType = CmbuserType.Text;
                string password = txtPassword.Text;
                string secretQuestion = txtSecQue.Text;
                string secretAnswer = txtSecAns.Text;
                if(id == "" || fullname == "" || username==""|| GenderType.SelectedIndex ==0 || CmbuserType.SelectedIndex ==0 || password ==""|| txtConPass.Text ==""|| secretQuestion == "" || secretAnswer == "")
                {
                    MessageBox.Show("empty feilds", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtPassword.Text.Equals(txtConPass.Text))
                    {
                        myConnection = new SqlConnection(conn.connectionString);
                        myConnection.Open();
                        commandString = "insert into users values('" + id + "','" + fullname + "','" + username + "','"+GenderType.Text+ "'," + password + ",'" + userType + "','" + secretQuestion + "','" + secretAnswer + "',GETDATE()); ";
                        myCommand = new SqlCommand(commandString, myConnection);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("successfull", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear
                        txtFullname.Text = "";
                        txtID.Text = "";
                        txtUserName.Text = "";
                        GenderType.SelectedIndex = 0;
                        CmbuserType.SelectedIndex = 0;
                        txtPassword.Text = "";
                        txtConPass.Text = "";
                        txtSecAns.Text = "";
                        txtSecQue.Text = "";
                        this.usersTableAdapter.Fill(this.bANK_M_SDataSet1.users);

                    }
                    else
                        MessageBox.Show("passwords not match", "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            CmbuserType.SelectedIndex = 0;
            txtPassword.Text = "";
            txtConPass.Text = "";
            txtSecAns.Text = "";
            txtSecQue.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
