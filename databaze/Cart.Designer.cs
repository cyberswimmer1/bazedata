namespace databaze
{
    partial class Cart
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Full_name = new DataGridViewTextBoxColumn();
            Models_name = new DataGridViewTextBoxColumn();
            Total_price = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox8 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button5 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(31, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(833, 418);
            panel1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Full_name, Models_name, Total_price, Weight, id });
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(827, 412);
            dataGridView1.TabIndex = 0;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // Full_name
            // 
            Full_name.HeaderText = "Full_name";
            Full_name.MinimumWidth = 6;
            Full_name.Name = "Full_name";
            Full_name.ReadOnly = true;
            // 
            // Models_name
            // 
            Models_name.HeaderText = "Models_name";
            Models_name.MinimumWidth = 6;
            Models_name.Name = "Models_name";
            Models_name.ReadOnly = true;
            // 
            // Total_price
            // 
            Total_price.HeaderText = "Total_price";
            Total_price.MinimumWidth = 6;
            Total_price.Name = "Total_price";
            Total_price.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight";
            Weight.MinimumWidth = 6;
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(314, 11);
            button4.Name = "button4";
            button4.Size = new Size(99, 61);
            button4.TabIndex = 20;
            button4.Text = "Create";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(50, 12);
            button3.Name = "button3";
            button3.Size = new Size(99, 61);
            button3.TabIndex = 19;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(180, 11);
            button2.Name = "button2";
            button2.Size = new Size(99, 61);
            button2.TabIndex = 18;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(706, 12);
            button1.Name = "button1";
            button1.Size = new Size(99, 61);
            button1.TabIndex = 17;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 162);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 16;
            label3.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 129);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 15;
            label2.Text = "Total price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 96);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 14;
            label1.Text = "Models name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 156);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(575, 122);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(72, 27);
            textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(539, 90);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(266, 27);
            textBox6.TabIndex = 22;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(539, 49);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(152, 24);
            radioButton2.TabIndex = 26;
            radioButton2.TabStop = true;
            radioButton2.Text = "выключить поиск";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(539, 18);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(141, 24);
            radioButton1.TabIndex = 25;
            radioButton1.TabStop = true;
            radioButton1.Text = "включить поиск";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(706, 122);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(84, 27);
            textBox7.TabIndex = 27;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(706, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(84, 27);
            textBox4.TabIndex = 29;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(575, 154);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(72, 27);
            textBox8.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(543, 127);
            label4.Name = "label4";
            label4.Size = new Size(26, 20);
            label4.TabIndex = 30;
            label4.Text = "От";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(543, 163);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 31;
            label5.Text = "От";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(663, 130);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 32;
            label6.Text = "До";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(663, 162);
            label7.Name = "label7";
            label7.Size = new Size(28, 20);
            label7.TabIndex = 33;
            label7.Text = "До";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // button5
            // 
            button5.Location = new Point(34, 189);
            button5.Name = "button5";
            button5.Size = new Size(245, 32);
            button5.TabIndex = 34;
            button5.Text = "Сумма всех товаров";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 195);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 35;
            label8.Text = "0";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 692);
            Controls.Add(label8);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
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
            Name = "Cart";
            Text = " cart";
            Shown += Cart_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Full_name;
        private DataGridViewTextBoxColumn Models_name;
        private DataGridViewTextBoxColumn Total_price;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn id;
        private TextBox textBox5;
        private TextBox textBox6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button5;
        private Label label8;
    }
}