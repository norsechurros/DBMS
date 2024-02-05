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
    public partial class Transact : Form
    {

        public int bal = 5000;
        public int amt;
        public List<int> transacs = new List<int>(); public Transact()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Transact_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = bal.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out amt))
            {
                // Subtract amt from bal
                bal -= amt;

                transacs.Add(amt);

                // Update labels to reflect the changes
                label8.Text = bal.ToString();
                label6.Text = "Beneficiary Added!";

                UpdateLastFiveTransactions();
            }
            else
            {
                // Handle the case where the content of textBox2 is not a valid integer
                MessageBox.Show("Please enter a valid integer amount in textBox2.");
            }
        }

        private void UpdateLastFiveTransactions()
        {
            // Display the last five transactions in label12
            label12.Text = " ";

            int startIndex = Math.Max(0, transacs.Count - 5);

            for (int i = startIndex; i < transacs.Count; i++)
            {
                label12.Text += transacs[i].ToString() + " ";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
