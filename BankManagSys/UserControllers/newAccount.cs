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
    public partial class newAccount : UserControl
    {

        Connection conn = new Connection();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataReader myDataReader;
        string commandString;
        public newAccount()
        {
            
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegsiter_Click(object sender, EventArgs e)
        {
            dateOFbirth.Format = DateTimePickerFormat.Custom;
            dateOFbirth.CustomFormat = "dd-MM-yyyy";
            try
            {
                string fullname = txtFullname.Text;
                string accountNo = txtAccountNo.Text;
                string gender = GenderType.Text;
                string phoneNo = txtPhoneNo.Text;
                string dob = dateOFbirth.Text;
                string address = txtAddress.Text;
                string district = txtDistrict.Text;
                if (fullname == "" || accountNo == "" || phoneNo == "" || address == "" || district == "" || GenderType.SelectedIndex ==0)
                {
                    MessageBox.Show("empty feilds", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    myConnection = new SqlConnection(conn.connectionString);
                    myConnection.Open();
                    commandString = "insert into accounts values('"+fullname+"',"+accountNo+ ",GETDATE()," + phoneNo+",'"+dob+"','"+address+"','"+district+ "','" + gender + "',0);";
                    myCommand = new SqlCommand(commandString, myConnection);
                    myCommand.ExecuteNonQuery();
                    myConnection.Close();
                    //clear
                    txtFullname.Text = "";
                    txtAccountNo.Text = "";
                    txtPhoneNo.Text = "";
                    GenderType.SelectedIndex = 0;
                    txtAddress.Text = "";
                    txtDistrict.Text = "";
                    dateOFbirth.Text = "";
                    MessageBox.Show("successfull", "notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.accountsTableAdapter.Fill(this.bANK_M_SDataSet1.accounts);

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void newAccount_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.bANK_M_SDataSet1.accounts);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullname.Text = "";
            txtAccountNo.Text = "";
            txtPhoneNo.Text = "";
            GenderType.SelectedIndex = 0;
            txtAddress.Text = "";
            txtDistrict.Text = "";
            dateOFbirth.Text = "";

        }
    }
}
