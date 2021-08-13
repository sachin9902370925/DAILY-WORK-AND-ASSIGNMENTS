/*Write a program using a class that get information about employee rollno, name, address, pin code, phone number, gross salary and pf. Display the net salary (ie gross less pf) and calculate grade base on net salary. 
 * The grades are Grade-‘A’ sal>10000Grade-‘B’ sal>5000Grade-‘C’ sal<5000*/
using System;
class inheritance
{
    int pincode;
    int phonenumber;
    int rollno;
    string name;
    string address;

    float grossSal;
    float pf;
    float netSal;

    public void get(string name, string address, int pincode, int rollno, int phonenumber, float gross, float PF)
    {
        this.rollno = rollno;
        this.name = name;
        this.address = address;
        this.pincode = pincode;
        this.phonenumber = phonenumber;
        this.grossSal = gross;
        this.pf = PF;
    }

    public string displaySal()
    {
        this.netSal = this.grossSal - this.pf;
        if (this.netSal > 10000)
        {
            return $"The net salaray is {this.netSal}\n" +
                $"Grade A";
        }
        else if (this.netSal > 5000)
        {
            return $"The net salaray is {this.netSal}\n" +
                $"Grade B";
        }
        else
            return $"The net salaray is {this.netSal}\n" +
                $"Grade C";
    }


}
class inherit
{
    public static void Main()
    {
        inheritance e = new inheritance();
        e.get("vikram", "Bangalore", 123456, 1001, 1234567891, 20000, 1500);
        Console.WriteLine(e.displaySal());


    }
}