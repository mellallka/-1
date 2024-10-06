using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трёхзначное число: ");
        string number = Console.ReadLine();
        string reversedNumber = number[2].ToString() + number[1].ToString() + number[0].ToString();
        Console.WriteLine("Число в обратном порядке: " + reversedNumber);
    }
}
