using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_Inheritance.Cokgen
{
    public class Kare : Cokgen
    {
        public Kare() { }
        public override double AlaniniBul(params double[] kenarlar)
        {
            return kenarlar[0] * kenarlar[0];
        }
        public override double CevresiniBul(params double[] kenarlar)
        {
            return 0;
        }
    }
}
