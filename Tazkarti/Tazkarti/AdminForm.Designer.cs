using System;
using System.Windows.Forms;

namespace Tazkarti
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_adminMenu = new System.Windows.Forms.Button();
            this.pnl_adminSidebar = new System.Windows.Forms.Panel();
            this.lbl_adminLogout = new System.Windows.Forms.Label();
            this.lbl_adminProfile = new System.Windows.Forms.Label();
            this.lbl_adminPassengers = new System.Windows.Forms.Label();
            this.lbl_adminAirplanes = new System.Windows.Forms.Label();
            this.lbl_adminTickets = new System.Windows.Forms.Label();
            this.lbl_adminFlights = new System.Windows.Forms.Label();
            this.pnl_adminMenu = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_adminSidebar.SuspendLayout();
            this.pnl_adminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_adminMenu
            // 
            this.btn_adminMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_adminMenu.Image = global::Tazkarti.Properties.Resources.menu3;
            this.btn_adminMenu.Location = new System.Drawing.Point(0, 0);
            this.btn_adminMenu.Name = "btn_adminMenu";
            this.btn_adminMenu.Size = new System.Drawing.Size(40, 44);
            this.btn_adminMenu.TabIndex = 0;
            this.btn_adminMenu.UseVisualStyleBackColor = true;
            this.btn_adminMenu.Click += new System.EventHandler(this.btn_adminMenu_Click);
            // 
            // pnl_adminSidebar
            // 
            this.pnl_adminSidebar.BackColor = System.Drawing.Color.White;
            this.pnl_adminSidebar.Controls.Add(this.lbl_adminLogout);
            this.pnl_adminSidebar.Controls.Add(this.lbl_adminProfile);
            this.pnl_adminSidebar.Controls.Add(this.lbl_adminPassengers);
            this.pnl_adminSidebar.Controls.Add(this.lbl_adminAirplanes);
            this.pnl_adminSidebar.Controls.Add(this.lbl_adminTickets);
            this.pnl_adminSidebar.Controls.Add(this.lbl_adminFlights);
            this.pnl_adminSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_adminSidebar.Location = new System.Drawing.Point(40, 0);
            this.pnl_adminSidebar.Name = "pnl_adminSidebar";
            this.pnl_adminSidebar.Size = new System.Drawing.Size(200, 609);
            this.pnl_adminSidebar.TabIndex = 4;
            // 
            // lbl_adminLogout
            // 
            this.lbl_adminLogout.BackColor = System.Drawing.Color.White;
            this.lbl_adminLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_adminLogout.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_adminLogout.Location = new System.Drawing.Point(0, 205);
            this.lbl_adminLogout.Name = "lbl_adminLogout";
            this.lbl_adminLogout.Size = new System.Drawing.Size(200, 41);
            this.lbl_adminLogout.TabIndex = 4;
            this.lbl_adminLogout.Text = "LOGOUT";
            this.lbl_adminLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_adminLogout.Click += new System.EventHandler(this.lbl_adminLogout_Click);
            this.lbl_adminLogout.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_adminProfile
            // 
            this.lbl_adminProfile.BackColor = System.Drawing.Color.White;
            this.lbl_adminProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_adminProfile.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminProfile.Location = new System.Drawing.Point(0, 164);
            this.lbl_adminProfile.Name = "lbl_adminProfile";
            this.lbl_adminProfile.Size = new System.Drawing.Size(200, 41);
            this.lbl_adminProfile.TabIndex = 5;
            this.lbl_adminProfile.Text = "PROFILE";
            this.lbl_adminProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_adminProfile.Click += new System.EventHandler(this.lbl_adminProfile_Click);
            this.lbl_adminProfile.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_adminPassengers
            // 
            this.lbl_adminPassengers.BackColor = System.Drawing.Color.White;
            this.lbl_adminPassengers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_adminPassengers.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminPassengers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_adminPassengers.Location = new System.Drawing.Point(0, 123);
            this.lbl_adminPassengers.Name = "lbl_adminPassengers";
            this.lbl_adminPassengers.Size = new System.Drawing.Size(200, 41);
            this.lbl_adminPassengers.TabIndex = 6;
            this.lbl_adminPassengers.Text = "PASSENGERS";
            this.lbl_adminPassengers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_adminPassengers.Click += new System.EventHandler(this.lbl_adminPassengers_Click);
            this.lbl_adminPassengers.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_adminAirplanes
            // 
            this.lbl_adminAirplanes.BackColor = System.Drawing.Color.White;
            this.lbl_adminAirplanes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_adminAirplanes.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminAirplanes.Location = new System.Drawing.Point(0, 82);
            this.lbl_adminAirplanes.Name = "lbl_adminAirplanes";
            this.lbl_adminAirplanes.Size = new System.Drawing.Size(200, 41);
            this.lbl_adminAirplanes.TabIndex = 3;
            this.lbl_adminAirplanes.Text = "AIRPLANES";
            this.lbl_adminAirplanes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_adminAirplanes.Click += new System.EventHandler(this.lbl_adminAirplanes_Click);
            this.lbl_adminAirplanes.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_adminTickets
            // 
            this.lbl_adminTickets.BackColor = System.Drawing.Color.White;
            this.lbl_adminTickets.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_adminTickets.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminTickets.Location = new System.Drawing.Point(0, 41);
            this.lbl_adminTickets.Name = "lbl_adminTickets";
            this.lbl_adminTickets.Size = new System.Drawing.Size(200, 41);
            this.lbl_adminTickets.TabIndex = 2;
            this.lbl_adminTickets.Text = "TICKETS";
            this.lbl_adminTickets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_adminTickets.Click += new System.EventHandler(this.lbl_adminTickets_Click);
            this.lbl_adminTickets.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // lbl_adminFlights
            // 
            this.lbl_adminFlights.BackColor = System.Drawing.Color.White;
            this.lbl_adminFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_adminFlights.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminFlights.Location = new System.Drawing.Point(0, 0);
            this.lbl_adminFlights.Name = "lbl_adminFlights";
            this.lbl_adminFlights.Size = new System.Drawing.Size(200, 41);
            this.lbl_adminFlights.TabIndex = 1;
            this.lbl_adminFlights.Text = "FLIGHTS";
            this.lbl_adminFlights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_adminFlights.Click += new System.EventHandler(this.lbl_adminFlights_Click);
            this.lbl_adminFlights.MouseHover += new System.EventHandler(this.lbl_MouseHover);
            // 
            // pnl_adminMenu
            // 
            this.pnl_adminMenu.BackColor = System.Drawing.Color.White;
            this.pnl_adminMenu.Controls.Add(this.btn_adminMenu);
            this.pnl_adminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_adminMenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_adminMenu.Name = "pnl_adminMenu";
            this.pnl_adminMenu.Size = new System.Drawing.Size(40, 609);
            this.pnl_adminMenu.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tazkarti.Properties.Resources.MW_HE536_airpla_20190225131547_ZG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 609);
            this.Controls.Add(this.pnl_adminSidebar);
            this.Controls.Add(this.pnl_adminMenu);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.pnl_adminSidebar.ResumeLayout(false);
            this.pnl_adminMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_adminMenu;
        private System.Windows.Forms.Panel pnl_adminSidebar;
        private System.Windows.Forms.Label lbl_adminPassengers;
        private System.Windows.Forms.Label lbl_adminAirplanes;
        private System.Windows.Forms.Label lbl_adminTickets;
        private System.Windows.Forms.Label lbl_adminFlights;
        private System.Windows.Forms.Panel pnl_adminMenu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_adminLogout;
        private System.Windows.Forms.Label lbl_adminProfile;
    }
}

