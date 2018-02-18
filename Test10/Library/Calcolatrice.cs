using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Calcolatrice
    {
        public static double Percentuale(double a)
        {
            double ris = 0;
            ris = a + ((a / 100) * 10);
            return ris;
        }
    }
}
