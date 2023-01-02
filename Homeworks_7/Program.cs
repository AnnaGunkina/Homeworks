﻿//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//void FillArrayRandomNumbers(double[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//        }
//    }
//}

//void PrintArray(double[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.WriteLine("");
//    }
//}

//Console.Write("Введите количество строк m = ");
//int linesVol = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите количество столбцов n = ");
//int columnsVol = Convert.ToInt32(Console.ReadLine());
//double[,] numbers = new double[linesVol, columnsVol];
//FillArrayRandomNumbers(numbers);
//PrintArray(numbers);


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

//int rows = ReadInt("Введите индекс строки: ");
//int colums = ReadInt("Введите индекс столбца: ");
//int[,] numbers = new int[3, 4];
//FillArray2D(numbers);
//PrintArray2D(numbers);

//if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
//{
//    Console.WriteLine($"{numbers[rows, colums]} -> значение этого элемента");
//} 
//else
//{
//    Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
//} 

//void FillArray2D(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//      {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(1, 10);
//        }
//    }
//}

//void PrintArray2D(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//}

//int ReadInt(string message)
//{
//    Console.Write(message);
//    return Convert.ToInt32(Console.ReadLine());
//}


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 
//Console.Write("введите количество строк: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.Write("введите количество столбцов: ");
//int m = Convert.ToInt32(Console.ReadLine());
//int[,] numbers = new int[n, m];
//FillArrayRandomNumbers(numbers);

//void FillArrayRandomNumbers(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = new Random().Next(0, 10);
//        }
//    }
//}

//void PrintArray(int[,] array)
//{
//
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        Console.Write(" ");
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            Console.Write(array[i, j] + " ");
//        }
//        Console.Write(" ");
//        Console.WriteLine(" ");
//    }
//}
//PrintArray(numbers);
//Console.Write("Среднее арифметическое каждого столбца: ");

//for (int j = 0; j < numbers.GetLength(1); j++)
//{
//    double avarage = 0;
//    for (int i = 0; i < numbers.GetLength(0); i++)
//    {
//        avarage = (avarage + numbers[i, j]);
//    }
//    avarage = avarage / n;
//    avarage = Math.Round((avarage), 1);
//    Console.Write(avarage + "; ");
//}
//Console.WriteLine();
