//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
//int m = InputNumbers("Введите m (количество строк): ");
//int n = InputNumbers("Введите n (количество столбцов): ");
//int range = InputNumbers("Введите диапазон элементов массива: от 1 до ");

//int[,] array = new int[m, n];
//CreateArray(array);
//WriteArray(array);

//Console.WriteLine($"\nВ итоге получается вот такой массив: ");
//OrderArrayLines(array);
//WriteArray(array);

//void OrderArrayLines(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      for (int k = 0; k < array.GetLength(1) - 1; k++)
//      {
//        if (array[i, k] < array[i, k + 1])
//        {
//            int temp = array[i, k + 1];
//            array[i, k + 1] = array[i, k];
//            array[i, k] = temp;
//        }
//      }
//    }
//  }
//}

//int InputNumbers(string input)
//{
//  Console.Write(input);
//  int output = Convert.ToInt32(Console.ReadLine());
//  return output;
//}

//void CreateArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      array[i, j] = new Random().Next(range);
//    }
//  }
//}

//void WriteArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      Console.Write(array[i, j] + " ");
//    }
//    Console.WriteLine();
//  }
//}


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Console.WriteLine($"\nВведите размер массива m x n (равное количество) и диапазон случайных значений:");
//int m = InputNumbers("Введите m (количество строк): ");
//int n = InputNumbers("Введите n (количество столбцов): ");
//int range = InputNumbers("Введите диапазон элементов массива: от 1 до ");
//int[,] array = new int[m, n];
//CreateArray(array);
//WriteArray(array);
//int minSumLine = 0;
//int sumLine = SumLineElements(array, 0);

//for (int i = 1; i < array.GetLength(0); i++)
//{
//  int tempSumLine = SumLineElements(array, i);
//  if (sumLine > tempSumLine)
//  {
//    sumLine = tempSumLine;
//    minSumLine = i;
//  }
//}
//Console.WriteLine($"\nНомер строки с наименьшей суммой элементов: {minSumLine+1}");

//int SumLineElements(int[,] array, int i)
//{
//  int sumLine = array[i,0];
//  for (int j = 1; j < array.GetLength(1); j++)
//  {
//    sumLine += array[i,j];
//  }
//  return sumLine;
//}

//int InputNumbers(string input)
//{
//  Console.Write(input);
//  int output = Convert.ToInt32(Console.ReadLine());
//  return output;
//}

//void CreateArray(int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      array[i, j] = new Random().Next(range);
//    }
//  }
//}

//void WriteArray (int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//      Console.Write(array[i,j] + " ");
//    }
//    Console.WriteLine();
//  }
//}


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//24 | 34
//32 | 33
//Результирующая матрица будет:
//18 20
//15 18

//int rows = ReadInt("Введите количество строк: ");
//int columns = ReadInt("Введите количество столбцов: ");
//Console.Write("Полученные матрицы: "); 
//Console.WriteLine();
//int[,] array = new int[rows, columns];
//int[,] secondArray = new int[rows, columns];
//int[,] resultArray = new int[rows, columns];
//FillArrayRandom(array);
//PrintArray2D(array);
//Console.WriteLine();
//FillArrayRandom(secondArray);
//PrintArray2D(secondArray);
//Console.Write("Результирующая матрица будет: "); 
//Console.WriteLine();

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < secondArray.GetLength(1); j++)
//    {
//        resultArray[i, j] = 0;
//        for (int k = 0; k < array.GetLength(1); k++)
//        {
//            resultArray[i, j] += array[i, k] * secondArray[k, j];
//        }
//    }
//}
//PrintArray2D(resultArray);

//int ReadInt(string message)
//{
//    Console.Write(message);
//    return Convert.ToInt32(Console.ReadLine());
//}

//void FillArrayRandom(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
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
//            Console.Write($"{array[i,j]} ");
//        }
//    Console.WriteLine(" ");  
//    }
//}


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

//int deep1 = 2; 
//int deep2 = 2;
//int deep3 = 2;
//int countNums = 89;

//int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

//for (int i = 0; i < resultNums.GetLength(0); i++)
//{
//    for (int j = 0; j < resultNums.GetLength(1); j++)
//    {
//        for (int k = 0; k < resultNums.GetLength(2); k++)
//        {
//            Console.WriteLine($"{resultNums[i, j, k]} ({i},{j},{k})");
//        }
//    }
//    Console.WriteLine(); 
//}

//int[,,] Create3DMassive(int size1, int size2, int size3)
//{
//    int[,,] array = new int[size1, size2, size3];
//    int[] values = new int[countNums];
//    int num = 10;
//    for (int i = 0; i < values.Length; i++)
//    {
//         values[i] = num++;
//    }   
//         
//    for (int i = 0; i < values.Length; i++)
//    {
//        int randomInd = new Random().Next(0, values.Length);
//        int temp = values[i];
//        values[i] = values[randomInd];
//        values[randomInd] = temp;
//    }
//    int valueIndex = 0;
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            for (int k = 0; k < array.GetLength(2); k++)
//            {
//                array[i, j, k] = values[valueIndex++];
//            }
//        }
//    }
//    return array;
//}


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

//int n = 4;
//int[,] sqareMatrix = new int[n, n];
//int temp = 1;
//int i = 0;
//int j = 0;

//while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
//{
//    sqareMatrix[i, j] = temp;
//    temp++;
//    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//    {
//        j++;
//    }
//    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//    {
//        i++;
//    }
//    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//    {
//        j--;
//    }
//    else
//    {
//        i--;
//    }
//}
//WriteArray(sqareMatrix);

//void WriteArray(int[,] array)
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            if (array[i, j] / 10 <= 0)
//            {
//                Console.Write($"0{array[i, j]} ");
//            }    
//            else
//            {
//                Console.Write($"{array[i, j]} ");
//            }
//        }
//        Console.WriteLine();
//    }
//}
