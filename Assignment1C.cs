/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment1C
*/

using System;
class Assignment1C {
    public static void Main(string[] args){
        
        Console.WriteLine("[XKCD Passphrase Generator]");
        Console.WriteLine();
        Console.Write("Enter your third favorite animal: ");
        string fav_anml = Console.ReadLine();
        Console.Write("Enter the subtotal from your last take-out meal: ");
        float subtotal = float.Parse(Console.ReadLine());
        Console.Write("Enter a whole number less than |32767|: ");
        short W = short.Parse(Console.ReadLine());
        Console.Write("Enter a single letter: ");
        char letter = char.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Your passphrase is: " + fav_anml + " " + subtotal + " " + W + " " + letter);
        Console.WriteLine("Other variations are:");
        Console.WriteLine(letter + " " + W + " " + fav_anml + " " + subtotal);
        Console.WriteLine(subtotal + " " +letter+ " " + fav_anml + " " + W);
        Console.WriteLine(W + " " + fav_anml + " " + letter + " " + subtotal);
    
    }
}
