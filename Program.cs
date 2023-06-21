namespace inheritance_full_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************** Task1 ***************");

            Dog dog1 = new Dog();
            Cat cat1 = new Cat();
            dog1.MakeNoise();
            cat1.MakeNoise();
            dog1.Eat();
            cat1.Eat();

            Console.WriteLine("******************** Task2 ***************");

            Circle circle1 = new Circle(4);
            Rectangle rectangle1 = new Rectangle(2.33, 4.21);
            circle1.GetArea();
            circle1.GetPerimeter();
            rectangle1.GetArea();
            rectangle1.GetPerimeter();

            Console.WriteLine("******************** Task3 ***************");

            Manager manager1 = new Manager("Salim","operation",1200,4);
            manager1.CalculatePay();
            Secretary secretary1 = new Secretary("Nasser","sequrity",670,40);
            secretary1.CalculatePay();

            Console.WriteLine("******************** Task4 ***************");

            Car car1 = new Car("Toyota","Jaban","Camry",2008,4);
            car1.GetInfo();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Truck truck1 = new Truck("Man", "Germany", "F350", 2022, 10);
            truck1.GetInfo();

            Console.WriteLine("******************** Task5 ***************");

            Circle2 circle2 = new Circle2("circle2","Red",4);
            Console.WriteLine(circle2.ToString());//it print the object strings this is first way
            Console.WriteLine(circle2);//this is a second way
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%");
            Rectangle2 rectangle2 = new Rectangle2("Rectangle 2", "Blu", 2, 3);
            Console.WriteLine(rectangle2.ToString());
            Console.WriteLine(rectangle2);
        }
    }
}