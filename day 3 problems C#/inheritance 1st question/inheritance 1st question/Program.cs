/*Write a program using structures that
 * will get input regarding name, sex, height, weight and displays the information that is got from the user.*/

using System;
struct inheritance

{
    public string name;
    public float weight;
    public string sex;
    public float height;


    public void getValues(string names, string sex, float height, float weight)
    {
        name = names;
        this.sex = sex;
        this.height = height;
        this.weight = weight;
    }
    public string display()
    {
        return $"Name-{name} \nSex-{sex}\nWeight-{weight} kg\nHeight-{height} cm\n";

    }
}
class inherit
{
    public static void Main()
    {
        inheritance u = new inheritance();
        u.getValues("vikram", "Male", 175, 65);
        Console.WriteLine(u.display());
    }
}