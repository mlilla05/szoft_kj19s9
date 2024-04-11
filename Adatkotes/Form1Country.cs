using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adatkotes
{
    public partial class Form1Country : Form
    {
        public CountryData EditedCountryData;
        public Form1Country()
        {
            InitializeComponent();
        }

        private void Form1Country_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = EditedCountryData;
        }
    }
}
