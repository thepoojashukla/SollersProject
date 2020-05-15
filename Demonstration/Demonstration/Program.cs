using System;
using System.Reflection;

namespace ReflectionAttributeDemo
{
    class Program
    {
        private static void Main()
        {
            Type t = Type.GetType("Demonstration.Example1"); //static method calling with class name Type
            //Type t = typeof(Example1);
            //Example1 ex = new Example1(); //if you create instance of a class we can call it with .GetType which is inherited from base Object Class
            //Type t = ex.GetType();
            Console.WriteLine(t.FullName);//returns full name of namespace + class
            Console.WriteLine(t.Name);//just name of class
            Console.WriteLine();
            PropertyInfo[] properties = t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.Name);     //returns name of all properties
                Console.WriteLine(property.PropertyType.Name); //returns type of the properties
            }
            Console.WriteLine("Get Methods");
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo method in methods)
            {

                Console.WriteLine(method.ReturnType.Name);//return return type of methods like void
                Console.WriteLine(method.Name);

            }
            Console.WriteLine("Get Constructor");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo constr in constructors)
            {

                Console.WriteLine(constr.ToString());//return return type of methods like void
                Console.WriteLine(constr.Name);

            }
            Console.WriteLine();
            MemberInfo[] n = t.GetMembers();
            Console.WriteLine(n.Length);
            foreach (MemberInfo a in n)
            {
                Console.WriteLine(a.Name);
            }


            // calling AttributeDemo class
            Az ex = new Az();
            //ex.Abc();
            AttributeDemo ex1 = new AttributeDemo();
            ex1.Abc();
            Console.WriteLine();
        }
    }
}
