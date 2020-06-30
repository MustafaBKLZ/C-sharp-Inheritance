using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_Inheritance.Inheritance.Cokgen
{
    public class Dikdortgen : Cokgen
    {
        public Dikdortgen() { }
        public override double AlaniniBul(params double[] kenarlar)
        {
            return kenarlar[0] * kenarlar[1];
        }
        public override double CevresiniBul(params double[] kenarlar)
        {
            return 0;
        }
    }
}
