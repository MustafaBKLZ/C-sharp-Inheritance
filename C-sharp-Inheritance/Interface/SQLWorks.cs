using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_sharp_Inheritance.Interface
{
    interface SQLWorks
    {
        object Save();
        object Update(int id);
        object Delete(int id);
    }
}
