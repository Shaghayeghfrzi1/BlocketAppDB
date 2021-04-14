using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlamningsuppgift1
{
    public partial class frmLogin : Form
    {
        User user;
        public frmLogin()
        {
            InitializeComponent();
        }
        string registerUser = "";
        int registerUserNumber = 0;
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            user = new User(txtUsername.Text, txtPassword.Text);
            bool isRegister = user.GetUser( ref registerUser, ref registerUserNumber);
            if (isRegister)
            {
                MessageBox.Show(txtUsername.Text + ", du är inloggad.");
                frmBlocketLoggedIn frmBlocketLoggedIn = new frmBlocketLoggedIn(registerUser, registerUserNumber);
                frmBlocketLoggedIn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(txtUsername.Text + ", försök igen!");
            }

        }

        private void cmdCreateUser_Click(object sender, EventArgs e)
        {
            user = new User();
            bool createUser = user.CreateUser(txtUsername.Text, txtPassword.Text);
            if (createUser)
                MessageBox.Show("Din konto har skapat");
            
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmBlocket fStart = new frmBlocket();
            fStart.Show();
            this.Hide();
        }
    }
}
