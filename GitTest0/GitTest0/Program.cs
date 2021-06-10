using System;

namespace GitTest0
{
    enum TokenCategory : int
    {
        MathOperator = 0x01000000,
        OtherCategory = 0x02000000,
    }
    enum TokenType : int
    {
        PlusOp = TokenCategory.MathOperator | 1,
        MinusOp = TokenCategory.MathOperator | 2,
        SomethingElse = TokenCategory.OtherCategory | 1,


    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDo x = new B();

            TokenType PO = TokenType.PlusOp;


            if (PO & TokenCategory.MathOperator != 0)
                Console.WriteLine("hi");

            Console.WriteLine(x.Do());

            Console.ReadKey(true);
        }
    }

    interface IDo
    {
        int Do();
    }
    class A : IDo
    {
        public int Do() => 5;
    }
    class B : IDo
    {
        public int Do() => 10;
    }
}

