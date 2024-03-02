namespace ZH_Szinezo_Gomb
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
                    SzinezoGomb gomb = new SzinezoGomb();
                    gomb.Left = i * sz;
                    gomb.Top = j * sz;
                    //gomb.Height = sz;
                    //gomb.Width = sz;
                    gomb.Text = (i * j).ToString();
                    Controls.Add(gomb);
                }
            }
        }
        class SzinezoGomb : Button
        {
            public SzinezoGomb()
            {
                MouseClick += SzinezoGomb_MouseClick;
                Height = 50;
                Width = 50;
            }

            private void SzinezoGomb_MouseClick(object? sender, MouseEventArgs e)
            {
                BackColor = Color.Fuchsia;
            }
        }
    }
}
