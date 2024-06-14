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
    public partial class create_cart : Form
    {

        public create_cart()
        {
            InitializeComponent();

            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            custmerCommand.CommandText = "select fio , customer_id  from customer where cart_id IS  NULL";
            NpgsqlDataReader reader = custmerCommand.ExecuteReader();
            while (reader.Read())
            {

                dataGridView1.Rows.Add(reader.GetString(0), reader.GetInt32(1));
                comboBox1.Items.Add(reader.GetString(0));

            }

            custmerCommand.Dispose();
            custmer.Close();
        }
        private void updatedata()
        {
            dataGridView1.Rows.Clear();
            comboBox1.Items.Clear();
            comboBox1.Text = null;
            NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

            custmer.Open();
            NpgsqlCommand custmerCommand = new NpgsqlCommand();
            custmerCommand.Connection = custmer;
            custmerCommand.CommandType = CommandType.Text;
            custmerCommand.CommandText = "select fio , customer_id  from customer where cart_id IS  NULL";
            NpgsqlDataReader reader = custmerCommand.ExecuteReader();
            while (reader.Read())
            {

                dataGridView1.Rows.Add(reader.GetString(0), reader.GetInt32(1));
                comboBox1.Items.Add(reader.GetString(0));

            }

            custmerCommand.Dispose();
            custmer.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && comboBox1.Text.Length > 0)
            {
                NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

                custmer.Open();


                NpgsqlCommand custmerCommand = new NpgsqlCommand();
                custmerCommand.Connection = custmer;
                custmerCommand.CommandType = CommandType.Text;
                custmerCommand.CommandText = ("insert into cart (models_name,total_price,weight) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')returning cart_id;");

                int id = (int)custmerCommand.ExecuteScalar();


                custmerCommand.CommandText = "update customer set cart_id=" + id + " where fio='" + comboBox1.Text.ToString() + "'";
                custmerCommand.ExecuteReader();

                custmer.Close();
                updatedata();
            }
        }

        private void create_cart_Shown(object sender, EventArgs e)
        {
            updatedata();
        }
    }
}
