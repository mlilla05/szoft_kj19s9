namespace ZH_Gombok_Haromszogben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int m = 40;
            int db_oszlop = 0;
            for (int sor = 0; sor < 10; sor++)
            {
                db_oszlop = 0;
                for (int oszlop = 0; oszlop < sor + 1; oszlop++)
                {
                    db_oszlop = db_oszlop + 1;
                    Button button = new Button();
                    button.Top = sor * m;
                    button.Left = oszlop * m - sor * m / 2 + Width / 2;
                    button.Height = m;
                    button.Width = m;
                    if (db_oszlop == 1)
                    {
                        Controls.Add(button);
                    }
                    else if (db_oszlop == sor + 1)
                    {
                          Controls.Add(button);
                    }
                    if (sor == 9)
                    {
                        Controls.Add(button);
                    }
                }
            }
        }
    }
}

