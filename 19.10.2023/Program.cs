// Задача 1 
//Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number 
// и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным,
// в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.
// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number)
// {
// Введите свое решение ниже
// if (number < 10000 || number > 99999)
// {
//     Console.WriteLine("Число не пятизначное");

//     return false;
// }
// else
//     {
//         if (number / 10000 == number % 10 && number % 10000 / 1000 == number % 100 / 10)
//         {
//             return true;
//         }
//         return false;
//     }
// }
// Не удаляйте и не меняйте метод Main! 
// static public void Main(string[] args)
// {
//     int number;

//     if (args.Length >= 1)
//     {
//         number = int.Parse(args[0]);
//     }
//     else
//     {
// Здесь вы можете поменять значения для отправки кода на Выполнение
//     number = 64546;
// }

// Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }

// Задача 2
// Внутри класса Answer напишите метод DistanceBetweenPoints, который
// принимает на вход координаты двух точек pointA и pointB в виде массива целых
// чисел, и возвращает расстояние между ними в 3D пространстве.

class Answer
{
    public static double DistanceBetweenPoints(int[] pointA, int[] pointB)
    {
        if (pointA.Length != 3 || pointB.Length != 3)
        {
            throw new ArgumentException("Точки должны быть представлены тройками координат");
        }

        int x1 = pointA[0];
        int y1 = pointA[1];
        int z1 = pointA[2];

        int x2 = pointB[0];
        int y2 = pointB[1];
        int z2 = pointB[2];

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

        return distance;
    }

    static void Main()
    {
        int[] point1 = { 2, 1, 7 };
        int[] point2 = { 1, -1, 9 };

        double result = DistanceBetweenPoints(point1, point2);
        Console.WriteLine($"Расстояние между точкой 1 и точкой 2: {result:F2}");
    }
}