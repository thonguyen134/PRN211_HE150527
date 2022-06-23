using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOConnectDataBaseDemo.DAO;
namespace ADOConnectDataBaseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btViewProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDAO.GetAllProduct();
        }

        private void btViewCategories_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CategoriesDAO.GetAllCategories();
        }
    }
}
