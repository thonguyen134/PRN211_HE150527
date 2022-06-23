using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinfromDemo1
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good bye bro!");
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string gender = (rdGender.Checked ? "Female" : "Male");
            string phone = txtPhone.Text;
            string degree = cbDegree.Text;
            StringBuilder buider = new StringBuilder();
            buider.Append($"ID:{id}\n");
            buider.Append($"name:{name}\n");
            buider.Append($"gender:{gender}\n");
            buider.Append($"phone:{phone}\n");
            buider.Append($"degree:{degree}\n");
            MessageBox.Show(buider.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void restart_Click(object sender, EventArgs e)
        {
            txtId.ResetText();
            txtName.ResetText();
            txtPhone.ResetText();
            cbDegree.ResetText();
            
        }
    }
}
