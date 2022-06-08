using System;
using System.IO;
using System.Text;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ChristianKeihäs\Testi.txt";

            Console.WriteLine("Lisää tuote: ");
            string input = Console.ReadLine();

            if (File.Exists(path))
            {
                File.AppendAllText(path, input + Environment.NewLine);
                try
                {
                    String[] lines;
                    lines = File.ReadAllLines(path);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine(lines[i]);
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Tiedostoa ei voida lukea");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Tiedostoa ei löydy");
            }

        }
    }
}
