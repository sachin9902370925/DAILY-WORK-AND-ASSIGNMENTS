/*Write a pgm that reads the age of a person. Validate the age and handle the errors.*/
using System;
namespace AgeExceptionssss
{
    class control
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.displayAge();
            }
            catch (AgeException e)
            {
                Console.WriteLine("Age error {0}", e.Message);
            }
        }
    }
}
public class AgeException : Exception
{
    public AgeException(string message) : base(message)
    {
    }
}
public class Age
{
    int age = -25;
    public void displayAge()
    {
        if (age < 0)
        {
            throw (new AgeException("Age should not be neagtive"));
        }
        else
        {
            Console.WriteLine("Age is: {0}", age);
        }
    }
}