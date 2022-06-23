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

        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            var categories = categoriesDAO.GetAllCategories();
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", categories, "CategoryID");
            txtCategoryName.DataBindings.Add("Text", categories, "CategoryName");

            dgvCategories.DataSource = categories;  
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {

            }
        }
    }
}
