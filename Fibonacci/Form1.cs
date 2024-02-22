namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();
            for (int i = 0; i < 10; i++)
            {
                Sor újSor = new Sor();
                újSor.Sorszám = i;
                újSor.Érték = Fibonacci(i);
                sorok.Add(újSor);

                Button button = new Button();
                //button.Left = i * 0;
                button.Top = i * 50;
                button.Width = 50;
                button.Height = 50;
                button.Text = (Fibonacci(i)).ToString();
                Controls.Add(button);
            }
            dataGridView1.DataSource = sorok;
        }
        int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}