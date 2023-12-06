using BankManagSys.UserControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankManagSys
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();            
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPnl.Controls.Clear();
            mainPnl.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
            Home home = new Home();
            addUserControl(home);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            newUser newUser = new newUser();
            addUserControl(newUser);
            lblForAll.Text = "NEW USER";

        }



        private void mainPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            newAccount newAcc = new newAccount();
            addUserControl(newAcc);
            lblForAll.Text = "NEW ACCOUNT";

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            userList userlis = new userList();
            addUserControl(userlis);
            lblForAll.Text = "USER DETAIL";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            accountList accountlist = new accountList();
            addUserControl(accountlist);
            lblForAll.Text = "ACCOUNT DETAIL";

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            userDelete userDel = new userDelete();
            addUserControl(userDel);
            lblForAll.Text = "USER DELETE";

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            accountDelete accDel = new accountDelete();
            addUserControl(accDel);
            lblForAll.Text = "ACCOUNT DELETE";

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            userUpdate userUpd = new userUpdate();
            addUserControl(userUpd);
            lblForAll.Text = "USER UPDATE";

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            accountUpdate accUpdate = new accountUpdate();
            addUserControl(accUpdate);
            lblForAll.Text = "ACCOUNT UPDATE";

        }

        private void btnWith_Click(object sender, EventArgs e)
        {
            Withdrawl withdrawl = new Withdrawl();
            addUserControl(withdrawl);
            lblForAll.Text = "WITHDRAWAL";


        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            addUserControl(deposit);
            lblForAll.Text = "DEPOSIT";

        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            Transactions transction = new Transactions();
            addUserControl(transction);
            lblForAll.Text = "TRANSACTION";

        }

        private void btnAccToAcc_Click(object sender, EventArgs e)
        {
            AccToAcc acctoacc = new AccToAcc();
            addUserControl(acctoacc);
            lblForAll.Text = "ACCOUNT TO ACCOUNT";

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            addUserControl(report);
            lblForAll.Text = "REPORT";

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("winword.exe");
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Taskmgr.exe");
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("NOTePAD.exe");
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("EXCEL.exe");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            addUserControl(home);
            lblForAll.Text = "DASHBOARD";

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Log = new Form1();
            Log.ShowDialog();
            this.Close();
        }
    }
}
