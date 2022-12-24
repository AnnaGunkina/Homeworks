//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//Console.WriteLine("Введите пятизначное число: ");
//string number = Console.ReadLine();
//int len = number.Length;
//if (len == 5)
//{
//    if (number[0] == number[4] && number[1] == number[3])
//    {
//        Console.WriteLine($"{number} -> Да");
//    }
//    else
//    {
//        Console.WriteLine($"{number} -> Нет");
//    }
//}


//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//int x1 = ReadInt("Введите координату X первой точки: ");
//int y1 = ReadInt("Введите координату y первой точки: ");
//int z1 = ReadInt("Введите координату z первой точки: ");
//int x2 = ReadInt("Введите координату x второй точки: ");
//int y2 = ReadInt("Введите координату y второй точки: ");
//int z2 = ReadInt("Введите координату z второй точки: ");
//int A = x2 - x1;
//int B = y2 - y1;
//int C = z1 - z2;
//double length = Math.Round(Math.Sqrt(A * A + B * B + C * C), 2);
//Console.WriteLine($"Расстояние между точками {length}");
//int ReadInt(string message)
//{
//   Console.Write(message);
//   return Convert.ToInt32(Console.ReadLine()); 
//}


//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//int number = ReadInt("Введите число N: ");
//for (int i = 1; i <= number; i++)
//{
//    Console.Write($"{i*i*i}, ");
//}
//int ReadInt(string message)
//{
//    Console.Write(message);
//    return Convert.ToInt32(Console.ReadLine());
//}
