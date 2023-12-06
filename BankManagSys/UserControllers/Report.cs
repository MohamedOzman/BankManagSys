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
using BankManagSys.Properties;
using System.Web.Util;

namespace BankManagSys.UserControllers
{
    public partial class Report : UserControl
    {
        public Report()
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
        private void userIR(string command)
        {
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.ReportSource = null;
            myConnection = new SqlConnection(conn.connectionString);
            myConnection.Open();
            commandString = command;
            myCommand = new SqlCommand(commandString, myConnection);
            myDataAdapter = new SqlDataAdapter(myCommand);
            myDataTable.Clear();
            myDataAdapter.Fill(myDataTable);
            userReports userReportG = new userReports();
            userReportG.SetDataSource(myDataTable);
            crystalReportViewer1.ReportSource = userReportG;
            myConnection.Close();
        }
        private void TransIR()
        {
            if (txtSearch.Text != "")
            {
                crystalReportViewer1.RefreshReport();
                crystalReportViewer1.ReportSource = null;
                myConnection = new SqlConnection(conn.connectionString);
                myConnection.Open();
                commandString = "accTransAcc " + txtSearch.Text + ";";
                myCommand = new SqlCommand(commandString, myConnection);
                myDataAdapter = new SqlDataAdapter(myCommand);
                myDataTable.Clear();
                myDataAdapter.Fill(myDataTable);
                TransactionsAccounts transactions = new TransactionsAccounts();
                transactions.SetDataSource(myDataTable);
                crystalReportViewer1.ReportSource = transactions;
                myConnection.Close();
            }
            else
                MessageBox.Show("Transaction Report need AccountNO to Search.....", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        private void accountIR()
        {
            if (txtSearch.Text != "")
            {
                crystalReportViewer1.RefreshReport();
                crystalReportViewer1.ReportSource = null;
                myConnection = new SqlConnection(conn.connectionString);
                myConnection.Open();
                commandString = "exec accountIR " + txtSearch.Text + ";";
                myCommand = new SqlCommand(commandString, myConnection);
                myDataAdapter = new SqlDataAdapter(myCommand);
                myDataTable.Clear();
                myDataAdapter.Fill(myDataTable);
                accountIR accountReport = new accountIR();
                
                accountReport.SetDataSource(myDataTable);
                crystalReportViewer1.ReportSource = accountReport;
                myConnection.Close();
            }
           


        }

        private void userGeneRep1_InitReport(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(cmbReport.SelectedIndex == 0)
            {
                MessageBox.Show("There is no selection to Report.....","Notification",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if(cmbReport.SelectedIndex == 1) 
            {
                if (txtSearch.Text == "")
                {
                    userIR("select * from users;");
                }
                else
                {
                    userIR("select * from users where ID = " + txtSearch.Text + " ;");
                }
            }
            if (cmbReport.SelectedIndex == 2)
                TransIR();
            if (cmbReport.SelectedIndex == 3)
            {
                if (txtSearch.Text == "")
                {
                    AccountReport accountReport = new AccountReport();
                    crystalReportViewer1.Refresh();
                    crystalReportViewer1.ReportSource = null;
                    crystalReportViewer1.ReportSource = accountReport;
                }
                else
                    accountIR();

            }
        }
    }
}
