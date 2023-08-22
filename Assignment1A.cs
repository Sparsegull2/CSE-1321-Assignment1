/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment1A
*/
using System;
class Assignment1A { 
    public static void Main (string[] args) {
        
        Console.Write("Enter a red value (0-255):");
        float red = float.Parse(Console.ReadLine());
        
        Console.Write("Enter a green value (0-255):");
        float green = float.Parse(Console.ReadLine());
        
        Console.Write("Enter a blue value (0-255):");
        float blue = float.Parse(Console.ReadLine());

        Console.Write("Percentage to brighten color:");
        float percentage = float.Parse(Console.ReadLine());

        float red_diff = 255 - red;
        float green_diff = 255 - green;
        float blue_diff = 255 - blue;

        float new_red = red_diff * percentage;
        float new_green = green_diff * percentage;
        float new_blue = blue_diff * percentage;

        new_red = red + new_red;
        new_green = green + new_green;
        new_blue = blue + new_blue;

        Console.WriteLine();
        Console.WriteLine("A " + percentage * 100 + "% brighter tint of RGB (" + red + "," + green + "," + blue + ") is RGB (" +new_red +"," + new_green + ","+ new_blue + ").");
    }
}