using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public partial class FormLogin : Form
    {
        private FormCreateAccount formCreateAccount = new FormCreateAccount();
        private List<Person> users = new List<Person>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Hide wrong password label
            lblWrongPassword.Text = "";

            // Disable forgot password button
            btnForgotPassword.Enabled = false;
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            // Make this form accessible from formCreateAccount
            formCreateAccount.formLogin = this;

            // Show account creation form
            formCreateAccount.Show();

            // Disable user interaction of this form
            this.Enabled = false;
        }

        public void ShowAndStoreNewUserInformation(string user, string pass)
        {
            // Create new person & store it in userList
            Person newUser = new Person(user, pass);
            users.Add(newUser);

            // Show new information in textboxes
            txtUsernameTextBox.Text = user;
            txtPasswordTextBox.Text = pass;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            // Compare the typed information with stored information
            bool authenticationSuccessful = false;
            foreach (Person user in users)
            {

                if (user.username == txtUsernameTextBox.Text && user.password == txtPasswordTextBox.Text)
                {
                    authenticationSuccessful = true;

                    // Welcome the user
                    MessageBox.Show("Welcome " + user.username);
                    break;
                }
            }

            // If authentication occured an error
            if (!authenticationSuccessful)
            {
                MessageBox.Show("Wrong username or password,\nconsider creating a new account!");
            }
        }
    }
}
