using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_full_task
{
    internal abstract class Shap2
    {
        public string Name;
        public string Color;
        public Shap2(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
        public override string ToString()
        {
            return "This is a " + Name + " and has color " + Color;
        }
    }
    internal class Circle2 : Shap2
    {
        public double radius;

        public Circle2(string name, string color,double radius) : base(name, color)
        {
            this.radius = radius;
        }

        public override string ToString()
        {
            return "This is a " + Name + " and has color " + Color + " and radius " + radius;
        }
    }
    internal class Rectangle2 : Shap2
    {
        public double width;
        public double height;

        public Rectangle2(string name, string color, double width, double height): base(name, color)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return "This is a " + Name + " and has color " + Color + " and width " + width+" and hight"+height;
        }
    }
}
