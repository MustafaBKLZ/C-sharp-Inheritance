using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_Inheritance.Inheritance.Cokgen
{
    public abstract class Cokgen
    {

        public Cokgen() { }

        public abstract double AlaniniBul(params double[] kenarlar);//dinamik parametre alan metod.
        public abstract double CevresiniBul(params double[] kenarlar);//dinamik parametre alan metod.


    }
}
