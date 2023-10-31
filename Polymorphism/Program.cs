namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Geometri C1 = new Circle();
           Geometri sq1 = new Square();
           Geometri r1 = new Rectangle();
                     
            C1.Area();
            sq1.Area();
            r1.Area();

            Console.ReadKey();


            
        }
    }
}