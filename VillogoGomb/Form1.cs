namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button b = new Button();
            //Controls.Add(b);
            //b.Left = ClientRectangle.Width / 2 - b.Width / 2;
            //b.Top = ClientRectangle.Height / 2 - b.Height / 2;
            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    SzámolóGomb b = new SzámolóGomb();
                    b.Width = 20;
                    b.Height = 20;
                    b.Left = sor * b.Width;
                    b.Top = oszlop * b.Height;
                    Controls.Add(b);

                }
            }
        }
    }
}