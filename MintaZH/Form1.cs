using System.ComponentModel;
using System.Globalization;
using CsvHelper;

namespace MintaZH
{
    public partial class Form1 : Form
    {
        BindingList<Futók> futók = new(); //osztalyszinten kell!, ha nem ajlanlja fel: villanykorte
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBetöltés_Click(object sender, EventArgs e)
        {
            try
            {
                //Beolvasas:
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var tömb = csv.GetRecords<Futók>();
                foreach (var item in tömb)
                {
                    futók.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = futók; //!!!elején: dataGridView1, kesobb futókBindingSource
            futókBindingSource.DataSource = futók;
        }

        private void buttonMentés_Click(object sender, EventArgs e)
        {
            //Mentes:
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futók);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTörlés_Click(object sender, EventArgs e)
        {
            //Torles:
            if (futókBindingSource.Current == null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    futókBindingSource.RemoveCurrent();
                }

            }
        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            //Új:
            FormÚjFutó formÚjFutó = new FormÚjFutó();
            if (formÚjFutó.ShowDialog() == DialogResult.OK)
            {
                futókBindingSource.Add(formÚjFutó.ÚjFutó);
            }
        }

        private void buttonSzámítás_Click(object sender, EventArgs e)
        {
            //Szamitasok:
            //Atlag:
            double összeg = 0;
            int db = 0;
            foreach (var item in futók)
            {
                if (item.Nemzetiseg == "USA")
                {
                    összeg += item.EredmenyPerc;
                    db = db + 1;
                }
            }
            double átlag = összeg / db;
            //double átlag = összeg / futók.Count();
            //Minimum:
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty; 
            foreach (var item in futók)
            {
                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb = item.Nev;
                }
            }
            MessageBox.Show($"A legjobb ido: {minimum}");
        }
    }
}
