using System;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Readonly.GetterName();                      
            GetterAndSetter.GetterSetterMain();
            OverrideProperty.OverridePropertyMain();
            AbstractExample.ExampleMain();

        }
    }
}
