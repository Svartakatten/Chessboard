using System.Text;

namespace Chessboard
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Vänligen skriv i en siffra");

            int amount = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                for (int j = 0; j < amount; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        Console.Write("□");
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write("■");
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}