using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Form1 : Form
    {
        public string newPassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangePass obj1 = new ChangePass();
            obj1.ShowDialog();
            newPassword = obj1.NewPassword;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Transact ob2 = new Transact();
            ob2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String newPassword = "yadav";
            if (textBox1.Text.Equals("vansh") && textBox2.Text.Equals(newPassword))
            {
                label3.Text = "Login Succesful!";
            }

            else

                label3.Text = "Wrong Password";
        }
    }
}
