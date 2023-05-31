using System;
using System.Collections.Generic;
class Produce
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Produce(string name, int price)
    {
        Name = name;
        Price = price;
    }
}