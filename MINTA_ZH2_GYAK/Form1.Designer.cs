namespace MINTA_ZH2_GYAK
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
            versenyzoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyPercDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            versenyBindingSource = new BindingSource(components);
            buttonBetoltes = new Button();
            buttonMentes = new Button();
            buttonTorles = new Button();
            buttonUj = new Button();
            buttonSzerkesztes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)versenyBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { versenyzoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn, eredmenyPercDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = versenyBindingSource;
            dataGridView1.Location = new Point(12, 257);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1077, 253);
            dataGridView1.TabIndex = 0;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            versenyzoIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 8;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 150;
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.MinimumWidth = 8;
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            nemzetisegDataGridViewTextBoxColumn.Width = 150;
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.MinimumWidth = 8;
            eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            eredmenyPercDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // versenyBindingSource
            // 
            versenyBindingSource.DataSource = typeof(Verseny);
            // 
            // buttonBetoltes
            // 
            buttonBetoltes.Location = new Point(986, 12);
            buttonBetoltes.Name = "buttonBetoltes";
            buttonBetoltes.Size = new Size(112, 34);
            buttonBetoltes.TabIndex = 1;
            buttonBetoltes.Text = "Betöltés";
            buttonBetoltes.UseVisualStyleBackColor = true;
            buttonBetoltes.Click += buttonBetoltes_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(833, 12);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(112, 34);
            buttonMentes.TabIndex = 2;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(669, 12);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(112, 34);
            buttonTorles.TabIndex = 3;
            buttonTorles.Text = "Törlés";
            buttonTorles.UseVisualStyleBackColor = true;
            buttonTorles.Click += buttonTorles_Click;
            // 
            // buttonUj
            // 
            buttonUj.Location = new Point(523, 12);
            buttonUj.Name = "buttonUj";
            buttonUj.Size = new Size(112, 34);
            buttonUj.TabIndex = 4;
            buttonUj.Text = "Új";
            buttonUj.UseVisualStyleBackColor = true;
            buttonUj.Click += buttonUj_Click;
            // 
            // buttonSzerkesztes
            // 
            buttonSzerkesztes.Location = new Point(372, 12);
            buttonSzerkesztes.Name = "buttonSzerkesztes";
            buttonSzerkesztes.Size = new Size(112, 34);
            buttonSzerkesztes.TabIndex = 5;
            buttonSzerkesztes.Text = "Szerkesztés";
            buttonSzerkesztes.UseVisualStyleBackColor = true;
            buttonSzerkesztes.Click += buttonSzerkesztes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 522);
            Controls.Add(buttonSzerkesztes);
            Controls.Add(buttonUj);
            Controls.Add(buttonTorles);
            Controls.Add(buttonMentes);
            Controls.Add(buttonBetoltes);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "s";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)versenyBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonBetoltes;
        private Button buttonMentes;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource versenyBindingSource;
        private Button buttonTorles;
        private Button buttonUj;
        private Button buttonSzerkesztes;
    }
}
