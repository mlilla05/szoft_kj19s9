using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MINTA_ZH2_GYAK
{
    public partial class FormSzerkesztes : Form
    {
        public Verseny SzerkesztesVerseny = new Verseny();
        public FormSzerkesztes()
        {
            InitializeComponent();
        }

        private void FormSzerkesztes_Load(object sender, EventArgs e)
        {
            versenyBindingSource.DataSource = SzerkesztesVerseny;
        }
    }
}
