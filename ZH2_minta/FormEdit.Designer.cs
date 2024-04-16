namespace ZH2_minta
{
    partial class FormEdit
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
            components = new System.ComponentModel.Container();
            buttonClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            vizsgaKérdésBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(676, 404);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(112, 34);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "&Ok";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 1;
            label1.Text = "Sorszám:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 9);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 2;
            label2.Text = "Kérdés szövege:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "1. válasz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 4;
            label4.Text = "2. válasz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 225);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 5;
            label5.Text = "3. válasz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 304);
            label6.Name = "label6";
            label6.Size = new Size(116, 25);
            label6.TabIndex = 6;
            label6.Text = "Helyes válasz";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "Szam", true));
            textBox1.Location = new Point(115, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // vizsgaKérdésBindingSource
            // 
            vizsgaKérdésBindingSource.DataSource = typeof(VizsgaKérdés);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V1", true));
            textBox2.Location = new Point(115, 90);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(337, 46);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V2", true));
            textBox3.Location = new Point(115, 156);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(333, 46);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V3", true));
            textBox4.Location = new Point(115, 225);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(333, 46);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "HelyesValasz", true));
            textBox5.Location = new Point(128, 304);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(320, 46);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "Kerdes", true));
            textBox6.Location = new Point(454, 12);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(334, 46);
            textBox6.TabIndex = 12;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonClose);
            Name = "FormEdit";
            Text = "FormEdit";
            Load += FormEdit_Load;
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private BindingSource vizsgaKérdésBindingSource;
    }
}