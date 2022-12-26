﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

//Console.Write("Введите размер массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//FillArrayRandomNumbers(numbers);
//Console.Write("Полученный массив: ");
//PrintArray(numbers);
//int count = 0;

//for (int i = 0; i < numbers.Length; i++)
//if (numbers[i] % 2 == 0) count++;

//Console.Write($"Количество чётных чисел -> {count}");

//void FillArrayRandomNumbers(int[] numbers)
//{
//    for(int i = 0; i < numbers.Length; i++)
//    {
//    numbers[i] = new Random().Next(100,1000);
//    }
//}

//void PrintArray(int[] numbers)
//{
//    Console.Write("[ ");
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//Console.Write("]");
//Console.WriteLine();
//}



//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//Console.Write("Введите размер массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//FillArrayRandomNumbers(numbers);
//Console.Write("Полученный массив: ");
//PrintArray(numbers);
//int sum = 0;

//for (int i = 1; i < numbers.Length; i+=2)
//{
//    sum = sum + numbers[i];
//}
//Console.Write($"Сумма элементов на нечётных позициях -> {sum}");

//void FillArrayRandomNumbers(int[] numbers)
//{
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        numbers[i] = new Random().Next(1,10);
//    }
//}
//
//void PrintArray(int[] numbers)
//{
//    Console.Write("[ ");
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//    Console.Write("]");
//    Console.WriteLine();
//}



//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


//Console.Write("Введите размер массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
//double[] numbers = new double[size];
//FillArrayRandomNumbers(numbers);
//Console.Write("Полученный массив: ");
//PrintArray(numbers);
//double min = Int32.MaxValue;
//double max = Int32.MinValue;

//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > max)
//    {
//        max = numbers[i];
//    }
//    if (numbers[i] < min)
//    {
//        min = numbers[i];
//    }
//}
//Console.Write($"Разница между максимальным и минимальным элементом массива -> {max - min}");

//void FillArrayRandomNumbers(double[] numbers)
//{
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        numbers[i] = Convert.ToInt32(new Random().Next(0,100));
//    }
//}

//void PrintArray(double[] numbers)
//{
//    Console.Write("[ ");
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//Console.Write("]");
//Console.WriteLine();
//}
