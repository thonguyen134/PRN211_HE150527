using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageCategoriesApp.DAO;
using ManageCategoriesApp.Model;
namespace ManageCategoriesApp
{
    public partial class frmManageCategories : Form
    {
        CategoriesDAO categoriesDAO = new CategoriesDAO();
        public frmManageCategories()
        {
            InitializeComponent();
        }

        private void DisplayAllCategories() {
            var categories = categoriesDAO.GetAllCategories();
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", categories, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", categories, "CategoryName");

            txtCategoryID.Enabled = false;
            dgvCategories.DataSource = categories;
        }
        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            DisplayAllCategories();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                categoriesDAO.InsertCategories(new Categories
                {
                    CategoryName = txtCategoryName.Text
                });
                DisplayAllCategories();
            }
            catch
            {
                MessageBox.Show("not oke");
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                categoriesDAO.UpdateCategories(new Categories
                {
                    CategoryId = Convert.ToInt32(txtCategoryID.Text),
                    CategoryName = txtCategoryName.Text
                });
                DisplayAllCategories();
            }
            catch
            {
                MessageBox.Show("not oke");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                categoriesDAO.DeleteCategories(new Categories
                {
                    CategoryId = Convert.ToInt32(txtCategoryID.Text),
                });
                DisplayAllCategories();
            }
            catch
            {
                MessageBox.Show("not oke");
            }
        }
    }
}
