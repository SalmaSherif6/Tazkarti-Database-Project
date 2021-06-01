using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tazkarti
{
    public partial class LoginForm : Form
    {
        public string username;
        Person person;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnl_login.BackColor = Color.FromArgb(100, 0, 0, 0);
            lbl_loginUsername.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_loginPassword.BackColor = Color.FromArgb(0, 0, 0, 0);

            pnl_register.BackColor = Color.FromArgb(100, 0, 0, 0);
            lbl_regEmail.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regFName.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regLName.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regUsername.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regPassword.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regConPassword.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regSSN.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regCredit.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_regNumber.BackColor = Color.FromArgb(0, 0, 0, 0);

            txt_loginMob2.Hide();
            pnl_register.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool isAdmin = false;
            string uname = txt_loginUsername.Text.ToLower(); //USERNAME IS IN LOWERCASE HERE AND IN DATABASE...
            //Radwa
            //check username and password from database
            //check if admin return isAdmin = true
            person = new Person(uname, txt_loginPassword.Text, isAdmin);
            gotoUserForm();
        }

        private void btn_loginAddMob_Click(object sender, EventArgs e)
        {
            string mobileNumber = txt_loginMob1.Text;
            if (mobileNumber != "" && Regex.IsMatch(mobileNumber, "\\A[0-9]{11}\\z") && mobileNumber[0] == '0' && mobileNumber[1] == '1')
                txt_loginMob2.Show();
            else
                MessageBox.Show("You have entered the Mobile Number in incorrect format. Please, Try Again!.", "Mobile Number ERROR");
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            pnl_login.Hide();
            pnl_register.Show();
        }

        private void btn_registerReg_Click(object sender, EventArgs e)
        {
            //Radwa
            //check registeration
            string uname = txt_regUsername.Text.ToLower();

            //Check the email
            string email = txt_regEmail.Text.ToLower();
            var addr = new System.Net.Mail.MailAddress(email);
            if (email != addr.Address)
                MessageBox.Show("You have entered the Email Address in incorrect format. Please, Try Again!.", "Email Address ERROR");

            //Check the password
            if(txt_regPassword.Text != txt_regConPassword.Text || txt_regPassword.Text=="")
                MessageBox.Show("You have entered wrong Passwords. Please, Try Again!.", "Password ERROR");

            //Check the SSN
            string ssn = txt_regSSN.Text;
            if(!(Regex.IsMatch(ssn, "\\A[0-9]{14}\\z")))
                MessageBox.Show("You have entered the SSN in incorrect format. Please, Try Again!.", "SSN ERROR");

            //Check the Credit Card Number
            string credit = txt_regCredit.Text;
            if (!(Regex.IsMatch(ssn, "\\A[0-9]{14}\\z")))
                MessageBox.Show("You have entered the Credit Card Number in incorrect format. Please, Try Again!.", "Credit Card Number ERROR");

            //Check the mobile number 2
            string mobileNumber = txt_loginMob2.Text;
            if (mobileNumber == "" || !(Regex.IsMatch(mobileNumber, "\\A[0-9]{11}\\z")) || mobileNumber[0] != '0' || mobileNumber[1] != '1')
                MessageBox.Show("You have entered the second Mobile Number in incorrect format. Please, Try Again!.", "Mobile Number ERROR");

            gotoUserForm();
        }

        private void gotoUserForm()
        {
            this.Hide();
            UserForm userForm = new UserForm(person.username);
            userForm.ShowDialog();
            this.Close();
        }
    }
}
