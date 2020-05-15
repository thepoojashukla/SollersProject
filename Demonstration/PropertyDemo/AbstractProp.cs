using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    abstract class AbstractProp
    {
        
        public abstract int i
        {

            get;

            set;

        }

    }
    class yyy : AbstractProp
    {
        public override int i
        {
            get
            {
                System.Console.WriteLine("get");
                return 10;
            }
            set
            {
                System.Console.WriteLine("set " + value);
            }
        }
    }

    class AbstractExample
    {

        public static void ExampleMain()

        {

            yyy a = new yyy();

            a.i = 100;

            System.Console.WriteLine(a.i);

        }

    }

}

