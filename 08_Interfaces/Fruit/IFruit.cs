using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    //naming convention for interfaces: I____
    public interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get; }

        
        //methods in interfaces
        //can only set the return type, name, and parameters

        string Peel();
    }
}
