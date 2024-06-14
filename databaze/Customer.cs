using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace databaze
{

    public partial class Customer : Form
    {
        int i = 0;
        bool flag;
        public Customer()
        {
            InitializeComponent();
            flag = false;
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            custmerCommand.CommandText = "select fio as \"full name\",phone_number as \"phone number\",adress , customer_id  from customer";
            NpgsqlDataReader reader = custmerCommand.ExecuteReader();
            while (reader.Read())
            {

                dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

            }
            dataGridView1.Columns[3].Visible = false;
            custmerCommand.Dispose();
            custmer.Close();
            flag = true;

        }
        private void updatetable()
        {


            dataGridView1.Rows.Clear();



            flag = false;
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            custmerCommand.CommandText = "select fio as \"full name\",phone_number as \"phone number\",adress , customer_id  from customer";
            NpgsqlDataReader reader = custmerCommand.ExecuteReader();
            while (reader.Read())
            {

                dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

            }

            custmer.Close();
            flag = true;



        }
        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                flag = false;
                dataGridView1.Rows.Clear();
                string fio = textBox6.Text;
                string phone = textBox5.Text;
                string adress = textBox3.Text;

                NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

                custmer.Open();
                NpgsqlCommand custmerCommand = new NpgsqlCommand();
                custmerCommand.Connection = custmer;
                custmerCommand.CommandType = CommandType.Text;

                custmerCommand.CommandText = "select fio ,phone_number ,adress , customer_id  from customer WHERE fio like '%" + fio + "%' and phone_number like '%" + phone + "%'  and adress like '%" + adress + "%'";
                NpgsqlDataReader reader = custmerCommand.ExecuteReader();
                while (reader.Read())
                {

                    dataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));

                }
                custmerCommand.Dispose();
                custmer.Close();
                flag = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            string id = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string tew = "delete from customer where customer_id = " + id;
            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            custmerCommand.CommandText = "delete from customer where customer_id = " + id;
            custmerCommand.ExecuteNonQuery();
            custmerCommand.Dispose();
            custmer.Close();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {

            if (flag)
            {
                if (i == 1 && dataGridView1.CurrentRow.Index > 0)
                {
                    string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    this.textBox1.Text = s;
                    s = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    this.textBox2.Text = s;
                    s = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    this.textBox3.Text = s;
                }

            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (flag)
            {
                i = 1;
                string s = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.textBox1.Text = s;
                s = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.textBox2.Text = s;
                s = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.textBox3.Text = s;
            }

        }
        Form2 create = new Form2();
        private void button4_Click(object sender, EventArgs e)
        {
            create.ShowDialog();
            updatetable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            string id = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            custmerCommand.CommandText = "update customer set phone_number ='" + textBox2.Text.ToString() + "', fio ='" + textBox1.Text.ToString() + "', adress ='" + textBox3.Text.ToString() + "'where customer_id = " + id;
            custmerCommand.ExecuteNonQuery();
            custmerCommand.Dispose();
            custmer.Close();
            i = 0;
            updatetable();
            


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updatetable();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 5)
            {
                NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

                custmer.Open();
                string id = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                NpgsqlCommand custmerCommand = new NpgsqlCommand();
                custmerCommand.Connection = custmer;
                custmerCommand.CommandType = CommandType.Text;
                custmerCommand.CommandText = " SELECT COUNT(*) AS row_count from customer where fio='" + textBox1.Text+"';" ;
                NpgsqlDataReader reader = custmerCommand.ExecuteReader();
                if (reader.Read())
                {
                    label4.Text = (reader.GetInt32(0)-1).ToString();
                }
                custmerCommand.Dispose();
                custmer.Close();
                
            }
        }
    }
}
