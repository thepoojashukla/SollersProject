#define Pooja
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ReflectionAttributeDemo
{
    class AttributeDemo
    {
        [Conditional("Pooja")]
        public void Abc()
        {
            Console.WriteLine("Print abc");
        }
    }

    [Debug]
    class Example3
    {

    }

    class Debug : System.Attribute
    {

    }

    //[A()]
    [A("HI", 1, name = "Pooja", number = 5)]
    class Example4
    {

    }
    class A : System.Attribute
    {
        public string name;
        public A()
        {

        }
        public A(int i)
        {

        }
        public A(string s)
        {

        }
        public A(string s, int i)
        {

        }
        public int number
        {
            get
            {
                return 10;
            }
            set
            {
                ;
            }
        }
    }

    class Example5
    {
        [Z("HI", 1, name = "Pooja", number = 5)]

        string number { get; set; }
    }

    [AttributeUsage(AttributeTargets.All)]
    class Z : System.Attribute
    {
        public string name;
        public Z()
        {

        }
        public Z(string s, int i)
        {

        }
        public int number
        {
            get
            {
                return 10;
            }
            set
            {
                ;
            }
        }
    }

    class Az
    {
        [Obsolete]
        public void Abc()
        {
            Console.WriteLine("It's obsolete");
        }
    }
}

