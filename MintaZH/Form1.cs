using System.ComponentModel;
using System.Globalization;
using CsvHelper;

namespace MintaZH
{
    public partial class Form1 : Form
    {
        BindingList<Fut�k> fut�k = new(); //osztalyszinten kell!, ha nem ajlanlja fel: villanykorte
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBet�lt�s_Click(object sender, EventArgs e)
        {
            try
            {
                //Beolvasas:
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t�mb = csv.GetRecords<Fut�k>();
                foreach (var item in t�mb)
                {
                    fut�k.Add(item);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = fut�k; //!!!elej�n: dataGridView1, kesobb fut�kBindingSource
            fut�kBindingSource.DataSource = fut�k;
        }

        private void buttonMent�s_Click(object sender, EventArgs e)
        {
            //Mentes:
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(fut�k);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonT�rl�s_Click(object sender, EventArgs e)
        {
            //Torles:
            if (fut�kBindingSource.Current == null)
            {
                return;
            }
            else
            {
                if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    fut�kBindingSource.RemoveCurrent();
                }

            }
        }

        private void button�j_Click(object sender, EventArgs e)
        {
            //�j:
            Form�jFut� form�jFut� = new Form�jFut�();
            if (form�jFut�.ShowDialog() == DialogResult.OK)
            {
                fut�kBindingSource.Add(form�jFut�.�jFut�);
            }
        }

        private void buttonSz�m�t�s_Click(object sender, EventArgs e)
        {
            //Szamitasok:
            //Atlag:
            double �sszeg = 0;
            int db = 0;
            foreach (var item in fut�k)
            {
                if (item.Nemzetiseg == "USA")
                {
                    �sszeg += item.EredmenyPerc;
                    db = db + 1;
                }
            }
            double �tlag = �sszeg / db;
            //double �tlag = �sszeg / fut�k.Count();
            //Minimum:
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty; 
            foreach (var item in fut�k)
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
