namespace KígyósJáték
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fej_x = 100;
        int fej_y = 100;
        int irány_x = 1;
        int irány_y = 0;
        int lépésszám = 0;
        Random rnd = new Random();
        List<KígyóElem> kígyó = new();
        int hossz = 10;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class KígyóElem : PictureBox
        {
            public static int Méret = 20;
            public KígyóElem()
            {
                Width = KígyóElem.Méret;
                Height = KígyóElem.Méret;
                BackColor = Color.Fuchsia;
            }
        }
        class Alma : PictureBox
        {
            public static int Méret_alma = 20;
            public Alma()
            {
                Width = Alma.Méret_alma;
                Height = Alma.Méret_alma;
                BackColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;
            fej_x += irány_x * KígyóElem.Méret;
            fej_y += irány_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    {
                        timer1.Enabled = false;
                        return;
                    }
                }
            }
            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);
            kígyó.Add(ke);
            if (Controls.Count > hossz)
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }
            if (lépésszám % 2 == 0)
            {
                ke.BackColor = Color.Yellow;
            }
            if (lépésszám % 5 == 0)
            {
                Alma alma = new Alma();
                int alma_x = rnd.Next(0, 25) * 20;
                int alma_y = rnd.Next(0, 25) * 20;
                alma.Top = alma_x;
                alma.Left = alma_y;
                Controls.Add(alma);
            }
            foreach (object item in Controls)
            {
                if (item is Alma)
                {
                    Alma a = (Alma)item;
                    if (a.Top == fej_y && a.Left == fej_x)
                    {
                        hossz++;
                        Controls.Remove(a);
                        Controls.Add(ke);
                        kígyó.Add(ke);
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                irány_y = -1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irány_y = 1;
                irány_x = 0;
            }
            if (e.KeyCode == Keys.Left)
            {
                irány_y = 0;
                irány_x = -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                irány_y = 0;
                irány_x = 1;
            }
        }
    }
}