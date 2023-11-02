namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Geometri circle = new Circle();
           Geometri square = new Square();
           Geometri rectangle = new Rectangle();
                     
            circle.Area();
            square.Area();
            rectangle.Area();

            Console.ReadKey();


            
        }
    }
}