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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace databaze
{
    public partial class Cart : Form
    {
        int i = 0;
        bool flag;
        public Cart()
        {
            InitializeComponent();

            flag = false;

            NpgsqlConnection cart = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            cart.Open();
            NpgsqlCommand cartconnection = new NpgsqlCommand();
            cartconnection.Connection = cart;
            cartconnection.CommandType = CommandType.Text;
            cartconnection.CommandText = "select fio as \"Full name\",models_name as \"model name\",total_price as \"sum\" , weight,cart.cart_id from cart join customer on customer.customer_id=cart.cart_id";

            NpgsqlDataReader reader1 = cartconnection.ExecuteReader();
            while (reader1.Read())
            {

                dataGridView1.Rows.Add(reader1.GetString(0), reader1.GetString(1), reader1.GetFloat(2), reader1.GetFloat(3), reader1.GetInt32(4));

            }
            cartconnection.Dispose();
            cart.Close();
            flag = true;

        }
        private void updatetable()
        {


            dataGridView1.Rows.Clear();



            flag = false;
            NpgsqlConnection cart = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            cart.Open();
            NpgsqlCommand cartconnection = new NpgsqlCommand();
            cartconnection.Connection = cart;
            cartconnection.CommandType = CommandType.Text;
            cartconnection.CommandText = "select fio as \"Full name\",models_name as \"model name\",total_price as \"sum\" , weight,cart.cart_id from cart join customer on customer.cart_id=cart.cart_id";

            NpgsqlDataReader reader1 = cartconnection.ExecuteReader();
            while (reader1.Read())
            {

                dataGridView1.Rows.Add(reader1.GetString(0), reader1.GetString(1), reader1.GetFloat(2), reader1.GetFloat(3), reader1.GetInt32(4));

            }
            cartconnection.Dispose();
            cart.Close();
            flag = true;



        }
        create_cart create = new create_cart();
        private void button4_Click(object sender, EventArgs e)
        {
            create.ShowDialog();
            updatetable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = 0;
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            string id = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
           // custmerCommand.CommandText = "delete from cart where cart_id = " + id;
            custmerCommand.CommandText = "update customer set cart_id = null where cart_id=" + id;
            custmerCommand.ExecuteNonQuery();
            custmerCommand.CommandText = "delete from cart where cart_id=" + id;
            custmerCommand.ExecuteNonQuery();

            custmerCommand.Dispose();
            custmer.Close();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            string id = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            custmerCommand.CommandText = "update cart set models_name ='" + textBox1.Text.ToString() + "', total_price ='" + textBox2.Text.ToString() + "', weight ='" + textBox3.Text.ToString() + "'where cart_id = " + id;
            custmerCommand.ExecuteNonQuery();
            custmerCommand.Dispose();
            custmer.Close();
            i = 0;

            updatetable();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (i == 1 && dataGridView1.CurrentRow.Index > -1)
                {
                    string s = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    this.textBox1.Text = s;
                    s = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    this.textBox2.Text = s;
                    s = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    this.textBox3.Text = s;
                }
                i = 1;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                i = 1;
                string s = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.textBox1.Text = s;
                s = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.textBox2.Text = s;
                s = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.textBox3.Text = s;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            updatetable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                flag = false;
                dataGridView1.Rows.Clear();

                string name = textBox6.Text;
                string price1 = textBox5.Text, price2 = textBox7.Text;
                string weight1 = textBox8.Text, weight2 = textBox4.Text;

                if ((textBox7.Text.Length > 0 && textBox4.Text.Length > 0) && textBox5.Text.Length > 0 && textBox8.Text.Length > 0)
                {


                    NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

                    custmer.Open();
                    NpgsqlCommand custmerCommand = new NpgsqlCommand();
                    custmerCommand.Connection = custmer;
                    custmerCommand.CommandType = CommandType.Text;
                    string tew = "select fio ,models_name ,total_price , weight,cart.cart_id from cart join customer on customer.cart_id=cart.cart_id WHERE models_name like '%" + name + "%' and  total_price >" + price1 + " and total_price <'" + price2 + "'and weight > " + weight1 + " and weight <'" + weight2 + "';";
                    custmerCommand.CommandText = tew;
                    NpgsqlDataReader reader1 = custmerCommand.ExecuteReader();
                    while (reader1.Read())
                    {

                        dataGridView1.Rows.Add(reader1.GetString(0), reader1.GetString(1), reader1.GetFloat(2), reader1.GetFloat(3), reader1.GetInt32(4));

                    }
                    custmerCommand.Dispose();
                    custmer.Close();
                    flag = true;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            string tew = " SELECT SUM(total_price) AS total_sum FROM cart;";
            custmerCommand.CommandText = tew;
            NpgsqlDataReader reader1 = custmerCommand.ExecuteReader();
            if (reader1.Read())
            {
                label8.Text = reader1.GetFloat(0).ToString();
            }

            custmerCommand.Dispose();
            custmer.Close();

        }

        private void Cart_Shown(object sender, EventArgs e)
        {
            updatetable();
        }
    }
}
