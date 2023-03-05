using System;

namespace ConsoleApp2
{
    internal class Booty
    {
        static public int left, top;
        static public void GeneratePosition(string[,] fields)
        {
            Random rand = new Random();

            left = rand.Next(0, fields.GetLength(1));
            top = rand.Next(0, fields.GetLength(0));
        }
        static public void CatchCheck()
        {
            if (left == Player.left && top == Player.top)
            {
                Player.count += 10;
                GeneratePosition(Field.GetField());
            }
        }
        static public void Draw()
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("T");
            Console.ResetColor();
        }
    }
}
