namespace MintaZH
{
    partial class FormSzerkesztés
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            buttonOk = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(369, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(369, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(419, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(369, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(419, 167);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(369, 31);
            textBox5.TabIndex = 4;
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(676, 404);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "&Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 6;
            label1.Text = "Versenyző azonosító:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 7;
            label2.Text = "Név:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 261);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 8;
            label3.Tag = "";
            label3.Text = "Nemzetiség:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 25);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 9;
            label4.Text = "Eredmény Perc:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(419, 139);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 10;
            label5.Text = "Kategória:";
            // 
            // FormSzerkesztés
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonOk);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormSzerkesztés";
            Text = "FormSzerkesztés";
            Load += FormSzerkesztés_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button buttonOk;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}