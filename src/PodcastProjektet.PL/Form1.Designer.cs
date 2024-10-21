namespace PodcastProjektet.PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem5 = new ListViewItem("");
            ListViewItem listViewItem6 = new ListViewItem("");
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button5 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox6 = new TextBox();
            listView1 = new ListView();
            Antalavsnitt = new ColumnHeader();
            Titel = new ColumnHeader();
            Frekvens = new ColumnHeader();
            Kategori = new ColumnHeader();
            listView2 = new ListView();
            listView3 = new ListView();
            columnHeader1 = new ColumnHeader();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1531, 34);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(1436, 15);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(63, 54);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(650, 34);
            label1.Name = "label1";
            label1.Size = new Size(143, 48);
            label1.TabIndex = 3;
            label1.Text = "Podcast";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 120);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 4;
            label2.Text = "Namn:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(76, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 31);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(79, 197);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 33);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(233, 197);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 33);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 205);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 8;
            label3.Text = "URL:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(541, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 31);
            textBox2.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(541, 95);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(221, 33);
            comboBox3.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(804, 93);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(111, 35);
            button2.TabIndex = 11;
            button2.Text = "Återställ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(541, 150);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(111, 35);
            button3.TabIndex = 12;
            button3.Text = "Lägg till";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(852, 197);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(111, 35);
            button4.TabIndex = 13;
            button4.Text = "Sök";
            button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(682, 150);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(111, 35);
            button6.TabIndex = 15;
            button6.Text = "Ändra";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(804, 150);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(111, 35);
            button7.TabIndex = 16;
            button7.Text = "Ta bort";
            button7.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1125, 237);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 18;
            label4.Text = "Avsnitt";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1355, 201);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(341, 31);
            textBox4.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1493, 160);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 20;
            label5.Text = "Kategori";
            label5.Click += label5_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1355, 237);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(111, 35);
            button5.TabIndex = 21;
            button5.Text = "Lägg till";
            button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(1470, 237);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(111, 35);
            button8.TabIndex = 22;
            button8.Text = "Ändra";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(1585, 237);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(111, 35);
            button9.TabIndex = 23;
            button9.Text = "Ta bort";
            button9.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1355, 459);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.ScrollBars = ScrollBars.Both;
            textBox6.Size = new Size(341, 150);
            textBox6.TabIndex = 25;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Antalavsnitt, Titel, Frekvens, Kategori, columnHeader1 });
            listView1.Enabled = false;
            listView1.GridLines = true;
            listView1.Location = new Point(79, 268);
            listView1.Name = "listView1";
            listView1.Size = new Size(863, 361);
            listView1.TabIndex = 26;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Antalavsnitt
            // 
            Antalavsnitt.Text = "Antal avsnitt";
            Antalavsnitt.Width = 190;
            // 
            // Titel
            // 
            Titel.Text = "Titel";
            Titel.Width = 190;
            // 
            // Frekvens
            // 
            Frekvens.Text = "Frekvens";
            Frekvens.Width = 190;
            // 
            // Kategori
            // 
            Kategori.Text = "Kategori";
            Kategori.Width = 190;
            // 
            // listView2
            // 
            listView2.Enabled = false;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem5 });
            listView2.Location = new Point(1019, 288);
            listView2.Name = "listView2";
            listView2.Size = new Size(286, 341);
            listView2.TabIndex = 29;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // listView3
            // 
            listView3.Enabled = false;
            listView3.GridLines = true;
            listView3.Items.AddRange(new ListViewItem[] { listViewItem6 });
            listView3.Location = new Point(1355, 288);
            listView3.Name = "listView3";
            listView3.Size = new Size(341, 148);
            listView3.TabIndex = 30;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Namn";
            columnHeader1.Width = 190;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1792, 857);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(textBox6);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button5;
        private Button button8;
        private Button button9;
        private TextBox textBox6;
        private ListView listView1;
        private ColumnHeader Antalavsnitt;
        private ColumnHeader Titel;
        private ColumnHeader Frekvens;
        private ColumnHeader Kategori;
        private ListView listView2;
        private ListView listView3;
        private ColumnHeader columnHeader1;
    }
}
