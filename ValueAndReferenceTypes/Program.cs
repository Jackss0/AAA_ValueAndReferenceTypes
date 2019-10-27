using System;

namespace ValueAndReferenceTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Value Types --> Stack
    public class TypeValues
    { 
        //Numeric types
        int IntNumber { get; set; } = 2;
        double DoubleNumber { get; set; } = 2.1;
        float FloatNumber { get; set; } = 3_00.5F;

        //Booleans, chars and Dates
        bool BooleanValue = true;
        char CharValue = 'D';

        //structures
        struct SomeStructure
        {
            //This prop is a reference type :D
            string TypeReference { get; set; }
        }
        //Emuns
        public enum MyEnum
        {
            Value1 = 1,
            Value2 = 2
        }
        //Other ways
        decimal DecimalProp = new decimal(2,1,2,false,byte.MinValue);
    }

    //Reference Types --> Heap
    public class ReferenceTypes
    {
        //Strings 
        public string StringReference { get; set; }

        //Clases 
        public class MyClass
        {
            //this is goin to the heap even if 
            //there's value types
            public int IntProperty { get; set; }
        }
    }
}
