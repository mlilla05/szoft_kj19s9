using System.Windows.Forms;

namespace HitelKiszámítás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal hitelÖsszeg = decimal.Parse(tbHitelÖsszege.Text);
            decimal haviKamat = decimal.Parse(tbHaviKamat.Text);
            decimal haviTörlesztő = decimal.Parse(cbHaviTörlesztő.Text);

            decimal hátralék = hitelÖsszeg;
            decimal befizetés = 0;

            List<Sor> sorok = new List<Sor>();

            int hónap = 1;
            while (hátralék > 0)
            {
                hátralék += haviKamat * (hátralék / 100m);
                hátralék -= haviTörlesztő;
                befizetés += haviTörlesztő;
                hónap++;

                Sor újSor = new Sor();
                újSor.Hátralék = Math.Round(hátralék);
                újSor.Hónap = hónap;

                sorok.Add(újSor);
            }

            dataGridView1.DataSource = sorok;
        }
    }
}
