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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox3 = new ComboBox();
            button2 = new Button();
            laggTill = new Button();
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
            Kategori = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            listView2 = new ListView();
            Avsnitt1 = new ColumnHeader();
            listView3 = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 26F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(718, 19);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 60);
            label1.TabIndex = 3;
            label1.Text = "PoddPortalen";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(76, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 4;
            label2.Text = "Ändra namn:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(76, 125);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.LavenderBlush;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(76, 164);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(289, 33);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(442, 168);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 8;
            label3.Text = "URL:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LavenderBlush;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(511, 166);
            textBox2.Margin = new Padding(2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(222, 30);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.LavenderBlush;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(511, 125);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(222, 33);
            comboBox3.TabIndex = 10;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleVioletRed;
            button2.Font = new Font("Verdana", 9F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(791, 121);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(111, 35);
            button2.TabIndex = 11;
            button2.Text = "Återställ";
            button2.UseVisualStyleBackColor = false;
            // 
            // laggTill
            // 
            laggTill.BackColor = Color.PaleVioletRed;
            laggTill.Font = new Font("Verdana", 9F);
            laggTill.ForeColor = SystemColors.ButtonHighlight;
            laggTill.Location = new Point(791, 172);
            laggTill.Margin = new Padding(2);
            laggTill.Name = "laggTill";
            laggTill.Size = new Size(111, 35);
            laggTill.TabIndex = 13;
            laggTill.Text = "Lägg till";
            laggTill.UseVisualStyleBackColor = false;
            laggTill.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleVioletRed;
            button6.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(76, 205);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(138, 35);
            button6.TabIndex = 15;
            button6.Text = "Ändra";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleVioletRed;
            button7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(235, 205);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(130, 35);
            button7.TabIndex = 16;
            button7.Text = "Ta bort";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1127, 201);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 18;
            label4.Text = "Avsnitt";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1355, 201);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(342, 31);
            textBox4.TabIndex = 19;
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
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LavenderBlush;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.ForeColor = Color.PaleVioletRed;
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
            listView1.BackColor = Color.LavenderBlush;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { Antalavsnitt, Titel, Kategori, columnHeader1 });
            listView1.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listView1.ForeColor = Color.PaleVioletRed;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(76, 260);
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
            listView2.BackColor = Color.LavenderBlush;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Columns.AddRange(new ColumnHeader[] { Avsnitt1 });
            listView2.Font = new Font("Verdana", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listView2.ForeColor = Color.PaleVioletRed;
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView2.Location = new Point(1027, 260);
            listView2.Margin = new Padding(2);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(286, 362);
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
            // listView3
            // 
            listView3.Enabled = false;
            listView3.GridLines = true;
            listView3.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView3.Location = new Point(1355, 288);
            listView3.Margin = new Padding(2);
            listView3.Name = "listView3";
            listView3.Size = new Size(342, 148);
            listView3.TabIndex = 30;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1792, 858);
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
            Controls.Add(laggTill);
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
        private Button laggTill;
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
        private ColumnHeader Kategori;
        private ListView listView2;
        private ListView listView3;
        private ColumnHeader columnHeader1;
        private ColumnHeader Avsnitt1;
    }
}
