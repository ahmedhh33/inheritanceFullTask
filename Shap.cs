using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_full_task
{
    internal class Shap
    {
        public virtual void GetArea() { }
        public virtual void GetPerimeter() { }
    }

    internal class Circle : Shap 
    {
        public double radius;
        
        public Circle(double radius) 
        {
            this.radius = radius;
        }
        public override void GetArea() 
        {
            Console.WriteLine("The area of Circle = " + (Math.PI * Math.Pow(this.radius, 2)));
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("The Perimeter of Circle = " + (2*Math.PI *this.radius));
        }

    }
    internal class Rectangle : Shap
    {
        public double width;
        public double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override void GetArea()
        {
            Console.WriteLine("The area of Rectangle = " + (this.width*this.height));
        }
        public override void GetPerimeter()
        {
            Console.WriteLine("The Perimeter of Rectangle = " + 2 * (this.width + this.height));
        }
    }
}
