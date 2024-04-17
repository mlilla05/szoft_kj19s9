namespace MintaZH
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
            buttonBetöltés = new Button();
            dataGridView1 = new DataGridView();
            futókBindingSource = new BindingSource(components);
            buttonMentés = new Button();
            textBox1 = new TextBox();
            buttonTörlés = new Button();
            buttonÚj = new Button();
            buttonSzámítás = new Button();
            buttonSzerkesztés = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)futókBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonBetöltés
            // 
            buttonBetöltés.Location = new Point(676, 12);
            buttonBetöltés.Name = "buttonBetöltés";
            buttonBetöltés.Size = new Size(112, 34);
            buttonBetöltés.TabIndex = 0;
            buttonBetöltés.Text = "Betöltés";
            buttonBetöltés.UseVisualStyleBackColor = true;
            buttonBetöltés.Click += buttonBetöltés_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = futókBindingSource;
            dataGridView1.Location = new Point(12, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 225);
            dataGridView1.TabIndex = 1;
            // 
            // buttonMentés
            // 
            buttonMentés.Location = new Point(535, 12);
            buttonMentés.Name = "buttonMentés";
            buttonMentés.Size = new Size(112, 34);
            buttonMentés.TabIndex = 2;
            buttonMentés.Text = "Mentés";
            buttonMentés.UseVisualStyleBackColor = true;
            buttonMentés.Click += buttonMentés_Click;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futókBindingSource, "Nev", true));
            textBox1.Location = new Point(12, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(527, 31);
            textBox1.TabIndex = 3;
            // 
            // buttonTörlés
            // 
            buttonTörlés.Location = new Point(12, 12);
            buttonTörlés.Name = "buttonTörlés";
            buttonTörlés.Size = new Size(112, 34);
            buttonTörlés.TabIndex = 4;
            buttonTörlés.Text = "Törlés";
            buttonTörlés.UseVisualStyleBackColor = true;
            buttonTörlés.Click += buttonTörlés_Click;
            // 
            // buttonÚj
            // 
            buttonÚj.Location = new Point(157, 12);
            buttonÚj.Name = "buttonÚj";
            buttonÚj.Size = new Size(112, 34);
            buttonÚj.TabIndex = 5;
            buttonÚj.Text = "Új";
            buttonÚj.UseVisualStyleBackColor = true;
            buttonÚj.Click += buttonÚj_Click;
            // 
            // buttonSzámítás
            // 
            buttonSzámítás.Location = new Point(12, 73);
            buttonSzámítás.Name = "buttonSzámítás";
            buttonSzámítás.Size = new Size(112, 34);
            buttonSzámítás.TabIndex = 6;
            buttonSzámítás.Text = "Számítás";
            buttonSzámítás.UseVisualStyleBackColor = true;
            buttonSzámítás.Click += buttonSzámítás_Click;
            // 
            // buttonSzerkesztés
            // 
            buttonSzerkesztés.Location = new Point(302, 12);
            buttonSzerkesztés.Name = "buttonSzerkesztés";
            buttonSzerkesztés.Size = new Size(112, 34);
            buttonSzerkesztés.TabIndex = 7;
            buttonSzerkesztés.Text = "Szerkesztés";
            buttonSzerkesztés.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSzerkesztés);
            Controls.Add(buttonSzámítás);
            Controls.Add(buttonÚj);
            Controls.Add(buttonTörlés);
            Controls.Add(textBox1);
            Controls.Add(buttonMentés);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBetöltés);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)futókBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBetöltés;
        private DataGridView dataGridView1;
        private Button buttonMentés;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource futókBindingSource;
        private TextBox textBox1;
        private Button buttonTörlés;
        private Button buttonÚj;
        private Button buttonSzámítás;
        private Button buttonSzerkesztés;
    }
}
