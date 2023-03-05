using System;

namespace ConsoleApp2
{
    internal class Booty
    {
        static public int left, top;
        static private bool isDraw = false;

        static public void GeneratePosition(string[,] fields)
        {
            isDraw = false;

            Random rand = new Random();
            while (!isDraw)
            {
                left = rand.Next(0, fields.GetLength(1));
                top = rand.Next(0, fields.GetLength(0));
                if (fields[top, left] != "=")
                {
                    isDraw = true;
                }
            }
            
        }
        static public void CatchCheck()
        {
            if (left == Player.left && top == Player.top)
            {
                Player.count += 10;
                Console.SetCursorPosition(left, top);
                Console.Write("█");
                GeneratePosition(Field.GetField());
            }
            else if(left == Enemy.left && top == Enemy.top)
            {
                Enemy.count += 10;
                Console.SetCursorPosition(left, top);
                Console.Write("█");
                GeneratePosition(Field.GetField());
            }
        }
        static public void Draw()
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("█");
            Console.ResetColor();
        }
    }
}
