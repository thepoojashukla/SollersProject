using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace ReflectionAttributeDemo
{
    public class Example1
    {
        public int id { get; set; }
        public string name { get; set; }

        public Example1()
        {
            this.id = -1;
            this.name = string.Empty;
        }
        public Example1(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public void PrintId()
        {
            Console.WriteLine(this.id);
        }
        public void PrintName()
        {
            Console.WriteLine(this.name);
        }

    }

}
