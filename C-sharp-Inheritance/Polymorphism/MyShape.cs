using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_Inheritance.Polymorphism
{
    class MyShape : Interface.MyShapeWorks
    {
        public virtual object Draw()
        {
            return "";
        }
        public object Delete()
        {
            return this.GetType().Name + " Deleted";
        }
        public object Save()
        {
            return this.GetType().Name + " Saved";
        }
        public object Update()
        {
            return this.GetType().Name + " Updated";
        }





    }
}
