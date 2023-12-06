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
    public partial class accountList : UserControl
    {
        public accountList()
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

        private void accountList_Load(object sender, EventArgs e)
        {
            this.accountsTableAdapter.Fill(this.bANK_M_SDataSet1.accounts);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(conn.connectionString);
            myConnection.Open();
            commandString = "select * from accounts where Account_No like '%"+txtsearch.Text+"%' or FullName like'%"+txtsearch.Text+"%';";
            myCommand = new SqlCommand(commandString, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myCommandBuilder = new SqlCommandBuilder(myDataAdapter);
            myDataTable.Clear();
            myDataAdapter.Fill(myDataTable);
            guna2DataGridView1.DataSource = myDataTable;
            myConnection.Close();
        }
    }
}
