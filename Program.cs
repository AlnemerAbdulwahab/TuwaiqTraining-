using System;   // 👈 IMPORTANT

class Program
{
    static void Main(string[] args)
    {
        helloworld h = new helloworld();   // create object
        Console.WriteLine(h.x);            // print its x value
    }
}
