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
    public partial class userList : UserControl
    {
        public userList()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        SqlConnection myConnection;
        SqlCommand myCommand;
        SqlDataAdapter myDataAdapter;
        DataTable myDataTable  = new DataTable();
        SqlDataReader myDataReader;
        SqlCommandBuilder myCommandBuilder;
        string commandString;
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userList_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.bANK_M_SDataSet1.users);


           
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
                  
            myConnection = new SqlConnection(conn.connectionString);
            myConnection.Open();
            commandString = "select * from users where username like '%" + txtsearch.Text + "%' or ID like'%" + txtsearch.Text + "%';";
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
