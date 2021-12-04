using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to hear a Chuck Norris joke? (y/n)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y")
            {
                Console.WriteLine("Awesome! ");
            }
            else
            {
                Console.WriteLine("Oh no! Anyway... ");
            }

            string randomChuck;
            randomChuck = GetRandomFromFile("chuck.txt");

            Console.WriteLine($"{randomChuck}");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }
        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}
