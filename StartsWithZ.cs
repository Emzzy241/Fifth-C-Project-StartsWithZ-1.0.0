using System;

class StartsWithZ{
    static void Main(){
        Console.WriteLine("Enter your name: ");

        string userName = Console.ReadLine();

        if(userName.StartsWith("Z")){
            Console.WriteLine("Woah!!! YOur Name Starts With Z");
        }
        else{
            Console.WriteLine("Oh No!!! Your Name doesn't Start With a Z :(");
        }

        // After our if statements we used C# built-in method StartsWith to store userName.StartsWith("Z) in parenthesis 
        // THis is called a conditional statement. THis conditional Statement will take the string argument passed to it and compare
        // it to the first letter of userName. It will return true if it's equal to the argument and false if it isn't

        // Note: THe C# StartsWith() method is a string method and willonly work with strings
    }
}