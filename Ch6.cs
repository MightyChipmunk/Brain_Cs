using System;

namespace Brain_Cs
{
    class BrainCs
    {
        static double Square(double arg)
        {
            return arg * arg;
        }

        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            double da, db, dc;
            Console.WriteLine("수를 입력하세요");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("결과 : {0}", Square(arg));

            string aa = Console.ReadLine();
            string bb = Console.ReadLine();
            a = Convert.ToInt32(aa);
            b = Convert.ToInt32(bb);
            da = Convert.ToDouble(aa);
            db = Convert.ToDouble(bb);
            Plus(a, b, out c);
            Plus(da, db, out dc);
            Console.WriteLine("{0} + {1} = {2}", a, b, c);
            Console.WriteLine("{0} + {1} = {2}", da, db, dc);
        }
    }

}