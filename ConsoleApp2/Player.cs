using System;

namespace ConsoleApp2
{
    internal class Player
    {
        static public int left = 0, top = 0, count = 0;

        static public void Move(string[,] fields)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            string key = Convert.ToString(keyInfo.Key);

            RemoveOldPosition();

            switch (key)
            {
                case "UpArrow":
                    if (top > 0)
                    {
                        if (fields[top - 1, left] != " ")
                        {
                            top--;
                        }
                    }
                    break;
                case "DownArrow":
                    if (top < fields.GetLength(0) - 1)
                    {
                        if (fields[top + 1, left] != " ")
                        {
                            top++;
                        }
                    }
                    break;
                case "LeftArrow":
                    if (left > 0)
                    {
                        if (fields[top, left - 1] != " ")
                        {
                            left--;
                        }
                    }
                    break;
                case "RightArrow":
                    if (left < fields.GetLength(1) - 1)
                    {
                        if (fields[top, left + 1] != " ")
                        {
                            left++;
                        }
                    }
                    break;
            }



        }
        static private void RemoveOldPosition()
        {
            Console.SetCursorPosition(left, top);
            Console.Write("█");
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
