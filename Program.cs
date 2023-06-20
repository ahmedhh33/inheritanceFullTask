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
        }
    }
}