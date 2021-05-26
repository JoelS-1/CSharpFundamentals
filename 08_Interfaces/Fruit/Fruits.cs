using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruit
{
    public class Banana : IFruit
    {
        //constructors
        public Banana() { }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        //properties
        public string Name 
        { 
            get
            {
                return "Banana";
            }
        }
       public bool IsPeeled { get; private set; }

        //class method
       public string Peel()
        {
            IsPeeled = true;
            return "You peeled the banana";
        }
    }

    public class Orange : IFruit
    {
        //contructors
        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        //properties
        public string Name
        {
            get
            {
                return "Orange";
            }
        }
        public bool IsPeeled { get; private set; }

        //class method
        // use the same interface method but bodies can be different as long as the return type matches
        public string Peel()
        {
            if (IsPeeled)
            {
               return "It's already peeled";
            }
            else
            {
                IsPeeled = true;
                return "You peeled the orange";
            }
        }

        //classes that use interfaces can still have unique properties and methods
        public string Squeeze()
        {
            return "You squeeze the orane, and juice comes out";
        }

        public class Grape : IFruit
        {
            public string Name
            {
                get
                {
                    return "Grape";
                }
            }
            //hardsetting to false becasue you do not peel grapes
            public bool IsPeeled { get; } = false;

            public string Peel()
            {
                return "Who peels grapes?";
            }
        }

        //make and apple class inheriting from IFruit
        public class Apple : IFruit
        {
            //constructor
            //using lambda or 'phat arrow'
            public Apple() { }
            public Apple(bool isSliced)
            {
                IsSliced = isSliced;
            }

            //properties
            public string Name => "Apple";

            public bool IsPeeled { get; private set; }

            public bool IsSliced { get; private set; }

            //methods
            //hardset method
            public string Peel()
            {
                if (IsPeeled)
                {
                    return "You have already peeled the apple";
                }
                else
                {
                    IsPeeled = true;
                    return "You have now peeled the apple. Ready for pies!";
                }

            }
            public string Slice()
            {
                if (IsSliced)
                {
                    return "You have already sliced the apple";
                }
                else{
                    IsSliced = true;
                    return "You have now sliced the apple";
                }
            }
            public string Compare(Orange orange)
            {
                return "You can't compare these";
            }

        }
    }
}
