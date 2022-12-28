//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//Console.Write($"\nВведите число М - количество чисел: ");
//int m = Convert.ToInt32(Console.ReadLine());
//int[] massiveNumbers = new int[m];
//InputNumbers(m);

//void InputNumbers(int m)
//{
//    for (int i = 0; i < m; i++)
//    {
//        Console.Write($"\nВведите {i+1} число -> ");
//        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//int Comparison(int[] massiveNumbers)
//{
//    int count = 0;
//    for (int i = 0; i < massiveNumbers.Length; i++)
//    {
//        if(massiveNumbers[i] > 0 )
//        {
//            count += 1; 
//        }
//    }
//   return count;
//}

//Console.Write($"\nВведено чисел больше 0 -> {Comparison(massiveNumbers)} ");


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Console.Write("Введите значение b1 = ");
//double b1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("\nВведите значение k1 = ");
//double k1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("\nВведите значение b2 = ");
//double b2 = Convert.ToInt32(Console.ReadLine());
//Console.Write("\nВведите значение k2 = ");
//double k2 = Convert.ToInt32(Console.ReadLine());
//double x = (-b2 + b1)/(-k1 + k2);
//double y = k2 * x + b2;

//Console.Write($"\nПересечение двух прямых в точке с координатами -> ({x},{y})");
