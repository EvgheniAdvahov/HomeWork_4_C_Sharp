// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// System.Console.WriteLine("Введите первое число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите первое число: ");
// int B = Convert.ToInt32(Console.ReadLine());

// int Method(int A, int B)
// {
//     int result = 1;
//     for (int i = 0; i < B; i++)
//     {   
        
//         result = result * A;
//         // System.Console.WriteLine(result);
//     }
//     return(result);
// }

// System.Console.WriteLine();
// int result1 = Method(A, B);
// System.Console.WriteLine($"Равно: {result1}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// System.Console.WriteLine("Please enter the number");
// int number = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine();

// int Method(int num)
// {   
//     int sum =0;
//     int rest = 0;
//     while (num > 0)
//     {   
//         rest = num % 10;
//         sum = sum + rest;
//         num /=10;
//     }
//     return sum;
// }
// int result = Method(number);
// System.Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] Arr = new int[8];
// System.Console.WriteLine();

// int[] Method()
// {
// for (int i = 0; i < Arr.Length; i++)
//     {
//         System.Console.WriteLine($"Enter number for array");
//         Arr[i] = Convert.ToInt32(Console.ReadLine());    
//     }
//     return Arr;
// // How to return a Array
// }

// int[] Arr2 = Method();
// Console.Write(string.Join(",", Arr2));


