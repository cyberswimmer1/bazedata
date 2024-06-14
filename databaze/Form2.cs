using Npgsql;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1 != null && textBox2 != null && textBox3 != null)
            {
                NpgsqlConnection custmer = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=123;Database=laba");

                custmer.Open();
                

                NpgsqlCommand custmerCommand = new NpgsqlCommand();
                custmerCommand.Connection = custmer;
                custmerCommand.CommandType = CommandType.Text;
                custmerCommand.CommandText = ("insert into customer(phone_number,fio,adress) values ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "');");
                

                custmerCommand.ExecuteNonQuery();

                custmer.Close();
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;    
                
                
            }


        }
    }
}
