using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzámolóGomb : VillogoGomb
    {
        int szám = 0;
        public SzámolóGomb()
        {
            MouseClick += SzámolóGomb_MouseClick;
        }

        private void SzámolóGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szám == 5)
            {
                szám = 0;
            }
            szám = szám + 1;
            Text = szám.ToString();
            

        }
    }
}
