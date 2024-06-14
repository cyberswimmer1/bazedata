namespace databaze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(500, 500);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Customer cus = new Customer();
        private void button1_Click(object sender, EventArgs e)
        {
            cus.ShowDialog();
        }
        Cart cr = new Cart();
        private void button2_Click(object sender, EventArgs e)
        {
            cr.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }
    }
}
