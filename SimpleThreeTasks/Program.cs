﻿using System;
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
            int userChoise;

            Console.WriteLine("This program has 3 methods:\n" +
                "1. Method will show you, whether your number more than 7 or not.\n" +
                "2. Method will show you, whether your name is equal to 'Вячеслав'.\n" +
                "3. Method will show you all the numbers in array that are multiple of 3.\n");
            try
            {
                while (true)
                {
                    Console.WriteLine(">> Please, choose 1, 2 or 3 (to exit choose 4):");
                    userChoise = int.Parse(Console.ReadLine());
                    switch (userChoise)
                    {
                        case 1:
                            MoreThanSeven();
                            break;
                        case 2:
                            NameEqualTo();
                            break;
                        case 3:
                            MultipleOfThree();
                            break;
                    }
                    if (userChoise == 4)
                        break;
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

        public static void MultipleOfThree()//+возможность вводить размерность и значения массива с обработкой исключений
        {
            while (true)
            {
                int rank;
                Console.WriteLine("3rd Method.\n" +
                    "Input, please, the array rank (int number > 0) / *for returning back choose '-':");
                string inputRank = Console.ReadLine();
                if (inputRank == "-")
                    break;
                bool isInputRankCorrect = ((int.TryParse(inputRank, out rank))&&(rank > 0));
                if (isInputRankCorrect)
                {
                    int[] arr = new int[rank];
                    Console.WriteLine("Input, please, the array elements (int numbers):");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int element;
                        string inputElement = Console.ReadLine();
                        bool isInputElementCorrect = int.TryParse(inputElement, out element);
                        if (isInputElementCorrect)
                        {
                            arr[i] = element;
                        }
                        else
                        {
                            i--;
                            Console.WriteLine("Warning: only int numbers are applicable. Try again, please.");
                        }
                    }
                    Console.WriteLine("All the numbers in array that are multiple of 3:");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if ((arr[i] % 3.0 == 0) && (arr[i] != 0))
                            Console.WriteLine(arr[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Warning: only int number > 0 is applicable. Try again, please.");
                }                
            }            
        }
    }
}
