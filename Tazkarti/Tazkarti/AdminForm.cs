using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tazkarti
{
    public partial class AdminForm : Form
    {
        int PW; //Side bar Width
        bool hided; //Side bar status
        string username;

        public AdminForm(string username)
        {
            InitializeComponent();
            PW = pnl_adminSidebar.Width;
            hided = true;
            pnl_adminSidebar.Width = 0;
            this.username = username;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //Make there background transparent
            pnl_adminSidebar.BackColor = Color.FromArgb(20, 0, 0, 0);
            pnl_adminMenu.BackColor = Color.FromArgb(0, 0, 0, 0);
            buttonChangeAll();
        }

        private void buttonChange(Label lbl)
        {
            buttonChangeAll();
            lbl.BackColor = Color.FromArgb(20, 0, 0, 0);
        }

        private void buttonChangeAll()
        {
            lbl_adminFlights.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminTickets.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminAirplanes.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminPassengers.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminLogout.BackColor = Color.FromArgb(0, 0, 0, 0);
            lbl_adminProfile.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Side bar Animation
            if (hided)
            {
                pnl_adminSidebar.Width += 50;
                if (pnl_adminSidebar.Width >= PW)
                {
                    timer1.Stop();
                    hided = false;
                    this.Refresh();
                }
            }
            else
            {
                pnl_adminSidebar.Width -= 50;
                if (pnl_adminSidebar.Width <= 0)
                {
                    timer1.Stop();
                    hided = true;
                    this.Refresh();
                }
            }
        }

        private void btn_adminMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void lbl_adminTickets_Click(object sender, EventArgs e)
        {
            //HEBA
            this.Hide();
            AdminTicket adminTicket = new AdminTicket();
            adminTicket.ShowDialog();
            this.Close();
        }

        private void lbl_adminFlights_Click(object sender, EventArgs e)
        {
            //TOKA
        }

        private void lbl_adminAirplanes_Click(object sender, EventArgs e)
        {
            //RADWA
        }

        private void lbl_adminPassengers_Click(object sender, EventArgs e)
        {
            //SALMA
        }

        private void lbl_adminProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProfileForm profileForm = new ProfileForm(username);
            profileForm.ShowDialog();
            this.Close();
        }

        private void lbl_adminLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm(username);
            userForm.ShowDialog();
            this.Close();
        }

        private void lbl_MouseHover(object sender, EventArgs e)
        {
            buttonChangeAll();
            buttonChange((Label)sender);
        }
    }
}
