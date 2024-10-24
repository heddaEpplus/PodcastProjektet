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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            label4 = new Label();
            textBoxNyKategori = new TextBox();
            label5 = new Label();
            button5 = new Button();
            button8 = new Button();
            button9 = new Button();
            textBox6 = new TextBox();
            listView1 = new ListView();
            Antalavsnitt = new ColumnHeader();
            Titel = new ColumnHeader();
            Kategori = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            listView2 = new ListView();
            Avsnitt1 = new ColumnHeader();
            listBoxKategorier = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(650, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 48);
            label1.TabIndex = 3;
            label1.Text = "Podcast";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 98);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 4;
            label2.Text = "Ändra namn:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 125);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 31);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(76, 164);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(222, 33);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 205);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 8;
            label3.Text = "URL:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(541, 199);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 31);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(541, 124);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(222, 33);
            comboBox3.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(852, 124);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(111, 35);
            button2.TabIndex = 11;
            button2.Text = "Återställ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(852, 198);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(111, 35);
            button4.TabIndex = 13;
            button4.Text = "Sök";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(76, 205);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(111, 35);
            button6.TabIndex = 15;
            button6.Text = "Ändra";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(211, 205);
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
            label4.Location = new Point(1125, 238);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 18;
            label4.Text = "Avsnitt";
            // 
            // textBoxNyKategori
            // 
            textBoxNyKategori.Location = new Point(1355, 201);
            textBoxNyKategori.Margin = new Padding(2);
            textBoxNyKategori.Name = "textBoxNyKategori";
            textBoxNyKategori.Size = new Size(342, 31);
            textBoxNyKategori.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1492, 160);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 20;
            label5.Text = "Kategori";
            label5.Click += label5_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1355, 238);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(111, 35);
            button5.TabIndex = 21;
            button5.Text = "Lägg till";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.Location = new Point(1470, 238);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(111, 35);
            button8.TabIndex = 22;
            button8.Text = "Ändra";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(1585, 238);
            button9.Margin = new Padding(2);
            button9.Name = "button9";
            button9.Size = new Size(111, 35);
            button9.TabIndex = 23;
            button9.Text = "Ta bort";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1355, 459);
            textBox6.Margin = new Padding(2);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.ScrollBars = ScrollBars.Both;
            textBox6.Size = new Size(342, 150);
            textBox6.TabIndex = 25;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Antalavsnitt, Titel, Kategori, columnHeader1 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(79, 268);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(863, 362);
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
            // Kategori
            // 
            Kategori.Text = "Kategori";
            Kategori.Width = 190;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Namn";
            columnHeader1.Width = 190;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Avsnitt1 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem5 });
            listView2.Location = new Point(1019, 288);
            listView2.Margin = new Padding(2);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(286, 342);
            listView2.TabIndex = 29;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // Avsnitt1
            // 
            Avsnitt1.Text = "Avsnitt";
            Avsnitt1.Width = 250;
            // 
            // listBoxKategorier
            // 
            listBoxKategorier.Enabled = false;
            listBoxKategorier.GridLines = true;
            listBoxKategorier.Items.AddRange(new ListViewItem[] { listViewItem6 });
            listBoxKategorier.Location = new Point(1355, 288);
            listBoxKategorier.Margin = new Padding(2);
            listBoxKategorier.Name = "listBoxKategorier";
            listBoxKategorier.Size = new Size(342, 148);
            listBoxKategorier.TabIndex = 30;
            listBoxKategorier.UseCompatibleStateImageBehavior = false;
            listBoxKategorier.View = View.Details;
            listBoxKategorier.SelectedIndexChanged += listView3_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1792, 858);
            Controls.Add(listBoxKategorier);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(textBox6);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(textBoxNyKategori);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox3;
        private Button button2;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label4;
        private TextBox textBoxNyKategori;
        private Label label5;
        private Button button5;
        private Button button8;
        private Button button9;
        private TextBox textBox6;
        private ListView listView1;
        private ColumnHeader Antalavsnitt;
        private ColumnHeader Titel;
        private ColumnHeader Kategori;
        private ListView listView2;
        private ListView listBoxKategorier;
        private ColumnHeader columnHeader1;
        private ColumnHeader Avsnitt1;
    }
}
