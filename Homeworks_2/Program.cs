//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//int SecondNumber(int num)
//{
//    int dec = num / 10;
//    int ed = dec % 10;
//    return ed;
//}

//Console.WriteLine("Введите трёхзначное число");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(SecondNumber(num));


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

//int ThirdNumber (int num)
//{
//    if(num >= 100 && num < 1000)
//  {
//        num = num % 10;
//        return num;
//    }
//    else
//    {
//        if(num >= 1000)
//        {
//            while(num >= 1000)
//            {
//                num = num / 10;
//            }
//            num = num% 10;
//            return num;
//        }
//        else
//        {
//            Console.WriteLine($"{num} -> Третьей цифры нет");
//            return num;
//        }
//    }
//}
//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(ThirdNumber(num));


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//int DayOfTheWeek(int num)
//{
//    if(num > 5)
//    {
//        Console.WriteLine($"{num} -> ДА");
//        return num;
//    }
//    else
//    {
//        Console.WriteLine($"{num} -> НЕТ");
//        return num;
//    }
//}
//Console.WriteLine("Введите цифру, обозначающую день недели, от 1 до 7");
//int num = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(DayOfTheWeek(num));