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
    public partial class FormCreateAccount : Form
    {
        public FormLogin formLogin;
        private string username;
        private string password;

        public FormCreateAccount()
        {
            InitializeComponent();
        }

        private void FormCreateAccount_Load(object sender, EventArgs e)
        {
            // Change label textColors to red
            lblAddInformationOne.ForeColor = Color.Red;
            lblAddInformationTwo.ForeColor = Color.Red;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            // Close this form without doing anything with its data
            this.Close();
            formLogin.BringToFront();

            // Enable user interaction for login form
            formLogin.Enabled = true;
        }

        private void FormCreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Enable user interaction for login form
            formLogin.Enabled = true;
        }

        private void TxtCreateUsername_TextChanged(object sender, EventArgs e)
        {
            username = txtCreateUsername.Text;
        }

        private void TxtCreatePassword_TextChanged(object sender, EventArgs e)
        {
            password = txtCreatePassword.Text;

            // Check if the password has 6 or more characters
            if (password.Length >= 6)
            {
                // Change label textColor to greed
                lblAddInformationOne.ForeColor = Color.Green;

            }
            else
            {
                // Change label textColor to red
                lblAddInformationOne.ForeColor = Color.Red;
            }

            // Check if the password has at least one capital character
            if (password.Any(c => char.IsUpper(c)))
            {
                // Change label textColor to greed
                lblAddInformationTwo.ForeColor = Color.Green;
            }
            else
            {
                // Change label textColor to red
                lblAddInformationTwo.ForeColor = Color.Red;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            // Check if password is valid
            if (lblAddInformationOne.ForeColor == Color.Green && lblAddInformationTwo.ForeColor == Color.Green)
            {
                // Close this form and enable login form
                this.Close();
                formLogin.BringToFront();

                formLogin.Enabled = true;

                // Store new user information
                // Show username und password in textboxes of login form
                formLogin.ShowAndStoreNewUserInformation(username, password);
            }
            else
            {
                // Password is not valid
                MessageBox.Show("Password is invalid!\nPlease try a different one..");
            }
        }

        
    }
}
