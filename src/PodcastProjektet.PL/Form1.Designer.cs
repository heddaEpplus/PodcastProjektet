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
            label3 = new Label();
            textBox2 = new TextBox();
            SorteraKategoriComboBox = new ComboBox();
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
            label1.Font = new Font("Georgia", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1806, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 108);
            label1.TabIndex = 3;
            label1.Text = "Podify";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.2F, FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(130, 162);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(243, 41);
            label2.TabIndex = 4;
            label2.Text = "Ändra namn:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LavenderBlush;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 9F, FontStyle.Italic);
            textBox1.Location = new Point(130, 205);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(644, 55);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F, FontStyle.Italic);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(786, 328);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 36);
            label3.TabIndex = 8;
            label3.Text = "URL:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Verdana", 9F, FontStyle.Italic);
            textBox2.Location = new Point(920, 324);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(514, 37);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // SorteraKategoriComboBox
            // 
            SorteraKategoriComboBox.BackColor = Color.LavenderBlush;
            SorteraKategoriComboBox.Font = new Font("Verdana", 9F, FontStyle.Italic);
            SorteraKategoriComboBox.FormattingEnabled = true;
            SorteraKategoriComboBox.Location = new Point(920, 203);
            SorteraKategoriComboBox.Margin = new Padding(2, 2, 2, 2);
            SorteraKategoriComboBox.Name = "SorteraKategoriComboBox";
            SorteraKategoriComboBox.Size = new Size(376, 44);
            SorteraKategoriComboBox.TabIndex = 10;
            SorteraKategoriComboBox.SelectedIndexChanged += SorteraKategoriComboBox_SelectedIndexChanged;
            // 
            // laggTill
            // 
            laggTill.BackColor = Color.PaleVioletRed;
            laggTill.Font = new Font("Verdana", 9F, FontStyle.Italic);
            laggTill.ForeColor = SystemColors.ButtonHighlight;
            laggTill.Location = new Point(1470, 312);
            laggTill.Margin = new Padding(2, 2, 2, 2);
            laggTill.Name = "laggTill";
            laggTill.Size = new Size(208, 51);
            laggTill.TabIndex = 13;
            laggTill.Text = "Lägg till";
            laggTill.UseVisualStyleBackColor = false;
            laggTill.Click += button4_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleVioletRed;
            button6.Font = new Font("Verdana", 9F, FontStyle.Italic);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(130, 316);
            button6.Margin = new Padding(2, 2, 2, 2);
            button6.Name = "button6";
            button6.Size = new Size(261, 57);
            button6.TabIndex = 15;
            button6.Text = "Ändra";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.PaleVioletRed;
            button7.Font = new Font("Verdana", 9F, FontStyle.Italic);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(538, 314);
            button7.Margin = new Padding(2, 2, 2, 2);
            button7.Name = "button7";
            button7.Size = new Size(236, 57);
            button7.TabIndex = 16;
            button7.Text = "Ta bort";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(1912, 390);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 41);
            label4.TabIndex = 18;
            label4.Text = "Avsnitt";
            // 
            // KategoriTextBox
            // 
            KategoriTextBox.BackColor = Color.LavenderBlush;
            KategoriTextBox.BorderStyle = BorderStyle.None;
            KategoriTextBox.Location = new Point(2304, 324);
            KategoriTextBox.Margin = new Padding(2, 2, 2, 2);
            KategoriTextBox.Name = "KategoriTextBox";
            KategoriTextBox.Size = new Size(584, 40);
            KategoriTextBox.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(2516, 269);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 41);
            label5.TabIndex = 20;
            label5.Text = "Kategori";
            label5.Click += label5_Click;
            // 
            // LaggTillKategori
            // 
            LaggTillKategori.BackColor = Color.PaleVioletRed;
            LaggTillKategori.Font = new Font("Verdana", 9F, FontStyle.Italic);
            LaggTillKategori.ForeColor = SystemColors.ButtonHighlight;
            LaggTillKategori.Location = new Point(2306, 379);
            LaggTillKategori.Margin = new Padding(2, 2, 2, 2);
            LaggTillKategori.Name = "LaggTillKategori";
            LaggTillKategori.Size = new Size(189, 57);
            LaggTillKategori.TabIndex = 21;
            LaggTillKategori.Text = "Lägg till";
            LaggTillKategori.UseVisualStyleBackColor = false;
            LaggTillKategori.Click += LaggTillKategori_Click;
            // 
            // AndraKategori
            // 
            AndraKategori.BackColor = Color.PaleVioletRed;
            AndraKategori.Font = new Font("Verdana", 9F, FontStyle.Italic);
            AndraKategori.ForeColor = SystemColors.ButtonHighlight;
            AndraKategori.Location = new Point(2499, 379);
            AndraKategori.Margin = new Padding(2, 2, 2, 2);
            AndraKategori.Name = "AndraKategori";
            AndraKategori.Size = new Size(189, 57);
            AndraKategori.TabIndex = 22;
            AndraKategori.Text = "Ändra";
            AndraKategori.UseVisualStyleBackColor = false;
            AndraKategori.Click += AndraKategori_Click;
            // 
            // TaBortKategori
            // 
            TaBortKategori.BackColor = Color.PaleVioletRed;
            TaBortKategori.Font = new Font("Verdana", 9F, FontStyle.Italic);
            TaBortKategori.ForeColor = SystemColors.ButtonHighlight;
            TaBortKategori.Location = new Point(2692, 379);
            TaBortKategori.Margin = new Padding(2, 2, 2, 2);
            TaBortKategori.Name = "TaBortKategori";
            TaBortKategori.Size = new Size(189, 57);
            TaBortKategori.TabIndex = 23;
            TaBortKategori.Text = "Ta bort";
            TaBortKategori.UseVisualStyleBackColor = false;
            TaBortKategori.Click += TaBortKategori_Click;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.LavenderBlush;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Location = new Point(2304, 752);
            textBox6.Margin = new Padding(2, 2, 2, 2);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.ScrollBars = ScrollBars.Both;
            textBox6.Size = new Size(584, 277);
            textBox6.TabIndex = 25;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LavenderBlush;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { Antalavsnitt, Titel, Kategori, columnHeader1 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(134, 441);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(1468, 592);
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
            listView2.BackColor = Color.LavenderBlush;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Columns.AddRange(new ColumnHeader[] { Avsnitt1 });
            listView2.FullRowSelect = true;
            listView2.GridLines = true;
            listView2.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView2.Location = new Point(1732, 441);
            listView2.Margin = new Padding(2, 2, 2, 2);
            listView2.MultiSelect = false;
            listView2.Name = "listView2";
            listView2.Size = new Size(487, 592);
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
            KategoriListView.BackColor = Color.LavenderBlush;
            KategoriListView.BorderStyle = BorderStyle.None;
            KategoriListView.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            KategoriListView.FullRowSelect = true;
            KategoriListView.GridLines = true;
            KategoriListView.Items.AddRange(new ListViewItem[] { listViewItem2 });
            KategoriListView.Location = new Point(2304, 441);
            KategoriListView.Margin = new Padding(2, 2, 2, 2);
            KategoriListView.Name = "KategoriListView";
            KategoriListView.Size = new Size(584, 275);
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
            KategoriLabel.Font = new Font("Verdana", 10.2F, FontStyle.Italic);
            KategoriLabel.ForeColor = SystemColors.ButtonHighlight;
            KategoriLabel.Location = new Point(920, 160);
            KategoriLabel.Margin = new Padding(2, 0, 2, 0);
            KategoriLabel.Name = "KategoriLabel";
            KategoriLabel.Size = new Size(403, 41);
            KategoriLabel.TabIndex = 31;
            KategoriLabel.Text = "Sortera efter kategori:";
            // 
            // btnKategori
            // 
            btnKategori.BackColor = Color.PaleVioletRed;
            btnKategori.Font = new Font("Verdana", 9F, FontStyle.Italic);
            btnKategori.ForeColor = SystemColors.ButtonHighlight;
            btnKategori.Location = new Point(1328, 199);
            btnKategori.Margin = new Padding(2, 2, 2, 2);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(157, 53);
            btnKategori.TabIndex = 32;
            btnKategori.Text = "Välj";
            btnKategori.UseVisualStyleBackColor = false;
            btnKategori.Click += btnKategori_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(3158, 1050);
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
            Controls.Add(SorteraKategoriComboBox);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
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
        private Label label3;
        private TextBox textBox2;
        private ComboBox SorteraKategoriComboBox;
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
