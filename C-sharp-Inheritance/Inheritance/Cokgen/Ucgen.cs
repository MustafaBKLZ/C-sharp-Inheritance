using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_Inheritance.Inheritance.Cokgen
{
    public class Ucgen : Cokgen
    {
        public Ucgen() { }

        public override double AlaniniBul(params double[] kenarlar)
        {
            double s = (kenarlar[0] + kenarlar[1] + kenarlar[2]) / 2;
            double d = Math.Sqrt(s * (s - kenarlar[0]) * (s - kenarlar[1]) * (s - kenarlar[2]));
            return d;
        }

        public override double CevresiniBul(params double[] kenarlar)
        {
            return 0;
        }
    }
}
