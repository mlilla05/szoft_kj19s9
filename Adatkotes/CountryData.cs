﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatkotes
{
    public class CountryData 
    {
        //Name,Population,AreaInSquareKm
        //prop tab tab (propeties)
        public string Name { get; set; } = string.Empty; //aláhúzás miatt
        public long Population { get; set; }
        public double AreaInSquareKm { get; set; }
    }
}
