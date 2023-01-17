namespace Day_13_Generics_Max_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem using Generics!!!");
            Console.WriteLine("1.Compare three integer numbers");
            Console.WriteLine("Please choose the option to execute : ");

            int option = Convert.ToInt32(Console.ReadLine());

            while (option < 1 || option > 7)
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            switch (option)
            {

                case 1:
                    Console.WriteLine("Executing three test cases for Finding Maximum Integer Value");
                    Console.WriteLine(MaximumInteger.MaxIntegerNumber(20, 20, 20));
                    Console.WriteLine(MaximumInteger.MaxIntegerNumber(65, 20, 10));
                    Console.WriteLine(MaximumInteger.MaxIntegerNumber(5, 45, 98));
                    break;
            }
        }
    }
}