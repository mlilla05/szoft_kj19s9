namespace HitelKiszámítás
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
            button1 = new Button();
            tbHaviKamat = new TextBox();
            tbHitelÖsszege = new TextBox();
            cbHaviTörlesztő = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(303, 98);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbHaviKamat
            // 
            tbHaviKamat.Location = new Point(303, 46);
            tbHaviKamat.Name = "tbHaviKamat";
            tbHaviKamat.Size = new Size(112, 31);
            tbHaviKamat.TabIndex = 1;
            tbHaviKamat.Text = "2";
            // 
            // tbHitelÖsszege
            // 
            tbHitelÖsszege.Location = new Point(84, 46);
            tbHitelÖsszege.Name = "tbHitelÖsszege";
            tbHitelÖsszege.Size = new Size(112, 31);
            tbHitelÖsszege.TabIndex = 2;
            tbHitelÖsszege.Text = "100000";
            // 
            // cbHaviTörlesztő
            // 
            cbHaviTörlesztő.FormattingEnabled = true;
            cbHaviTörlesztő.Location = new Point(547, 44);
            cbHaviTörlesztő.Name = "cbHaviTörlesztő";
            cbHaviTörlesztő.Size = new Size(112, 33);
            cbHaviTörlesztő.TabIndex = 3;
            cbHaviTörlesztő.Text = "20000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 4;
            label1.Text = "Hitelösszeg:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 5;
            label2.Text = "Havi kamat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(547, 9);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 6;
            label3.Text = "Havi törlesztőrészlet:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(177, 152);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 225);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbHaviTörlesztő);
            Controls.Add(tbHitelÖsszege);
            Controls.Add(tbHaviKamat);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox tbHaviKamat;
        private TextBox tbHitelÖsszege;
        private ComboBox cbHaviTörlesztő;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
    }
}
