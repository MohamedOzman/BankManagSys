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
    public partial class accountDelete : UserControl
    {
        public accountDelete()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataReader myDataReader;
        string commandString;


        private void accountDelete_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.bANK_M_SDataSet1.accounts);
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
                        //check if you want to delete yes /no
                        DialogResult dr = MessageBox.Show("Are you want to delete " + myDataReader[0].ToString() + " account permently", "Delete Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            myConnection.Close();
                            myConnection.Open();
                            SqlCommand myCommand2 = new SqlCommand("delete from accounts where Account_No =" + txtsearch.Text + ";", myConnection);
                            myCommand2.ExecuteNonQuery();
                            MessageBox.Show("congraltion you deleted the account.....", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            myConnection.Close();
                            this.accountsTableAdapter.Fill(this.bANK_M_SDataSet1.accounts);

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
    }
}
