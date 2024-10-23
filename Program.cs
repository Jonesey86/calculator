﻿using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Initialiser den nye klassen i main scope.
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 1));
        Console.WriteLine(calculator.Subtract(70, 1));

        // // Brukerinput addere
        Console.WriteLine("enter value a (number)");
        int addA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter value b (number)");
        int addB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculator.Add(addA, addB));
        
        // // Brukerinput subtrahere
        Console.WriteLine("enter value a (number)");
        int subA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter value b (number)");
        int subB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(calculator.Subtract(subA, subB));

        // Extraoppgave
        Console.WriteLine("enter value a (number)");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter operator (+, -, * or /)");
        string? opA = Console.ReadLine();
        Console.WriteLine("enter value b (number)");
        int numB = Convert.ToInt32(Console.ReadLine());

        bool Invalid = false;

        while (Invalid == false)
        switch (opA)
        {
            case "+":
                Console.WriteLine(calculator.Add(numA, numB));
                Invalid = true;
                break;
            case "-":
                Console.WriteLine(calculator.Subtract(numA, numB));
                Invalid = true;
                break;
            case "*":
                Console.WriteLine(calculator.Multiply(numA, numB));
                Invalid = true;
                break;
            case "/":
                Console.WriteLine(calculator.Divide(numA, numB));
                Invalid = true;
                break;
            default:
                Console.WriteLine("Invalid input. Enter operator (+, -, * or /)");
                opA = Console.ReadLine();
                break;
        }
    }
}