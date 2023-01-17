namespace Day_13_Generics_Max_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Problem using Generics!!!");
            Console.WriteLine("1.Compare three integer numbers \n2.Compare three float numbers \n3.Compare three string values \n4.Compare three values using Generic Method \n5.Compare three values using Generic Class");
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
                case 2:
                    Console.WriteLine("Executing three test cases for Finding Maximum Float Value");
                    Console.WriteLine(MaximumFloats.MaxFloatNumber(34.2f, 25.7f, 20.5f));
                    Console.WriteLine(MaximumFloats.MaxFloatNumber(60f, 88.9f, 100.0f));
                    Console.WriteLine(MaximumFloats.MaxFloatNumber(5.5f, 45.5f, 2.9f));
                    break;
                case 3:
                    Console.WriteLine("Executing three test cases for Finding Maximum String Value");
                    Console.WriteLine(MaximumString.MaxStringValue("2", "40", "8"));
                    Console.WriteLine(MaximumString.MaxStringValue("1", "5", "6"));
                    Console.WriteLine(MaximumString.MaxStringValue("90", "7", "3"));
                    break;
                case 4:
                    Console.WriteLine("Executing three test cases for Finding Maximum Value using Generic Method");
                    Console.WriteLine(RefectorMethod.MaximumValue(65, 20, 10));
                    Console.WriteLine(RefectorMethod.MaximumValue(10.2f, 20.5f, 20.5f));
                    Console.WriteLine(RefectorMethod.MaximumValue("90", "7", "3"));
                    break;
                case 5:
                    Console.WriteLine("Executing three test cases for Finding Maximum Value using Generic Class");
                    Console.WriteLine(RefactorClass<int>.MaximumValue(30, 65, 20));
                    Console.WriteLine(RefactorClass<float>.MaximumValue(10.2f, 20.5f, 20.5f));
                    Console.WriteLine(RefactorClass<string>.MaximumValue("1", "89", "3"));
                    break;

            }
        }
    }
}