namespace ZH_Villogo_Gomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int szam = 50;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    VillogoGomb villogogomb = new VillogoGomb();
                    villogogomb.Left = i * szam;
                    villogogomb.Top = j * szam;
                    villogogomb.Height = szam;
                    villogogomb.Width = szam;
                    //villogogomb.Text = (i * j).ToString();
                    Controls.Add(villogogomb);
                }
            }
        }

        class VillogoGomb : Button
        {
            public VillogoGomb()
            {
                BackColor = Color.White;
                MouseEnter += VillogoGomb_MouseEnter;
                MouseLeave += VillogoGomb_MouseLeave;
            }

            private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
            {
                BackColor = Color.Red;
            }

            private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
            {
                BackColor = Color.Gray;
            }
        }
    }
}
