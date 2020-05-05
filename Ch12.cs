using System;

namespace Brain_Cs
{

    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i =0; i < 10; i++)
            {
                arr[i] = i;
            }

            try
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(arr[i]);
                    if(arr[i] == null)
                    {
                        throw new Exception();
                    }
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine("인덱스가 배열 범위를 벗어났습니다.");
            }
        }
    }

}