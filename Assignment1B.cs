/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment1B 
*/
using System;
class Assignment1B { 
    public static void Main(string[] args){
        Console.WriteLine("[What to Tip]");
        Console.Write("Enter the total price of the meal:");
        float price = float.Parse(Console.ReadLine());

        Console.Write("Enter the local tax rate:");
        float rate = float.Parse(Console.ReadLine());

        Console.Write("Enter the service charge:");
        float s_charge= float.Parse(Console.ReadLine());

        float total_tax = price*rate;
        float subtotal = price+s_charge;
        float tip_10 = subtotal * 0.10f;
        float tip_25 = subtotal * 0.25f;
        float total_10 = tip_10 + subtotal + total_tax;
        float total_25 = tip_25 + subtotal + total_tax;

        Console.WriteLine();
        Console.WriteLine("The subtotal is $" + subtotal);
        Console.WriteLine();
        Console.WriteLine("A 10% tip would be $"+tip_10);
        Console.WriteLine("The total would be $"+total_10);
        Console.WriteLine();
        Console.WriteLine("A 25% tip would be $"+tip_25);
        Console.WriteLine("The total would be $"+total_25);
    }
}