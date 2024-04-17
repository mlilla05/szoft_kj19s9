namespace ZH2_minta
{
    partial class FormAddNew
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            vizsgaKérdésBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(676, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "&Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(538, 404);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Mégse";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "Szam", true));
            textBox1.Location = new Point(12, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(365, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "Kerdes", true));
            textBox2.Location = new Point(12, 248);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V1", true));
            textBox3.Location = new Point(423, 52);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(365, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V2", true));
            textBox4.Location = new Point(423, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(365, 31);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "V3", true));
            textBox5.Location = new Point(423, 248);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(365, 31);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", vizsgaKérdésBindingSource, "HelyesValasz", true));
            textBox6.Location = new Point(423, 341);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(365, 31);
            textBox6.TabIndex = 7;
            // 
            // vizsgaKérdésBindingSource
            // 
            vizsgaKérdésBindingSource.DataSource = typeof(VizsgaKérdés);
            // 
            // FormAddNew
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
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormAddNew";
            Text = "FormAddNew";
            Load += FormAddNew_Load;
            ((System.ComponentModel.ISupportInitialize)vizsgaKérdésBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private BindingSource vizsgaKérdésBindingSource;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}