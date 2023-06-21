using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_full_task
{
    internal abstract class Vehicle
    {
        public string Name;
        public string Make;
        public string Model;
        public int year;

        public  Vehicle(string Name, string Make,string Model, int year)
        {
            this.Name = Name;
            this.Make = Make;
            this.Model = Model;
            this.year = year;
        }
        public abstract void GetInfo();

    }

    internal class Car : Vehicle
    {
        public int numberOfDoors;
        public Car(string Name, string Make, string Model, int year, int nuberofdoor) : base(Name, Make, Model, year)
        {
            this.numberOfDoors = nuberofdoor;
        }

        public override void GetInfo()
        {
            Console.WriteLine("The name of Vehicle is " + this.Name);
            Console.WriteLine("The Manofacturer is "+  this.Make);
            Console.WriteLine("The model is "+this.Model);
            Console.WriteLine("The year of manofacturing is " + this.year);
            Console.WriteLine("Number of doors are "+this.numberOfDoors);
        }
    }

    internal class Truck : Vehicle
    {
        public int numberOfWheels;
        public Truck(string Name, string Make, string Model, int year, int nuberofwheels) : base(Name, Make, Model, year)
        {
            this.numberOfWheels = nuberofwheels;
        }

        public override void GetInfo()
        {
            Console.WriteLine("The name of Vehicle is " + this.Name);
            Console.WriteLine("The Manofacturer is " + this.Make);
            Console.WriteLine("The model is " + this.Model);
            Console.WriteLine("The year of manofacturing is " + this.year);
            Console.WriteLine("Number of Wheels "+this.numberOfWheels);
        }
    }

}
