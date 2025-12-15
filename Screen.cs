using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppScreen.Models
{
    static public class Screen
    {
        /// <summary>
        /// Téglalap rajzolása a képernyőn a megadott koordináták és méretek alapján. 
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="width">A téglalap szélessége</param>
        /// <param name="height">A téglalap magassága</param>
        /// <param name="sign">A téglalap rajzolásához használt karakter</param>
        static public void DrawRectangle(byte x, byte y, byte width, byte height, char sign = '*')
        {
            // TODO : (Dani) Exceptions Kezelése

            if (width < 0)
            {
                throw new ArgumentException("Nem lehet 0 'width' argument érték!");
            }
            if (height < 0)
            {
                throw new ArgumentException("Nem lehet 0 'height' argument érték!");
            }
            if (x + width >= Console.WindowWidth || y + height >= Console.WindowHeight)
            {
                throw new ArgumentException("A téglalap kilóg a képernyőről!");
            }

            // TODO : (Dominik) Téglalap rajzolásának implementációja a képernyőn


            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j <= height; j++)
                {
                    if (j == 0 || j == height || i == 0 || i == width)
                    {
                        Console.SetCursorPosition(x + i, y + j);
                        Console.WriteLine(sign);
                    }

                }
            }          

        }



        /// <summary>
        /// Kitöltött téglalap rajzolása a képernyőn a megadott koordináták és méretek alapján.
        /// </summary>
        /// <param name="x">X koordináta</param>
        /// <param name="y">Y koordináta</param>
        /// <param name="width">A kitöltött téglalap szélessége</param>
        /// <param name="height">A kitöltött téglalap magassága</param>
        /// <param name="sign">A kitöltéshez használt karakter</param>
        static public void FillRectangle(byte x, byte y, byte width, byte height, char sign = '■')
        {
            // TODO : (Dani) Exceptions Kezelése

            if (width < 0)
            {
                throw new ArgumentException("Nem lehet 0 'width' argument érték!");
            }
            if (height < 0)
            {
                throw new ArgumentException("Nem lehet 0 'height' argument érték!");
            }
            if (x + width >= Console.WindowWidth || y + height >= Console.WindowHeight)
            {
                throw new ArgumentException("A téglalap kilóg a képernyőről!");
            }

            // TODO : (Dominik) Kitöltött téglalap rajzolásának implementációja a képernyőn

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < width; i++)
            {
                sb.Append(sign);

            }
            for (int s = 0; s < height; s++)
            {
                Console.SetCursorPosition(x, y + s);
                Console.WriteLine(sb);
            }                     

        }



        /// <summary>
        /// Vonal rajzolása a képernyőn a megadott kezdő és végpontok alapján.
        /// </summary>
        /// <param name="x1">X koordináta a kezdőpontban</param>
        /// <param name="y1">Y koordináta a kezdőpontban</param>
        /// <param name="x2">X koordináta a végpontban</param>
        /// <param name="y2">Y koordináta a végpontban</param>
        /// <param name="sign">A vonal rajzolásához használt karakter</param>
        static public void DrawLine(byte x1, byte y1, byte x2, byte y2, char sign = '*')
        {
            // TODO : (Dani) Vonal rajzolásának implementációja a képernyőn
            if (x1 + 1 >= Console.WindowWidth ||y1 + 1 >= Console.WindowHeight)
            {
                throw new ArgumentException("A vonal kezdőpontja kilóg!");
            }   
            // vízszintes
            else if (y1 == y2)
            {
                int start = Math.Min(x1, x2);
                int end = Math.Max(x1, x2);

                for (int x = start; x <= end; x++)
                {
                    Console.SetCursorPosition(x, y1);
                    Console.Write(sign);
                }
            }
            // függőleges
            else if (x1 == x2)
            {
                int start = Math.Min(y1, y2);
                int end = Math.Max(y1, y2);

                for (int y = start; y <= end; y++)
                {
                    Console.SetCursorPosition(x1, y);
                    Console.Write(sign);
                }
            }
            // átló (45°-os)
            else if (Math.Abs(x2 - x1) == Math.Abs(y2 - y1))
            {
                int steps = Math.Abs(x2 - x1);

                int xStep = x2 > x1 ? 1 : -1;
                int yStep = y2 > y1 ? 1 : -1;

                int x = Convert.ToInt32(x1);
                int y = Convert.ToInt32(y1);

                for (int i = 0; i <= steps; i++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(sign);
                    x += xStep;
                    y += yStep;
                }
            }
            else
            {
                throw new ArgumentException("Csak vízszintes, függőleges vagy 45°-os átló rajzolható!");
            }
        
        }

        /// <summary>
        /// Adott szélességre középre igazítja a szöveget
        /// </summary>
        /// <param name="text">A középre igazítandó szöveg</param>
        /// <param name="width">A szélesség, amire igazítani kell</param>
        /// <returns>A szöveg középre igazított változata</returns>
        static public string AlignTextCenter(string text, int width)
        {
            // TODO (Dani) : Exceptions Kezelése

            if (text == null)
            {
                throw new ArgumentException("A szöveg nem lehet null!");
            }
            else if (text == "")
            {
                throw new ArgumentException("A szöveg nem lehet üres (\"\") !");
            }

            // TODO : (Dominik) Szöveg középre igazításának implementációja

            else if (text.Length >= width)
                return text;
            else
            {
                int leftPadding = (width - text.Length) / 2;
                int rightPadding = width - text.Length - leftPadding;

                return new string(' ', leftPadding) + text + new string(' ', rightPadding);
            }          
            
        }

        /// <summary>
        /// Keverve adja vissza a két szöveg karaktereit.
        /// </summary>
        /// <param name="textA">Az első szöveg.</param>
        /// <param name="textB">A második szöveg.</param>
        /// <returns>A két szöveg karaktereinek keverésével elkészített szöveg</returns>
        public static string MixedStrings(string textA, string textB)
        {
            // TODO : (Dani) Két szöveg keverésének implementációja

            // 1. példa:
            // textA = "Hello"
            // textB = "World"
            // Kimenet: HWeolrllod

            // 2. példa:
            // textA = "abcd"
            // textB = "12345"
            // Kimenet: a1b2c3d45

            if (textA == null || textB == null)
            {
                throw new ArgumentException("A szöveg nem lehet null!");
            }
            else if (textA == "" || textB == "")
            {
                throw new ArgumentException("A szöveg nem lehet üres (\"\")!");
            }
            else
            {
                StringBuilder textMixed = new StringBuilder();
                int textLength = Math.Max(textA.Length, textB.Length);

                for (int i = 0; i < textLength; i++)
                {
                    if (i < textA.Length)
                    {
                        textMixed.Append(textA[i]);
                    }
                    if (i < textB.Length)
                    {
                        textMixed.Append(textB[i]);
                    }
                }

                return textMixed.ToString();
            }
            
        }

        // TODO : (Dani) Két szöveg ismételt váltakozásának implementációja

        /// <summary>
        /// Egymás után váltakozva szereplő szövegeket fűz egybe.
        /// </summary>
        /// <param name="textA">Az első szöveg.</param>
        /// <param name="textB">A második szöveg.</param>
        /// <param name="iteration">A fűzések ismétlési száma.</param>
        /// <returns>A két szöveg ismételt váltakozásával elkészített szöveg</returns>
        public static string RepeatedStrings(string textA, string textB, int iteration)
        {
            if (textA == null || textB == null)
            {
                throw new ArgumentException("A szöveg nem lehet null!");
            }
            else if (textA == "" || textB == "")
            {
                throw new ArgumentException("A szöveg nem lehet üres (\"\")!");
            }
            else if (iteration <= 3)
            {
                throw new ArgumentException("Az 'iteration' argumentnek nagyobbnak kell lennie 2-nél!");
            }
            else
            {
                StringBuilder textRepeated = new StringBuilder();

                for (int i = 0; i < iteration; i++)
                {
                    textRepeated.Append(textA);
                    textRepeated.Append(textB);
                }

                return textRepeated.ToString();
            }
                
        }

    }
}