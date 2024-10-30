namespace PodcastProjektet.PL
{
    partial class SelectPodCategoryForm
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
            buttonSave = new Button();
            ComboBoxKategori = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(849, 371);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(188, 58);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // ComboBoxKategori
            // 
            ComboBoxKategori.FormattingEnabled = true;
            ComboBoxKategori.Location = new Point(210, 143);
            ComboBoxKategori.Name = "ComboBoxKategori";
            ComboBoxKategori.Size = new Size(567, 49);
            ComboBoxKategori.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 99);
            label1.Name = "label1";
            label1.Size = new Size(183, 41);
            label1.TabIndex = 2;
            label1.Text = "Välj Kategori";
            // 
            // SelectPodCategoryForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 450);
            Controls.Add(label1);
            Controls.Add(ComboBoxKategori);
            Controls.Add(buttonSave);
            Name = "SelectPodCategoryForm";
            Text = "SelectPodCategoryForm";
            Load += SelectPodCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private ComboBox ComboBoxKategori;
        private Label label1;
    }
}