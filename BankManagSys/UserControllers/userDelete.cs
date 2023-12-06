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
    public partial class userDelete : UserControl
    {
        public userDelete()
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

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndele_Click(object sender, EventArgs e)
        {
            try
            {
                //check if empty
                if(txtsearch.Text != "")
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "select * from users where ID = "+int.Parse(txtsearch.Text)+";";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myDataReader = myCommand.ExecuteReader();
                    //check if some thing is found
                    if (myDataReader.Read())
                    {
                        //check if you want to delete yes /no
                        DialogResult dr = MessageBox.Show("Are you want to delete "+myDataReader[1].ToString()+" user permently", "Delete Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(dr == DialogResult.Yes)
                        {
                            myConnection.Close();
                            myConnection.Open();
                            SqlCommand myCommand2 = new SqlCommand("delete from users where ID =" + txtsearch.Text + ";", myConnection);
                            myCommand2.ExecuteNonQuery();
                            MessageBox.Show("congraltion you deleted the user.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            myConnection.Close();
                            this.usersTableAdapter.Fill(this.bANK_M_SDataSet1.users);

                        }

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

        private void userDelete_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.bANK_M_SDataSet1.users);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
