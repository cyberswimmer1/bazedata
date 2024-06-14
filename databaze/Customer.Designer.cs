namespace databaze
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            FIO = new DataGridViewTextBoxColumn();
            Phone_number = new DataGridViewTextBoxColumn();
            Adress = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button5 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 78);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 3;
            label1.Text = "FIO";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 111);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 4;
            label2.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 144);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Adress";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, -1);
            button2.Name = "button2";
            button2.Size = new Size(101, 61);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(119, -1);
            button3.Name = "button3";
            button3.Size = new Size(101, 61);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(226, -1);
            button4.Name = "button4";
            button4.Size = new Size(98, 61);
            button4.TabIndex = 9;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 418);
            panel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FIO, Phone_number, Adress, id });
            dataGridView1.Location = new Point(19, 14);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(803, 391);
            dataGridView1.TabIndex = 0;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // FIO
            // 
            FIO.HeaderText = "FIO";
            FIO.MinimumWidth = 6;
            FIO.Name = "FIO";
            // 
            // Phone_number
            // 
            Phone_number.HeaderText = "Phone_number";
            Phone_number.MinimumWidth = 6;
            Phone_number.Name = "Phone_number";
            // 
            // Adress
            // 
            Adress.HeaderText = "Adress";
            Adress.MinimumWidth = 6;
            Adress.Name = "Adress";
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(687, 5);
            button1.Name = "button1";
            button1.Size = new Size(90, 61);
            button1.TabIndex = 6;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(472, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(337, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(472, 105);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(337, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(472, 72);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(337, 27);
            textBox6.TabIndex = 11;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(472, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 24);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "включить поиск";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(472, 42);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(152, 24);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "выключить поиск";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // button5
            // 
            button5.Location = new Point(19, 174);
            button5.Name = "button5";
            button5.Size = new Size(226, 36);
            button5.TabIndex = 16;
            button5.Text = "Количество однофамильцев";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 182);
            label4.Name = "label4";
            label4.Size = new Size(17, 20);
            label4.TabIndex = 17;
            label4.Text = "0";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 633);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Phone_number;
        private DataGridViewTextBoxColumn Adress;
        private DataGridViewTextBoxColumn id;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button5;
        private Label label4;
    }
}