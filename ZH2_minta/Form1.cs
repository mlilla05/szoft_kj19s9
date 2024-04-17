using System.ComponentModel;
using System.Globalization;
using CsvHelper;
using Microsoft.VisualBasic;

namespace ZH2_minta
{
    public partial class Form1 : Form
    {
        BindingList<VizsgaK�rd�s> k�rd�sek = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_coma.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture milyen nyelvi saj�toss�gok: angol
                //CsvReader csv = new CsvReader(sr, CultureInfo.InvariantCulture); var b�rmi lehet
                var t�mb = csv.GetRecords<VizsgaK�rd�s>();
                foreach (var item in t�mb)
                {
                    k�rd�sek.Add(item);
                }
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = k�rd�sek;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(k�rd�sek);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bindingSource1.RemoveCurrent();
                }
            }
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            FormAddNew formAddNew = new FormAddNew();
            if (formAddNew.ShowDialog() == DialogResult.OK)
            {
                //formAddNew.ShowDialog();
                //formAddNew.Show(); oldalra lehet kattintani
                bindingSource1.Add(formAddNew.�jvizsgaK�rd�s);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
            {
                return;
            }
            else
            {
                FormEdit formEdit = new FormEdit();
                formEdit.�jVizsgaK�rd�s = bindingSource1.Current as VizsgaK�rd�s;
                //formEdit.�jVizsgaK�rd�s = (VizsgaK�rd�s)bindingSource1.Current;
                formEdit.Show();
            }
        }
    }
}
