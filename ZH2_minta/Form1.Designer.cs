﻿namespace ZH2_minta
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
            dataGridView1 = new DataGridView();
            szamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kerdesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            helyesValaszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            buttonOpen = new Button();
            buttonSave = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            buttonDelete = new Button();
            buttonAddNew = new Button();
            buttonEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { szamDataGridViewTextBoxColumn, kerdesDataGridViewTextBoxColumn, v1DataGridViewTextBoxColumn, v2DataGridViewTextBoxColumn, v3DataGridViewTextBoxColumn, kepDataGridViewTextBoxColumn, helyesValaszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(42, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(478, 315);
            dataGridView1.TabIndex = 0;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            szamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            szamDataGridViewTextBoxColumn.MinimumWidth = 8;
            szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            szamDataGridViewTextBoxColumn.ReadOnly = true;
            szamDataGridViewTextBoxColumn.Width = 90;
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            kerdesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            kerdesDataGridViewTextBoxColumn.MinimumWidth = 8;
            kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            kerdesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // v1DataGridViewTextBoxColumn
            // 
            v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            v1DataGridViewTextBoxColumn.HeaderText = "V1";
            v1DataGridViewTextBoxColumn.MinimumWidth = 8;
            v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            v1DataGridViewTextBoxColumn.ReadOnly = true;
            v1DataGridViewTextBoxColumn.Visible = false;
            v1DataGridViewTextBoxColumn.Width = 150;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            v2DataGridViewTextBoxColumn.HeaderText = "V2";
            v2DataGridViewTextBoxColumn.MinimumWidth = 8;
            v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            v2DataGridViewTextBoxColumn.ReadOnly = true;
            v2DataGridViewTextBoxColumn.Visible = false;
            v2DataGridViewTextBoxColumn.Width = 150;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            v3DataGridViewTextBoxColumn.HeaderText = "V3";
            v3DataGridViewTextBoxColumn.MinimumWidth = 8;
            v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            v3DataGridViewTextBoxColumn.ReadOnly = true;
            v3DataGridViewTextBoxColumn.Visible = false;
            v3DataGridViewTextBoxColumn.Width = 150;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            kepDataGridViewTextBoxColumn.MinimumWidth = 8;
            kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            kepDataGridViewTextBoxColumn.ReadOnly = true;
            kepDataGridViewTextBoxColumn.Visible = false;
            kepDataGridViewTextBoxColumn.Width = 150;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.MinimumWidth = 8;
            helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            helyesValaszDataGridViewTextBoxColumn.ReadOnly = true;
            helyesValaszDataGridViewTextBoxColumn.Visible = false;
            helyesValaszDataGridViewTextBoxColumn.Width = 150;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(VizsgaKérdés);
            // 
            // buttonOpen
            // 
            buttonOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen.Location = new Point(943, 12);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(112, 34);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Megnyitás";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.Location = new Point(799, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 34);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Kerdes", true));
            textBox1.Location = new Point(590, 96);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 46);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "V1", true));
            textBox2.Location = new Point(590, 186);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(465, 46);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "V2", true));
            textBox3.Location = new Point(590, 278);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(465, 46);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "V3", true));
            textBox4.Location = new Point(590, 365);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(465, 46);
            textBox4.TabIndex = 6;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(42, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(193, 12);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(112, 34);
            buttonAddNew.TabIndex = 8;
            buttonAddNew.Text = "Új";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(345, 12);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(112, 34);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Szerkesztés";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAddNew);
            Controls.Add(buttonDelete);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonOpen;
        private Button buttonSave;
        private BindingSource bindingSource1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private Button buttonDelete;
        private Button buttonAddNew;
        private Button buttonEdit;
    }
}
