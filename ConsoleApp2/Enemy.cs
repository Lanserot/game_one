using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Enemy
    {
        static public int left = 0, top = 0, count = 0;
        private static bool isMoved = false;
        static public void Move()
        {
            Random rand = new Random();
            isMoved = false;
            int randStep;

            while (!isMoved)
            {
                randStep = rand.Next(0, 4);
                switch (randStep)
                {
                    case 0:
                        if (!isMoved
                            && Booty.left < left
                            && Field.GetField()[top, left - 1] != " ")
                        {
                            isMoved = true;
                            removeOldPosition();
                            left--;
                        }
                        break;
                    case 1:
                        if (!isMoved
                            && Booty.left >= left
                            && Field.GetField().GetLength(1) - 1 > left
                            && Field.GetField()[top, left + 1] != " ")
                        {
                            isMoved = true;
                            removeOldPosition();
                            left++;
                        }
                        break;
                    case 2:
                        if (!isMoved
                            && Booty.top < top
                            && Field.GetField()[top - 1, left] != " ")
                        {
                            isMoved = true;
                            removeOldPosition();
                            top--;
                        }
                        break;
                    case 3:
                        if (!isMoved
                            && Booty.top >= top
                            && Field.GetField().GetLength(0) - 1 > top
                            && Field.GetField()[top + 1, left] != " ")
                        {
                            isMoved = true;
                            removeOldPosition();
                            top++;
                        }
                        break;
                }
            }
            
        }
        static private void removeOldPosition()
        {
            Console.SetCursorPosition(left, top);
            Console.Write("█");
        }
        static public void Draw()
        {
            Console.SetCursorPosition(left, top);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("█");
            Console.ResetColor();
        }
    }
}
