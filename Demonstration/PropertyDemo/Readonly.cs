using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PropertyDemo
{
    //ReadOnly so only getter is present
    class Readonly
    {
        int f1 = 0;
        public int ff
        {
            get
            {
                Console.WriteLine("in get");
                return f1;
            }
        }

        public static void GetterName()
        {
            Readonly a = new Readonly();
            int x = a.ff + 9;
            Console.WriteLine(x);
            Method1();              //static method can only call static directly(eitherby class name or direct)
            a.Meth();               // static method calling non static only by instance creation
        }
        public void Meth()
        {
            int x = ff;
        }

        public static void Method1()
        {

        }
    }
}
