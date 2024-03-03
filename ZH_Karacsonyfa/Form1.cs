namespace ZH_Karacsonyfa
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
            for (int sor = 0; sor < 11; sor++)
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
                    if (sor < 10)
                    {
                        Controls.Add(button);
                        button.BackColor = Color.Green;
                    }
                    if (sor == 10)
                    {
                        if(oszlop == 5)
                        {
                            Controls.Add(button);
                            button.BackColor = Color.Brown;
                        }
                    }
                }
            }
        }
    }
}
