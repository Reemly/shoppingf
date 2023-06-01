using System;
using System.Collections.Generic;

class program {

   static void Main(string[] args)
    {
        Produce produce1 = new Produce("Marabou", 25);
        Produce produce2 = new Produce("Banan", 20);
        Produce produce3 = new Produce("Chokladkaka", 75);

        checkout scan = new checkout();
        scan.AddItem(produce1);
        scan.AddItem(produce2);
        scan.AddItem(produce3);

        scan.PrintItems();
        int total = scan.CalculateTotal();
        Console.WriteLine($"Totalt: {total} kronor"); // här kalkylerar man alla varornas sammanlagda kostnad i kronor
        Console.ReadLine();
        
    }
}


