namespace ZH_Veletlen_Gombok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Random rng = new Random();
                int width = rng.Next(20, 51);
                int height = rng.Next(20, 51);
                int top = rng.Next(this.ClientSize.Height - height);
                int left = rng.Next(this.ClientSize.Width - width);
                int r = rng.Next(256);
                int g = rng.Next(256);
                int b = rng.Next(256);
                Button veletlengomb = new Button();
                veletlengomb.Height = height;
                veletlengomb.Width = width;
                veletlengomb.Top = top;
                veletlengomb.Left = left;
                veletlengomb.BackColor = Color.FromArgb(r, g, b);
                this.Controls.Add(veletlengomb);
            }
        }
    }
}
