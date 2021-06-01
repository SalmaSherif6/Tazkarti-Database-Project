namespace Tazkarti
{
    partial class LoginForm
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
            this.lbl_loginPassword = new System.Windows.Forms.Label();
            this.lbl_loginUsername = new System.Windows.Forms.Label();
            this.txt_loginUsername = new System.Windows.Forms.TextBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_loginPassword = new System.Windows.Forms.TextBox();
            this.pnl_register = new System.Windows.Forms.Panel();
            this.btn_loginAddMob = new System.Windows.Forms.Button();
            this.txt_loginMob2 = new System.Windows.Forms.TextBox();
            this.txt_loginMob1 = new System.Windows.Forms.TextBox();
            this.lbl_regNumber = new System.Windows.Forms.Label();
            this.txt_regCredit = new System.Windows.Forms.TextBox();
            this.lbl_regCredit = new System.Windows.Forms.Label();
            this.txt_regSSN = new System.Windows.Forms.TextBox();
            this.lbl_regSSN = new System.Windows.Forms.Label();
            this.txt_regUsername = new System.Windows.Forms.TextBox();
            this.lbl_regUsername = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lbl_regFName = new System.Windows.Forms.Label();
            this.lbl_regLName = new System.Windows.Forms.Label();
            this.txt_regConPassword = new System.Windows.Forms.TextBox();
            this.lbl_regConPassword = new System.Windows.Forms.Label();
            this.btn_registerReg = new System.Windows.Forms.Button();
            this.txt_regPassword = new System.Windows.Forms.TextBox();
            this.txt_regEmail = new System.Windows.Forms.TextBox();
            this.lbl_regEmail = new System.Windows.Forms.Label();
            this.lbl_regPassword = new System.Windows.Forms.Label();
            this.pnl_login.SuspendLayout();
            this.pnl_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_loginPassword
            // 
            this.lbl_loginPassword.AutoSize = true;
            this.lbl_loginPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_loginPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginPassword.Location = new System.Drawing.Point(29, 134);
            this.lbl_loginPassword.Name = "lbl_loginPassword";
            this.lbl_loginPassword.Size = new System.Drawing.Size(81, 23);
            this.lbl_loginPassword.TabIndex = 11;
            this.lbl_loginPassword.Text = "Password:";
            // 
            // lbl_loginUsername
            // 
            this.lbl_loginUsername.AutoSize = true;
            this.lbl_loginUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_loginUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginUsername.Location = new System.Drawing.Point(29, 90);
            this.lbl_loginUsername.Name = "lbl_loginUsername";
            this.lbl_loginUsername.Size = new System.Drawing.Size(85, 23);
            this.lbl_loginUsername.TabIndex = 9;
            this.lbl_loginUsername.Text = "Username:";
            // 
            // txt_loginUsername
            // 
            this.txt_loginUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginUsername.Location = new System.Drawing.Point(120, 90);
            this.txt_loginUsername.Multiline = true;
            this.txt_loginUsername.Name = "txt_loginUsername";
            this.txt_loginUsername.Size = new System.Drawing.Size(210, 31);
            this.txt_loginUsername.TabIndex = 12;
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.btn_Register);
            this.pnl_login.Controls.Add(this.btn_Login);
            this.pnl_login.Controls.Add(this.txt_loginPassword);
            this.pnl_login.Controls.Add(this.txt_loginUsername);
            this.pnl_login.Controls.Add(this.lbl_loginUsername);
            this.pnl_login.Controls.Add(this.lbl_loginPassword);
            this.pnl_login.Location = new System.Drawing.Point(273, 111);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(349, 383);
            this.pnl_login.TabIndex = 13;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_Register.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(33, 253);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(278, 46);
            this.btn_Register.TabIndex = 15;
            this.btn_Register.Text = "REGISTER";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(97)))));
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Login.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(33, 201);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(278, 46);
            this.btn_Login.TabIndex = 14;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_loginPassword
            // 
            this.txt_loginPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginPassword.Location = new System.Drawing.Point(120, 130);
            this.txt_loginPassword.Multiline = true;
            this.txt_loginPassword.Name = "txt_loginPassword";
            this.txt_loginPassword.Size = new System.Drawing.Size(210, 31);
            this.txt_loginPassword.TabIndex = 13;
            // 
            // pnl_register
            // 
            this.pnl_register.Controls.Add(this.btn_loginAddMob);
            this.pnl_register.Controls.Add(this.txt_loginMob2);
            this.pnl_register.Controls.Add(this.txt_loginMob1);
            this.pnl_register.Controls.Add(this.lbl_regNumber);
            this.pnl_register.Controls.Add(this.txt_regCredit);
            this.pnl_register.Controls.Add(this.lbl_regCredit);
            this.pnl_register.Controls.Add(this.txt_regSSN);
            this.pnl_register.Controls.Add(this.lbl_regSSN);
            this.pnl_register.Controls.Add(this.txt_regUsername);
            this.pnl_register.Controls.Add(this.lbl_regUsername);
            this.pnl_register.Controls.Add(this.textBox7);
            this.pnl_register.Controls.Add(this.textBox8);
            this.pnl_register.Controls.Add(this.lbl_regFName);
            this.pnl_register.Controls.Add(this.lbl_regLName);
            this.pnl_register.Controls.Add(this.txt_regConPassword);
            this.pnl_register.Controls.Add(this.lbl_regConPassword);
            this.pnl_register.Controls.Add(this.btn_registerReg);
            this.pnl_register.Controls.Add(this.txt_regPassword);
            this.pnl_register.Controls.Add(this.txt_regEmail);
            this.pnl_register.Controls.Add(this.lbl_regEmail);
            this.pnl_register.Controls.Add(this.lbl_regPassword);
            this.pnl_register.Location = new System.Drawing.Point(244, 85);
            this.pnl_register.Name = "pnl_register";
            this.pnl_register.Size = new System.Drawing.Size(427, 459);
            this.pnl_register.TabIndex = 14;
            // 
            // btn_loginAddMob
            // 
            this.btn_loginAddMob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_loginAddMob.Image = global::Tazkarti.Properties.Resources.plus;
            this.btn_loginAddMob.Location = new System.Drawing.Point(383, 340);
            this.btn_loginAddMob.Name = "btn_loginAddMob";
            this.btn_loginAddMob.Size = new System.Drawing.Size(30, 31);
            this.btn_loginAddMob.TabIndex = 37;
            this.btn_loginAddMob.UseVisualStyleBackColor = true;
            this.btn_loginAddMob.Click += new System.EventHandler(this.btn_loginAddMob_Click);
            // 
            // txt_loginMob2
            // 
            this.txt_loginMob2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginMob2.Location = new System.Drawing.Point(172, 373);
            this.txt_loginMob2.Multiline = true;
            this.txt_loginMob2.Name = "txt_loginMob2";
            this.txt_loginMob2.Size = new System.Drawing.Size(205, 31);
            this.txt_loginMob2.TabIndex = 36;
            // 
            // txt_loginMob1
            // 
            this.txt_loginMob1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginMob1.Location = new System.Drawing.Point(172, 340);
            this.txt_loginMob1.Multiline = true;
            this.txt_loginMob1.Name = "txt_loginMob1";
            this.txt_loginMob1.Size = new System.Drawing.Size(205, 31);
            this.txt_loginMob1.TabIndex = 35;
            // 
            // lbl_regNumber
            // 
            this.lbl_regNumber.AutoSize = true;
            this.lbl_regNumber.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regNumber.Location = new System.Drawing.Point(21, 348);
            this.lbl_regNumber.Name = "lbl_regNumber";
            this.lbl_regNumber.Size = new System.Drawing.Size(129, 23);
            this.lbl_regNumber.TabIndex = 34;
            this.lbl_regNumber.Text = "Mobile Number:";
            // 
            // txt_regCredit
            // 
            this.txt_regCredit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regCredit.Location = new System.Drawing.Point(172, 303);
            this.txt_regCredit.Multiline = true;
            this.txt_regCredit.Name = "txt_regCredit";
            this.txt_regCredit.Size = new System.Drawing.Size(241, 31);
            this.txt_regCredit.TabIndex = 33;
            // 
            // lbl_regCredit
            // 
            this.lbl_regCredit.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regCredit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regCredit.Location = new System.Drawing.Point(3, 311);
            this.lbl_regCredit.Name = "lbl_regCredit";
            this.lbl_regCredit.Size = new System.Drawing.Size(165, 23);
            this.lbl_regCredit.TabIndex = 32;
            this.lbl_regCredit.Text = "Credit Card Number:";
            // 
            // txt_regSSN
            // 
            this.txt_regSSN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regSSN.Location = new System.Drawing.Point(172, 261);
            this.txt_regSSN.Multiline = true;
            this.txt_regSSN.Name = "txt_regSSN";
            this.txt_regSSN.Size = new System.Drawing.Size(241, 31);
            this.txt_regSSN.TabIndex = 31;
            // 
            // lbl_regSSN
            // 
            this.lbl_regSSN.AutoSize = true;
            this.lbl_regSSN.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regSSN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regSSN.Location = new System.Drawing.Point(73, 269);
            this.lbl_regSSN.Name = "lbl_regSSN";
            this.lbl_regSSN.Size = new System.Drawing.Size(50, 23);
            this.lbl_regSSN.TabIndex = 30;
            this.lbl_regSSN.Text = "SSN:";
            // 
            // txt_regUsername
            // 
            this.txt_regUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regUsername.Location = new System.Drawing.Point(172, 95);
            this.txt_regUsername.Multiline = true;
            this.txt_regUsername.Name = "txt_regUsername";
            this.txt_regUsername.Size = new System.Drawing.Size(241, 31);
            this.txt_regUsername.TabIndex = 29;
            // 
            // lbl_regUsername
            // 
            this.lbl_regUsername.AutoSize = true;
            this.lbl_regUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regUsername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regUsername.Location = new System.Drawing.Point(54, 103);
            this.lbl_regUsername.Name = "lbl_regUsername";
            this.lbl_regUsername.Size = new System.Drawing.Size(85, 23);
            this.lbl_regUsername.TabIndex = 28;
            this.lbl_regUsername.Text = "Username:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(172, 55);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(241, 31);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(172, 14);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(241, 31);
            this.textBox8.TabIndex = 26;
            // 
            // lbl_regFName
            // 
            this.lbl_regFName.AutoSize = true;
            this.lbl_regFName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regFName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regFName.Location = new System.Drawing.Point(50, 22);
            this.lbl_regFName.Name = "lbl_regFName";
            this.lbl_regFName.Size = new System.Drawing.Size(97, 23);
            this.lbl_regFName.TabIndex = 24;
            this.lbl_regFName.Text = "First Name:";
            // 
            // lbl_regLName
            // 
            this.lbl_regLName.AutoSize = true;
            this.lbl_regLName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regLName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regLName.Location = new System.Drawing.Point(52, 63);
            this.lbl_regLName.Name = "lbl_regLName";
            this.lbl_regLName.Size = new System.Drawing.Size(91, 23);
            this.lbl_regLName.TabIndex = 25;
            this.lbl_regLName.Text = "Last Name:";
            // 
            // txt_regConPassword
            // 
            this.txt_regConPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regConPassword.Location = new System.Drawing.Point(172, 220);
            this.txt_regConPassword.Multiline = true;
            this.txt_regConPassword.Name = "txt_regConPassword";
            this.txt_regConPassword.Size = new System.Drawing.Size(241, 31);
            this.txt_regConPassword.TabIndex = 23;
            // 
            // lbl_regConPassword
            // 
            this.lbl_regConPassword.AutoSize = true;
            this.lbl_regConPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regConPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regConPassword.Location = new System.Drawing.Point(18, 228);
            this.lbl_regConPassword.Name = "lbl_regConPassword";
            this.lbl_regConPassword.Size = new System.Drawing.Size(144, 23);
            this.lbl_regConPassword.TabIndex = 22;
            this.lbl_regConPassword.Text = "Confirm Password:";
            // 
            // btn_registerReg
            // 
            this.btn_registerReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(100)))), ((int)(((byte)(88)))));
            this.btn_registerReg.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registerReg.ForeColor = System.Drawing.Color.White;
            this.btn_registerReg.Location = new System.Drawing.Point(23, 411);
            this.btn_registerReg.Name = "btn_registerReg";
            this.btn_registerReg.Size = new System.Drawing.Size(387, 42);
            this.btn_registerReg.TabIndex = 21;
            this.btn_registerReg.Text = "Register";
            this.btn_registerReg.UseVisualStyleBackColor = false;
            this.btn_registerReg.Click += new System.EventHandler(this.btn_registerReg_Click);
            // 
            // txt_regPassword
            // 
            this.txt_regPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regPassword.Location = new System.Drawing.Point(172, 178);
            this.txt_regPassword.Multiline = true;
            this.txt_regPassword.Name = "txt_regPassword";
            this.txt_regPassword.Size = new System.Drawing.Size(241, 31);
            this.txt_regPassword.TabIndex = 19;
            // 
            // txt_regEmail
            // 
            this.txt_regEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_regEmail.Location = new System.Drawing.Point(172, 136);
            this.txt_regEmail.Multiline = true;
            this.txt_regEmail.Name = "txt_regEmail";
            this.txt_regEmail.Size = new System.Drawing.Size(241, 31);
            this.txt_regEmail.TabIndex = 18;
            // 
            // lbl_regEmail
            // 
            this.lbl_regEmail.AutoSize = true;
            this.lbl_regEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regEmail.Location = new System.Drawing.Point(73, 144);
            this.lbl_regEmail.Name = "lbl_regEmail";
            this.lbl_regEmail.Size = new System.Drawing.Size(54, 23);
            this.lbl_regEmail.TabIndex = 16;
            this.lbl_regEmail.Text = "Email:";
            // 
            // lbl_regPassword
            // 
            this.lbl_regPassword.AutoSize = true;
            this.lbl_regPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_regPassword.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_regPassword.Location = new System.Drawing.Point(58, 186);
            this.lbl_regPassword.Name = "lbl_regPassword";
            this.lbl_regPassword.Size = new System.Drawing.Size(81, 23);
            this.lbl_regPassword.TabIndex = 17;
            this.lbl_regPassword.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tazkarti.Properties.Resources.MW_HE536_airpla_20190225131547_ZG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 687);
            this.Controls.Add(this.pnl_register);
            this.Controls.Add(this.pnl_login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.pnl_register.ResumeLayout(false);
            this.pnl_register.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_loginPassword;
        private System.Windows.Forms.Label lbl_loginUsername;
        private System.Windows.Forms.TextBox txt_loginUsername;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_loginPassword;
        private System.Windows.Forms.Panel pnl_register;
        private System.Windows.Forms.TextBox txt_regCredit;
        private System.Windows.Forms.Label lbl_regCredit;
        private System.Windows.Forms.TextBox txt_regSSN;
        private System.Windows.Forms.Label lbl_regSSN;
        private System.Windows.Forms.TextBox txt_regUsername;
        private System.Windows.Forms.Label lbl_regUsername;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lbl_regFName;
        private System.Windows.Forms.Label lbl_regLName;
        private System.Windows.Forms.TextBox txt_regConPassword;
        private System.Windows.Forms.Label lbl_regConPassword;
        private System.Windows.Forms.Button btn_registerReg;
        private System.Windows.Forms.TextBox txt_regPassword;
        private System.Windows.Forms.TextBox txt_regEmail;
        private System.Windows.Forms.Label lbl_regEmail;
        private System.Windows.Forms.Label lbl_regPassword;
        private System.Windows.Forms.Button btn_loginAddMob;
        private System.Windows.Forms.TextBox txt_loginMob2;
        private System.Windows.Forms.TextBox txt_loginMob1;
        private System.Windows.Forms.Label lbl_regNumber;

    }
}