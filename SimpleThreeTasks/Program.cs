using System;
using System.Text; // Unicode encoding

namespace SimpleThreeTasks
{
    /* 
    1.Составить алгоритм: если введенное число больше 7, то вывести “Привет”
    2.Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"
    3.Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3
    4. 
- Нет, скобочная последовательность [((())()(())]] неправильная.
- Нужно заменить предпоследнюю ] на ) таким образом: [((())()(()))]    
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int user = 0;

            Console.WriteLine("This program has 3 methods:\n" +
                "1. Method will show you, whether your number more than 7 or not.\n" +
                "2. Method will show you, whether your name is equal to 'Вячеслав'.\n" +
                "3. Method will show you all the numbers in array { 0, 1, 3, 4, 6 } that are multiple of 3.\n");
            try
            {
                while (true)
                {
                    Console.WriteLine(">> Please, choose 1, 2 or 3 (to exit choose 4):");
                    user = int.Parse(Console.ReadLine());
                    if (user == 1)
                        MoreThanSeven();
                    else if (user == 2)
                        NameEqualTo();
                    else if (user == 3)
                        MultipleOfThree();
                    else if (user == 4)
                        break;
                    else
                        Console.WriteLine("Choose 1..4, please.");
                }
            }
            catch
            {
                Console.WriteLine("Error: Invalid Input!");
            }            
        }

        public static void MoreThanSeven ()
        {            
            Console.WriteLine("1st Method. Input, please, the number (int): ");
            int number = int.Parse(Console.ReadLine());
            if (number > 7)
                Console.WriteLine("Привет");
        }

        public static void NameEqualTo()
        {
            Console.WriteLine("2nd Method. Input, please, the name (string): ");
            string name = Console.ReadLine();
            if (name == "Вячеслав")
                Console.WriteLine("Привет, Вячеслав");
            else
                Console.WriteLine("Нет такого имени");
        }

        public static void MultipleOfThree()
        {
            Console.WriteLine("3rd Method.");
            int[] arr = new[] { 0, 1, 3, 4, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 3.0 == 0) && (arr[i] != 0))
                    Console.WriteLine(arr[i]);
            }
        }
    }
}
