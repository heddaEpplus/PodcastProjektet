﻿namespace PodcastProjektet.PL
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            SorteraKategoriComboBox = new ComboBox();
            button2 = new Button();
            laggTill = new Button();
            button6 = new Button();
            button7 = new Button();
            label4 = new Label();
            KategoriTextBox = new TextBox();
            label5 = new Label();
            LaggTillKategori = new Button();
            AndraKategori = new Button();
            TaBortKategori = new Button();
            textBox6 = new TextBox();
            listView1 = new ListView();
            Antalavsnitt = new ColumnHeader();
            Titel = new ColumnHeader();
            Kategori = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            setCategoryMenuItem = new ToolStripMenuItem();
            listView2 = new ListView();
            Avsnitt1 = new ColumnHeader();
            KategoriListView = new ListView();
            columnHeader2 = new ColumnHeader();
            KategoriLabel = new Label();
            btnKategori = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(1105, 56);
            label1.Name = "label1";
            label1.Size = new Size(241, 81);
            label1.TabIndex = 3;
            label1.Text = "Podcast";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 161);
            label2.Name = "label2";
            label2.Size = new Size(187, 41);
            label2.TabIndex = 4;
            label2.Text = "Ändra namn:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(640, 47);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(129, 269);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(375, 49);
            comboBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(808, 336);
            label3.Name = "label3";
            label3.Size = new Size(78, 41);
            label3.TabIndex = 8;
            label3.Text = "URL:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(920, 326);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(494, 47);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // SorteraKategoriComboBox
            // 
            SorteraKategoriComboBox.FormattingEnabled = true;
            SorteraKategoriComboBox.Location = new Point(920, 203);
            SorteraKategoriComboBox.Name = "SorteraKategoriComboBox";
            SorteraKategoriComboBox.Size = new Size(375, 49);
            SorteraKategoriComboBox.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(1448, 203);
            button2.Name = "button2";
            button2.Size = new Size(189, 57);
            button2.TabIndex = 11;
            button2.Text = "Återställ";
            button2.UseVisualStyleBackColor = true;
            // 
            // laggTill
            // 
            laggTill.BackColor = Color.Silver;
            laggTill.Font = new Font("Verdana", 9F);
            laggTill.ForeColor = SystemColors.ButtonHighlight;
            laggTill.Location = new Point(1428, 326);
            laggTill.Margin = new Padding(2);
            laggTill.Name = "laggTill";
            laggTill.Size = new Size(146, 51);
            laggTill.TabIndex = 13;
            laggTill.Text = "Lägg till";
            laggTill.UseVisualStyleBackColor = false;
            laggTill.Click += button4_Click;
            // 
            // button6
            // 
            button6.Location = new Point(129, 336);
            button6.Name = "button6";
            button6.Size = new Size(189, 57);
            button6.TabIndex = 15;
            button6.Text = "Ändra";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(359, 336);
            button7.Name = "button7";
            button7.Size = new Size(189, 57);
            button7.TabIndex = 16;
            button7.Text = "Ta bort";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1912, 390);
            label4.Name = "label4";
            label4.Size = new Size(107, 41);
            label4.TabIndex = 18;
            label4.Text = "Avsnitt";
            // 
            // KategoriTextBox
            // 
            KategoriTextBox.Location = new Point(2304, 330);
            KategoriTextBox.Name = "KategoriTextBox";
            KategoriTextBox.Size = new Size(579, 47);
            KategoriTextBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2536, 262);
            label5.Name = "label5";
            label5.Size = new Size(129, 41);
            label5.TabIndex = 20;
            label5.Text = "Kategori";
            label5.Click += label5_Click;
            // 
            // LaggTillKategori
            // 
            LaggTillKategori.Location = new Point(2304, 390);
            LaggTillKategori.Name = "LaggTillKategori";
            LaggTillKategori.Size = new Size(189, 57);
            LaggTillKategori.TabIndex = 21;
            LaggTillKategori.Text = "Lägg till";
            LaggTillKategori.UseVisualStyleBackColor = true;
            LaggTillKategori.Click += LaggTillKategori_Click;
            // 
            // AndraKategori
            // 
            AndraKategori.Location = new Point(2499, 390);
            AndraKategori.Name = "AndraKategori";
            AndraKategori.Size = new Size(189, 57);
            AndraKategori.TabIndex = 22;
            AndraKategori.Text = "Ändra";
            AndraKategori.UseVisualStyleBackColor = true;
            AndraKategori.Click += AndraKategori_Click;
            // 
            // TaBortKategori
            // 
            TaBortKategori.Location = new Point(2694, 390);
            TaBortKategori.Name = "TaBortKategori";
            TaBortKategori.Size = new Size(189, 57);
            TaBortKategori.TabIndex = 23;
            TaBortKategori.Text = "Ta bort";
            TaBortKategori.UseVisualStyleBackColor = true;
            TaBortKategori.Click += TaBortKategori_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(2304, 753);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.ScrollBars = ScrollBars.Both;
            textBox6.Size = new Size(579, 243);
            textBox6.TabIndex = 25;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Antalavsnitt, Titel, Kategori, columnHeader1 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(134, 440);
            listView1.Name = "listView1";
            listView1.Size = new Size(1464, 589);
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { setCategoryMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(260, 52);
            contextMenuStrip1.MouseClick += contextMenuStrip1_MouseClick;
            // 
            // setCategoryMenuItem
            // 
            setCategoryMenuItem.Name = "setCategoryMenuItem";
            setCategoryMenuItem.Size = new Size(259, 48);
            setCategoryMenuItem.Text = "Välj kategori";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { Avsnitt1 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView2.Location = new Point(1732, 472);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(483, 558);
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
            // KategoriListView
            // 
            KategoriListView.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            KategoriListView.FullRowSelect = true;
            KategoriListView.GridLines = true;
            KategoriListView.Items.AddRange(new ListViewItem[] { listViewItem2 });
            KategoriListView.Location = new Point(2304, 472);
            KategoriListView.Name = "KategoriListView";
            KategoriListView.Size = new Size(579, 240);
            KategoriListView.TabIndex = 30;
            KategoriListView.UseCompatibleStateImageBehavior = false;
            KategoriListView.View = View.Details;
            KategoriListView.SelectedIndexChanged += KategoriListView_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategorier";
            columnHeader2.Width = 400;
            // 
            // KategoriLabel
            // 
            KategoriLabel.AutoSize = true;
            KategoriLabel.Location = new Point(920, 159);
            KategoriLabel.Name = "KategoriLabel";
            KategoriLabel.Size = new Size(306, 41);
            KategoriLabel.TabIndex = 31;
            KategoriLabel.Text = "Sortera efter kategori:";
            // 
            // btnKategori
            // 
            btnKategori.Location = new Point(1301, 203);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(129, 49);
            btnKategori.TabIndex = 32;
            btnKategori.Text = "Välj";
            btnKategori.UseVisualStyleBackColor = true;
            btnKategori.Click += btnKategori_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2857, 1050);
            Controls.Add(btnKategori);
            Controls.Add(KategoriLabel);
            Controls.Add(KategoriListView);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(textBox6);
            Controls.Add(TaBortKategori);
            Controls.Add(AndraKategori);
            Controls.Add(LaggTillKategori);
            Controls.Add(label5);
            Controls.Add(KategoriTextBox);
            Controls.Add(label4);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(laggTill);
            Controls.Add(button2);
            Controls.Add(SorteraKategoriComboBox);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
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
        private ComboBox SorteraKategoriComboBox;
        private Button button2;
        private Button laggTill;
        private Button button6;
        private Button button7;
        private Label label4;
        private TextBox KategoriTextBox;
        private Label label5;
        private Button LaggTillKategori;
        private Button AndraKategori;
        private Button TaBortKategori;
        private TextBox textBox6;
        private ListView listView1;
        private ColumnHeader Antalavsnitt;
        private ColumnHeader Titel;
        private ColumnHeader Kategori;
        private ListView listView2;
        private ListView KategoriListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader Avsnitt1;
        private ColumnHeader columnHeader2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem setCategoryMenuItem;
        private Label KategoriLabel;
        private Button btnKategori;
    }
}
