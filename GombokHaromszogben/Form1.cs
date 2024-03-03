namespace GombokHaromszogben
{
    public partial class Form1 : Form
    {
        const int gridSize = 10;
        public Form1()
        {
            InitializeComponent();
            CreateButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void CreateButtons()
        {
            const int buttonSize = 30; // A gombok m�rete
            const int startX = 20; // A gombok elhelyezked�s�nek kiindul� X koordin�t�ja
            const int startY = 20; // A gombok elhelyezked�s�nek kiindul� Y koordin�t�ja

            // M�trix l�trehoz�sa
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    // Csak a f?�tl�ban l�v?k �s a f?�tl� alattiak jelennek meg
                    if (i == j || i > j)
                    {
                        Button button = new Button();
                        button.Size = new Size(buttonSize, buttonSize);
                        button.Location = new Point(startX + j * (buttonSize + 5), startY + i * (buttonSize + 5));
                        button.Text = "(" + i + "," + j + ")"; // A gomb sz�vege az indexek
                        this.Controls.Add(button);
                    }
                }
            }
        }
    }
}
