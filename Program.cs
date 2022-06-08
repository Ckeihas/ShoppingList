using System;
using System.IO;
using System.Text;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lisää tuote: ");
            string input = Console.ReadLine();
            string path = @"C:\users\ChristianKeihäs\Testi.txt";

          
        if(File.Exists(path))
            {
                string createText = input + Environment.NewLine;
                File.WriteAllText(path, createText, Encoding.UTF8);
               
            }

            string appendText = "NewLine" + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
           
        }
    }
}
