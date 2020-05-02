using System;

using System;
using System.ComponentModel.DataAnnotations;

namespace Brain_Cs
{
    class BrainCs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("사각형의 너비를 입력하세요.");
            String width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            String height = Console.ReadLine();

            int area = int.Parse(width) * int.Parse(height);
            Console.WriteLine(area);
        }
    }

}