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
            dataGridView1.DataSource = k�rd�sek;
        }
    }
}
