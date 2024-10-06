using System;

class Program
{
    static void Main()
    {
        int a = 6;
        int b = 10;

        Console.WriteLine("До обмена a: " + a + " b: " + b);
        a = a + b;
        b = a - b; 
        a = a - b; 
        Console.WriteLine("После обмена a: " + a + " b: " + b);
    }
}