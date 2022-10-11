// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Calculator;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Calculator1 calculator = new Calculator1();
        //var result = calculator.MeanofNumberInput(new[] { 10, 20, 30, 40, 50 });
        //var result = calculator.SquareRoot(null);
        //var result = calculator.StandardDeviation(new[] { 6, 2, 3, 1 });

        Calculator2 calculator = new Calculator2();
        var result = calculator.CompoundIncrease(100, 4, 5);
        Console.WriteLine(result);
    }

}


