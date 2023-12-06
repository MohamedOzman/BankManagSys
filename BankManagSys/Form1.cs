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

namespace BankManagSys
{
    public partial class Form1 : Form
    {

        Connection conn = new Connection();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataReader myDataReader;
        string commandString;
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgetPassword forgetpass = new ForgetPassword();
            forgetpass.ShowDialog();
            this.Close();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
              
                if (username == "" || password=="")
                {
                    MessageBox.Show("empty feilds", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "select * from users where UserName ='"+username+"' and Password ='"+password+"';";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    if (myDataReader.Read())
                    {
                        this.Hide();
                        Dashboard dashboard = new Dashboard();
                        dashboard.nameUser.Text = myDataReader[2].ToString();
                        dashboard.ShowDialog();
                        this.Close();
                        
                       
                    }
                    else
                    {
                        MessageBox.Show("Sorry wrong password or username", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    myConnection.Close();
                }

           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
