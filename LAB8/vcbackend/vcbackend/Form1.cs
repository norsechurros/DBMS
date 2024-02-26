using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace vcbackend
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the Application?", "Exit",MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            //e.Cancel = true;
            Application.Exit();
            }

        public void connect1()
        {
            String oradb = "Data Source=172.16.54.24:1521/ictorcl;User ID=cce306;Password=student";
            conn = new OracleConnection(oradb); // C#
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from participated";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "participated");
            dt = ds.Tables["participated"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox1.Text = dr["driver_id"].ToString();
            textBox2.Text = dr["regno"].ToString();
            textBox3.Text = dr["report_number"].ToString();
            textBox4.Text = dr["damage_amount"].ToString();
            conn.Close();

        }

        


        private void Next_Click_1(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count)
                i = 0;
            dr = dt.Rows[i];
            textBox1.Text = dr["driver_id"].ToString();
            textBox2.Text = dr["regno"].ToString();
            textBox3.Text = dr["report_number"].ToString();
            textBox4.Text = dr["damage_amount"].ToString();
        }

        private void previous_click_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
                i = dt.Rows.Count - 1;
            dr = dt.Rows[i];
            textBox1.Text = dr["driver_id"].ToString();
            textBox2.Text = dr["regno"].ToString();
            textBox3.Text = dr["report_number"].ToString();
            textBox4.Text = dr["damage_amount"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connect1();
            int sal = int.Parse(textBox4.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into participated values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Inserted!");
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect1();
            int v = int.Parse(textBox2.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update participated set salary=:pb where deptname =:pdn";
            cm.CommandType = CommandType.Text;

            OracleParameter pa1 = new OracleParameter();
            pa1.ParameterName = "pb";
            pa1.DbType = DbType.Int32;
            pa1.Value = v;
            OracleParameter pa2 = new OracleParameter();
            pa2.ParameterName = "pdn";
            pa2.DbType = DbType.String;
            pa2.Value = textBox1.Text;
            cm.Parameters.Add(pa1);
            cm.Parameters.Add(pa2);
            cm.ExecuteNonQuery();
            MessageBox.Show("updated");
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select driver_id from participated";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "participated");
            dt = ds.Tables["participated"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "driver_id";
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from participated";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "participated");
            dt = ds.Tables["participated"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "participated";
            conn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
