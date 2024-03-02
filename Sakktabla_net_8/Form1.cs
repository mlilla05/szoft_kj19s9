namespace Sakktabla_net_8
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
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button negyzet = new Button();
                    negyzet.Left = szam * i;
                    negyzet.Top = szam * j;
                    negyzet.Width = szam;
                    negyzet.Height = szam;
                    negyzet.BackColor = Color.Green;
                    Controls.Add(negyzet);
                    if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                    {
                        negyzet.BackColor = Color.Green;
                    }
                    else if ((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0))
                    {
                        negyzet.BackColor= Color.White;
                    }
                }
            }
        }
    }
}
