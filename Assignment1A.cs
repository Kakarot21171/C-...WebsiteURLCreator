
/*
Class: CSE 1321L
Section: W1 C#
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Jaeden Jones
Assignment#: 1
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Program Assignment1A.cs
// User enters values for a URL



public class Assignment1A
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("Let's make a website (URL)!: ");

        Console.WriteLine(); 

        string userInput;
        Console.Write("Please enter website Scheme: ");
         userInput = Console.ReadLine();
        
        string userInput2;
        Console.Write("Please enter website Subdomain: ");
        userInput2 = Console.ReadLine();

        string userInput3;
        Console.Write("Please enter website Second-level domain: ");
        userInput3 = Console.ReadLine();

        string userInput4;
        Console.Write("Please enter website Top-level domain: ");
        userInput4 = Console.ReadLine();

        string userInput5;
        Console.Write("Please enter website Subdirectory: ");
        userInput5 = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Your URL is:");

        Console.WriteLine(""+ userInput + "://" + userInput2 + "." + userInput3 + "." + userInput4 + "/" + userInput5);
    }
}
