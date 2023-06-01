using System;
using System.Collections.Generic;
class checkout {


private List<Produce> groceries; 


public checkout()
    {
        groceries = new List<Produce>();
    }

 public void AddItem(Produce produce)
    {
        groceries.Add(produce);
    }

public void RemoveItem(Produce produce)
    {
        groceries.Remove(produce);
    }

public void PrintItems() // här förbereder jag för att lägga till typ bananer i den mängden grejer du köper
    {
        Console.WriteLine("Shopping Cart:");
        foreach (Produce grocery in groceries)
        {
            Console.WriteLine($"{grocery.Name} - {grocery.Price} kr");
        }
    }

    public int CalculateTotal() // räkanr ut totala priset
    {
        int total = 0;
        foreach (Produce grocery in groceries)
        {
            total += grocery.Price;
        }
        return total;
    }
}





