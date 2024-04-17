namespace MintaZH
{
    partial class FormÚjFutó
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
            buttonMégse = new Button();
            textBox1 = new TextBox();
            futókBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)futókBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk.DialogResult = DialogResult.OK;
            buttonOk.Location = new Point(858, 404);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 0;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonMégse
            // 
            buttonMégse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonMégse.DialogResult = DialogResult.Cancel;
            buttonMégse.Location = new Point(740, 404);
            buttonMégse.Name = "buttonMégse";
            buttonMégse.Size = new Size(112, 34);
            buttonMégse.TabIndex = 1;
            buttonMégse.Text = "Mégse";
            buttonMégse.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", futókBindingSource, "VersenyzoID", true));
            textBox1.Location = new Point(12, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(429, 31);
            textBox1.TabIndex = 2;
            // 
            // futókBindingSource
            // 
            futókBindingSource.DataSource = typeof(Futók);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", futókBindingSource, "Nev", true));
            textBox2.Location = new Point(12, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(429, 31);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", futókBindingSource, "Nemzetiseg", true));
            textBox3.Location = new Point(12, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(429, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", futókBindingSource, "EredmenyPerc", true));
            textBox4.Location = new Point(511, 79);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(429, 31);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", futókBindingSource, "Kategoria", true));
            textBox5.Location = new Point(511, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(429, 31);
            textBox5.TabIndex = 6;
            // 
            // FormÚjFutó
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 450);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonMégse);
            Controls.Add(buttonOk);
            Name = "FormÚjFutó";
            Text = "FormÚjFutó";
            Load += FormÚjFutó_Load;
            ((System.ComponentModel.ISupportInitialize)futókBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonMégse;
        private TextBox textBox1;
        private TextBox textBox2;
        private BindingSource futókBindingSource;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}