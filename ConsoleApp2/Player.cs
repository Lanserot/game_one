using System;

namespace ConsoleApp2
{
    internal class Player
    {
        static public int left = 0, top = 0, count = 0;

        static public void CheckMove(string[,] fields)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            string key = Convert.ToString(keyInfo.Key);

            switch (key)
            {
                case "UpArrow":
                    if (top > 0)
                    {
                        top--;
                    }
                    break;
                case "DownArrow":
                    if (top < fields.GetLength(0) - 1)
                    {
                        top++;
                    }
                    break;
                case "LeftArrow":
                    if (left > 0)
                    {
                        left--;
                    }
                    break;
                case "RightArrow":
                    if (left < fields.GetLength(1) - 1)
                    {
                        left++;
                    }
                    break;
            }
        }

        static public void Draw()
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("█");
            Console.ResetColor();
        }
    }
}
