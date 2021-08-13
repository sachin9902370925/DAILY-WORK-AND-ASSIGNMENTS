/*Write a pgm using interface that will get the name of the car as input and display it’s price.*/

using System;
public interface Carname
{
    void read(string name);
    void display(string name);

}

class inheritance : Carname
{
    public void read(string name)
    {
        Console.WriteLine($"car name is {name}");
    }
    public void display(string name)
    {
        Console.WriteLine($" cost of {name} is 1000000");
    }
}
class inherit
{
    public static void Main()
    {
        inheritance e = new inheritance();
        e.read("Fortuner");
        e.display("Fortuner");

    }
}