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
            // TODO : () Téglalap rajzolásának implementációja a képernyőn


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
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
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
            for (int s = 0; s < height; s++)
            {

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
            // TODO : () Vonal rajzolásának implementációja a képernyőn
            Vector2 pozicio1;
            
            /*
            //Console.SetCursorPosition(x2);
            int position = 0;
            while (position < x1)
            {
                for (int i = 0; i< x1) { }
                Console.WriteLine(sign);
            }
            */
        }

        /// <summary>
        /// Adott szélességre középre igazítja a szöveget
        /// </summary>
        /// <param name="text">A középre igazítandó szöveg</param>
        /// <param name="width">A szélesség, amire igazítani kell</param>
        /// <returns>A szöveg középre igazított változata</returns>
        static public string AlignTextCenter(string text, int width)
        {
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            // TODO : (Szabolcs) Szöveg középre igazításának implementációja
            //throw new NotImplementedException("meg nincs kesz");
            {
                if (string.IsNullOrEmpty(text))
                    return new string(' ', width);

                if (text.Length >= width)
                    return text;

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
            // TODO : () Két szöveg keverésének implementációja
            // 1. példa:
            // textA = "Hello"
            // textB = "World"
            // Kimenet: HWeolrllod

            // 2. példa:
            // textA = "abcd"
            // textB = "12345"
            // Kimenet: a1b2c3d45
            char[] atalakitotttextA = textA.ToCharArray();
            char[] atalakitotttextB = textB.ToCharArray();

            StringBuilder osszefuzottSzoveg = new StringBuilder();

            byte index = 0;
            int i = 0;
            while(i < atalakitotttextA.Length & i < atalakitotttextA.Length)
            {
                if (index % 2 == 0 & index !< atalakitotttextA.Length)
                {
                    osszefuzottSzoveg.Append(atalakitotttextA[i].ToString());
                    i++;
                }
                else if (index % 2 == 1 & index! < atalakitotttextA.Length)
                {
                    osszefuzottSzoveg.Append(atalakitotttextB[i].ToString());
                    i++;
                }
                else
                {
                    osszefuzottSzoveg.Append(atalakitotttextB[i].ToString());
                    i++;
                }
            }
            //for (int i = 0; i < atalakitotttextA.Length; i++)
            //{
            //    osszefuzottSzoveg[index] = atalakitotttextA[index];
            //    index += 2;
            //}
            //int index2 = 1;
            //int aktualisIndexatalakitotttextB = 0;
            //for (int i = 0; i < atalakitotttextA.Length; i++)
            //{
            //    osszefuzottSzoveg[index2] = atalakitotttextB[index2];
            //    index2 += 2;
            //    aktualisIndexatalakitotttextB = i;
            //}
            //for (int i = aktualisIndexatalakitotttextB; i < atalakitotttextB.Length; i++)
            //{
            //    osszefuzottSzoveg.Append(atalakitotttextB[i]);
            //}

            return osszefuzottSzoveg.ToString();
        }

        // TODO : () Két szöveg ismételt váltakozásának implementációja
        /// <summary>
        /// Egymás után váltakozva szereplő szövegeket fűz egybe.
        /// </summary>
        /// <param name="textA">Az első szöveg.</param>
        /// <param name="textB">A második szöveg.</param>
        /// <param name="iteration">A fűzések ismétlési száma.</param>
        /// <returns>A két szöveg ismételt váltakozásával elkészített szöveg</returns>
        public static string RepeatedStrings(string textA, string textB, int iteration)
        {
            if (iteration <= 0)
                return string.Empty;

            var sb = new StringBuilder();

            for (int i = 0; i < iteration; i++)
            {
                sb.Append(textA);
                sb.Append(textB);
            }

            return sb.ToString();
        }

    }
}