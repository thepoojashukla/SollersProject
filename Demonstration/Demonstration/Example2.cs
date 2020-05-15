using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Demonstration
{
    class Example2
    {
        public static void ExecuteExample()
        {
            Type m = typeof(nClass);
            foreach(object obj in m.GetCustomAttributes(true))
            {
                Console.WriteLine(obj);
            }

            foreach(MethodInfo meth in m.GetMethods())
            {
               object[] obj= meth.GetCustomAttributes(true);
                foreach(Attribute atr in obj)
                {
                    Console.WriteLine(atr);
                }
            }
        }
          
    }

    [AttributeUsage(AttributeTargets.All)]
    class PoojaShukla :System.Attribute
    {
        string s1, s2;
        int i;

        public PoojaShukla(string s , string st)
        {
            s1 = s;
            s2 = st;
        }
        public string name
        {
            get
            {
                return "Pooja";
            }
            set
            {
                ;
            }
        }
    }
    [PoojaShukla("Hello","There", name = "Abhinav")]
    public class nClass
    {
        [PoojaShukla("Hello1", "NotThere", name = "Nitin")]
        public void abc() { }
        public int i;
        public void pqr() { }
    }
}
