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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        public string NewPassword { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPassword = textBox1.Text;
            this.Close(); // Close the ChangePass form after setting the password
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }
    }
}
