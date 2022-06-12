using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMDIApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        ChildForm f1;
        void f1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1 = null;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (f1 == null)
            {
                f1 = new ChildForm();
                f1.MdiParent = this;
                f1.FormClosed += new FormClosedEventHandler(f1_FormClosed);
                f1.Show();
            }
            else
                f1.Activate();
        }
    }
}
