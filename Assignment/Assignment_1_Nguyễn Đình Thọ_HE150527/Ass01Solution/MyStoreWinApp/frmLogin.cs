﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            
            string fileName = @"appsettings.json";
            string jsonText = File.ReadAllText(fileName);
            Account account = Newtonsoft.Json.JsonConvert.DeserializeObject<Account>(jsonText);
            if (account.Username.Equals(txtUser.Text) && account.Password.Equals(txtPass.Text)){
                MessageBox.Show($"Hello: Admin <3");
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong account or password");
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
