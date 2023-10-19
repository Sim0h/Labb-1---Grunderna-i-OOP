namespace Labb_1___Grunderna_i_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle R5 = new Circle(5);
            Console.WriteLine(R5.Printarea());

            Circle R6 = new Circle(6);
            Console.WriteLine(R6.Printarea());

        }
    }
}