using System.ComponentModel;
using System.Globalization;
using CsvHelper;

namespace MINTA_ZH2_GYAK
{
    public partial class Form1 : Form
    {
        BindingList<Verseny> versenyzok = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Verseny>();
                foreach (var item in tömb)
                {
                    versenyzok.Add(item);
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
            //dataGridView1.DataSource = versenyzok;
            versenyBindingSource.DataSource = versenyzok;
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    csv.WriteRecords(versenyzok);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (versenyBindingSource.Current == null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("Biztosan törölni szeretné?", "Sor törlése", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    versenyBindingSource.RemoveCurrent();
                }
            }
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            FormUjSor formUjSor = new FormUjSor();
            if (formUjSor.ShowDialog() == DialogResult.OK)
            {
                versenyBindingSource.Add(formUjSor.UjVerseny);
            }
        }

        private void buttonSzerkesztes_Click(object sender, EventArgs e)
        {
            if (versenyBindingSource.Current == null)
            {
                return;
            }
            else
            {
                FormSzerkesztes formSzerkesztes = new FormSzerkesztes();
                formSzerkesztes.SzerkesztesVerseny = versenyBindingSource.Current as Verseny;
                formSzerkesztes.Show();
            }
        }
    }
}
