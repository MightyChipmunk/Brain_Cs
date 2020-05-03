using System;

namespace Brain_Cs
{
    class NameCard
    {
        private int age;
        private string name;
        public int Age
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
    }

    class MainApp {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard();

            MyCard.Age = 24;
            MyCard.Name = "상현";

            Console.WriteLine("나이: {0}", MyCard.Age);
            Console.WriteLine("이름: {0}", MyCard.Name);

            var nameCard = new { Name = "박상현", Age = 17 };
            Console.WriteLine("이름: {0}, 나이: {1}", nameCard.Name, nameCard.Age);

            var complex = new { Real = 3, Imaginary = -12};
            Console.WriteLine("Real: {0}, Imaginary: {1}", complex.Real, complex.Imaginary);
        }
    }

}