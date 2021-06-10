using System;
using System.Collections;
using System.Collections.Generic;


using System.Diagnostics;

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

    [DebuggerDisplay("Count = {x}")]
    class Secret
    {
        private int S1, S2;
        public Secret(int a, int b)
        {
            S1 = 2 * a;
            S2 = b + 3;
        }
        // Noch ne änderung
        // Noch ne änderung 2

        private int x { get => S1; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDo x = new B();

            TokenType PO = TokenType.PlusOp;

            Dictionary<int, string> Dic = new Dictionary<int, string>();
            Dic.Add(0, "Hi");


            Secret S = new Secret(1, 2);


            //if (PO & TokenCategory.MathOperator != 0)
            //    Console.WriteLine("hi");

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

