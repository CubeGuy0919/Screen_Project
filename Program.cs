using ConsoleAppScreen.Models;

namespace ConsoleAppScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Például egy téglalap rajzolása a képernyőn
            Screen.DrawRectangle(10, 5, 20, 10);
            // Például egy kitöltött téglalap rajzolása a képernyőn
            Screen.FillRectangle(40, 5, 20, 10);
            // Például egy vonal rajzolása a képernyőn

            // átló bal felső -> jobb alsó
            Screen.DrawLine(110, 5, 100, 15);

            // átló bal alsó -> jobb felső
            Screen.DrawLine(75, 5, 85, 15);

            // vízszintes
            Screen.DrawLine(10, 20, 60, 20);

            // függőleges
            Screen.DrawLine(65, 5, 65, 15);

            // Például szöveg középre igazítása
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            string centeredText = Screen.AlignTextCenter("Középre igazított szöveg", 50);
            Console.WriteLine("\n");
            Console.WriteLine(centeredText);
            // Például két szöveg keverése
            string mixedText = Screen.MixedStrings("Hello", "World");
            Console.WriteLine(mixedText);
            // Például két szöveg ismétlése
            string repeatedText = Screen.RepeatedStrings("AB", "12", 5);
            Console.WriteLine(repeatedText);


        }
    }
}