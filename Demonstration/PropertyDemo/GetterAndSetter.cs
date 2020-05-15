using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    class GetterAndSetter
    {
        static int f1 = 0;
        public static int ff
        {
            get
            {
                Console.WriteLine("inside get");
                return f1;
            }

            set
            {
                Console.WriteLine("inside set");
                f1 = value;

            }
        }

        public static void GetterSetterMain()
        {
            ff = 100;
            Console.WriteLine(ff);
           
        }
    }
}
