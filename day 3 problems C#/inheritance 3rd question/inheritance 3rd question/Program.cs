/*Create a base class to take regno and name of students. Using inheritance, write a pgm that will take marks as input from the student. Provide two branches science and commerce. If the student enters science then get the marks of physics, chemistry and math. If the student enters commerce, get the marks for economics, accounts and banking. Then calculate the average of the three subjects. 
    The output should display regno, name, details of marks subject wise and the average of marks.*/
using System;
class inheritance
{

    int registerno;
    string name;
    public inheritance(int registerno, string name)
    {
        this.registerno = registerno;
        this.name = name;
    }
    public override string ToString()
    {
        return $"Regno-{this.registerno}\n" +
            $"Name-{this.name}";
    }
}
class science : inheritance
{
    float maths;
    float phy;
    float chem;
    float avg;
    public science(int registerno, string name, float phy, float chem, float maths) : base(registerno, name)
    {
        this.phy = phy;
        this.chem = chem;
        this.maths = maths;
    }
    public override string ToString()
    {
        this.avg = (phy + maths + chem) / 3;
        return base.ToString() + $"\nMarks obtained in\n" +
            $"Physics={this.phy}\nChemistry={this.chem}\nMaths={this.maths}\n" +
            $"With an average of {this.avg}";
    }




}
class comm : inheritance
{
    float economics;
    float accounts;
    float banking;
    float avg;
    public comm(int regno, string name, float economics, float accounts, float banking) : base(regno, name)
    {
        this.economics = economics;
        this.accounts = accounts;
        this.banking = banking;
    }
    public override string ToString()
    {
        this.avg = (economics + accounts + banking) / 3;
        return base.ToString() + $"\nMarks obtained:\n" +
            $"Economics:{this.economics}\nAccounts:{this.accounts}\nBanking:{this.banking}\n" +
            $"With an average of {this.avg}";
    }
}
class inherit
{
    public static void Main()
    {
        science s = new science(301, "vikram", 95, 75, 85);
        comm c = new comm(201, "sheela", 83, 95, 76);
        Console.WriteLine(s.ToString());
        Console.WriteLine(c.ToString());
    }
}