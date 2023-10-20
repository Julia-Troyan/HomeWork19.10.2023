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


using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
        if (pointA.Length != 3 || pointB.Length != 3)
        {
            throw new ArgumentException("Точки должны быть представлены тройками координат");
        }

        double distance = Math.Sqrt(pointA.Zip(pointB, (a, b) => Math.Pow(a - b, 2)).Sum());
        return distance;
    }

    public static void Main(string[] args)
    {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6)
        {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        double result = Length(new int[] { x1, x2, x3 }, new int[] { y1, y2, y3 });
        Console.WriteLine($"{result:F2}");
    }
}