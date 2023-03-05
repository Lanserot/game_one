using System;

namespace ConsoleApp2
{
    internal class Field
    {
        private static string[,] fields = {
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█"," "," ","█","█","█","█","█"," ","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█"," ","█"," ","█"},
                {"█","█"," ","█","█"," ","█"," ","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█"," ","█","█"},
                {"█","█","█","█"," ","█"," ","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█"," ","█"," "," ","█"},
                {"█","█","█","█","█","█","█"," ","█","█","█","█","█","█"},
                {"█","█"," ","█","█"," ","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█"," ","█","█","█"," ","█","█"},
                {"█","█"," ","█","█","█","█","█","█","█","█","█","█","█"},
            };
        static public string[,] GetField()
        {
            return fields;
        }
        static public void Draw()
        {
            for (int x = 0; x < GetField().GetLength(0); x++)
            {
                for (int y = 0; y < GetField().GetLength(1); y++)
                {
                    Console.SetCursorPosition(y, x);
                    Console.Write(GetField()[x, y]);
                }
            }
        }

        static public void DrawFooter()
        {
            Console.SetCursorPosition(0, Field.GetField().GetLength(0) + 5);

            WriteColorfulText("Поймайте ДОБЫЧУ", ConsoleColor.Red);
            WriteColorfulText("Ваши очки : " + Player.count, ConsoleColor.Green);
            WriteColorfulText("Соперника очки : " + Enemy.count, ConsoleColor.Blue);
 
            Console.WriteLine("Управление стрелками");
        }

        static private void WriteColorfulText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
