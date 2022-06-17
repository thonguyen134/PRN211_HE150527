using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmAddOrUpdate : Form
    {
        public string InsertOrUpdate { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public MemberObject MemberInfo { get; set; }

        public frmAddOrUpdate()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = GetMemberObject();
                if (member != null)
                {
                    if (InsertOrUpdate.Equals("Insert"))
                    {
                        MemberRepository.insertMember(member);
                    }
                    else
                    {
                        MemberRepository.updateMember(member);
                    }
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ID is exist!!!");
            }

        }
        private MemberObject GetMemberObject()
        {
            Validate valid = new Validate();
            string notice = null;
            if (!valid.checkMemberId(txtMemberID.Text))
            {
                notice += "Id ";
            }
            if (!valid.checkString(txtMemberName.Text))
            {
                notice += "Name ";
            }
            if (!valid.checkEmail(txtEmail.Text))
            {
                notice += "Email ";
            }
            if (!valid.checkPassword(txtPassword.Text))
            {
                notice += "Password ";
            }
            if (!valid.checkString(txtCity.Text))
            {
                notice += "City ";
            }
            if (!valid.checkString(txtCountry.Text))
            {
                notice += "Country ";
            }
            MemberObject member = null;
            if (notice != null)
            {
                MessageBox.Show(notice + "not valid");
                return null;
            }
            else
            {
                try
                {
                    member = new MemberObject()
                    {
                        MemberID = int.Parse(txtMemberID.Text),
                        MemberName = txtMemberName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,

                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Get Car Null");
                }
                return member;
            }
        }

        private void frmAddOrUpdate_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate.Equals("Update")) {
            txtMemberID.Enabled = false;
            txtMemberID.Text = MemberInfo.MemberID.ToString();
            txtEmail.Text = MemberInfo.Email.ToString();
            txtMemberName.Text = MemberInfo.MemberName.ToString();
            txtPassword.Text = MemberInfo.Password.ToString();
            txtCity.Text = MemberInfo.City.ToString();
            txtCountry.Text = MemberInfo.Country.ToString();
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
