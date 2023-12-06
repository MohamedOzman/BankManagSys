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
    public partial class ForgetPassword : Form
    {
        Connection conn = new Connection();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataReader myDataReader;
        string commandString;

        public ForgetPassword()
        {
            InitializeComponent();
        }

        

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.ShowDialog();
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

      

       

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {

            try
            {

                if (txtID.Text != "")
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "select SecreteQue,UserName from users where ID =" + txtID.Text + ";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    if (myDataReader.Read())
                    {
                        txtRecQue.Text = myDataReader[0].ToString();
                        txtUsername.Text = myDataReader[1].ToString();
                    }
                    else
                    {
                        MessageBox.Show("not found the id please retry....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    myConnection.Close();

                }
                else
                    MessageBox.Show("ID is empty", "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCheckAns_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (txtID.Text == "" || txtUsername.Text == "" || txtRecQue.Text == "" || txtCorAns.Text == "")
                {
                    MessageBox.Show("some feilds may be empty....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "select password from users where SecreteAns = '"+ txtCorAns.Text+"';";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    if (myDataReader.Read())
                    {
                        MessageBox.Show("Create a new password....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GBoxNewPass.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Answer is wrong....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                myConnection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNewPass.Text != ""|| txtConfPass.Text != "")
                {
                    if (txtNewPass.Text.Equals(txtConfPass.Text))
                    {
                        myConnection = new SqlConnection(conn.connectionString);
                        myConnection.Open();
                        commandString = "update users set Password = '" + txtNewPass.Text + "' where ID = '" + txtID.Text + "';";
                        myCommand = new SqlCommand(commandString, myConnection);
                        myCommand.ExecuteNonQuery();
                        myConnection.Close();
                        MessageBox.Show("successfull changed the password", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GBoxNewPass.Visible = false;
                    }
                    else
                        MessageBox.Show("passwords not match", "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }else
                    MessageBox.Show("some feilds may be empty....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
