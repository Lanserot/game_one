using System;

namespace ConsoleApp2
{
    internal class Field
    {
        private static string[,] fields = {
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
                {"█","█","█","█","█","█","█","█","█","█","█","█","█","█"},
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
            Console.SetCursorPosition(0, Field.GetField().GetLength(0) + 1);
            Console.WriteLine("Ваши очки : " + Player.count);
            Console.WriteLine("Управление стрелками");
            Console.WriteLine("НЕ зажимать");
        }
    }
}
