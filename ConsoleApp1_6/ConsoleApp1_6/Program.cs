using System;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int fr = x % 10;
        int thfr = x % 100;
        int th = thfr / 10;
        int fisc = x / 100;
        int sc = fisc % 10;
        int fi = x / 1000;
        int end = fi * sc * th * fr;
        Console.WriteLine(end);
        
    }
}