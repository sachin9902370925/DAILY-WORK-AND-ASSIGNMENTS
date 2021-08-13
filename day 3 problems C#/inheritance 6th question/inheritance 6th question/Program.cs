/*Write a pgm that has class dimension and has two co-ordinates x, y and ‘area()’ as virtual method. Now write different shape classes such a circle, cylinder and sphere that inherit the dimension class and calculate the surface area for each of them. Each derived class must have its own overrided implementation of method ‘area()’. 
    The pgm must display the respective area of the shapes by implementing the area()*/

using System;

namespace area
{
    class Shape
    {
        public double length = 0.0;
        public double width = 0.0;
        public double radius = 0.0;

        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;

        }

        public Shape(double radius)
        {
            this.radius = radius;
        }

        public virtual void Area()
        {
            double area = 0.0;
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of Shape is ={0:0.00} ", area);
        }
    }
    class Rect : Shape
    {

        public Rect(double length, double width) : base(length, width)
        {
        }

        public override void Area()
        {
            double area = 0.0;
            area = length * width;
            Console.WriteLine("Area of Rectangle is ={0:0.00} ", area);
        }
    }


    class Circle : Shape
    {

        public Circle(double radius)
            : base(radius)
        {
        }

        public override void Area()
        {
            double area = 0.0;
            area = Math.PI * radius;
            Console.WriteLine("Area of circle is ={0:0.00} ", area);
        }
    }

    class Sphere : Shape
    {

        public Sphere(double radius) : base(radius)

        {
        }

        public override void Area()
        {
            double area = 0.0;
            area = 4 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of sphere is :{0:0.00} ", area);
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            double length, width, radius = 0.0;

            Console.WriteLine("Enter  radius ");
            radius = Double.Parse(Console.ReadLine());
            Circle objCircle = new Circle(radius);
            objCircle.Area();

            Sphere objSphere = new Sphere(radius);
            objSphere.Area();

            Console.WriteLine("Enter  length for rectangle");
            length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width for rectangle");
            width = Double.Parse(Console.ReadLine());

            Rect objrect = new Rect(length, width);
            objrect.Area();

            Console.Read();
        }
    }
}