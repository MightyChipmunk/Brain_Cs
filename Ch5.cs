using System;

namespace Brain_Cs
{
    class BrainCs
    {
        static void Main(string[] args)
        {
            int cnt;
            while (true)
            {
                Console.WriteLine("반복 횟수를 입력하세요.");
                string scnt = Console.ReadLine();
                cnt = Convert.ToInt32(scnt);

                if (cnt <= 0)
                {
                    Console.WriteLine("0보다 작은 수는 입력 할 수 없습니다.\n");

                }
                else
                    break;
            }

            for(int i = 0; i < cnt; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}