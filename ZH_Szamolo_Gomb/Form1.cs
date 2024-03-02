namespace ZH_Szamolo_Gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int sz = 50;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    SzamoloGomb gomb = new SzamoloGomb();
                    gomb.Left = i * sz;
                    gomb.Top = j * sz;
                    Controls.Add(gomb);
                }
            }
        }

        class SzamoloGomb : Button
        {
            int szam = 1;
            public SzamoloGomb()
            {
                Height = 50;
                Width = 50;
                Text = szam.ToString();
                MouseClick += SzamoloGomb_MouseClick;
            }

            private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
            {
                BackColor = Color.Pink;
                szam = szam + 1;
                if (szam == 6)
                {
                    szam = 1;
                }
                Text = szam.ToString();
            }
        }
    }
}
