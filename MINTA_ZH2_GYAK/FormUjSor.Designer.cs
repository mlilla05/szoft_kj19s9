﻿namespace MINTA_ZH2_GYAK
{
    partial class FormUjSor
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
            buttonOk = new Button();
            buttonMegse = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            versenyBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)versenyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(676, 404);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonMegse
            // 
            buttonMegse.DialogResult = DialogResult.Cancel;
            buttonMegse.Location = new Point(542, 404);
            buttonMegse.Name = "buttonMegse";
            buttonMegse.Size = new Size(112, 34);
            buttonMegse.TabIndex = 1;
            buttonMegse.Text = "Mégse";
            buttonMegse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", versenyBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(12, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", versenyBindingSource, "Nev", true));
            textBox2.Location = new Point(12, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(368, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", versenyBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(12, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(368, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", versenyBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(12, 222);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(368, 31);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", versenyBindingSource, "Kategoria", true));
            textBox5.Location = new Point(12, 289);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(368, 31);
            textBox5.TabIndex = 6;
            // 
            // versenyBindingSource
            // 
            versenyBindingSource.DataSource = typeof(Verseny);
            // 
            // FormUjSor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonMegse);
            Controls.Add(buttonOk);
            Name = "FormUjSor";
            Text = "FormUjSor";
            Load += FormUjSor_Load;
            ((System.ComponentModel.ISupportInitialize)versenyBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonMegse;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private BindingSource versenyBindingSource;
    }
}