using System;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Booty.GeneratePosition(Field.GetField());
            Console.CursorVisible = false;
            Field.Draw();

            while (true)
            {
                Cycle();
            }
        }

        static private void Cycle()
        {
            Booty.CatchCheck();

            Booty.Draw();
            Player.Draw();
            Field.DrawFooter();

            Enemy.Move();
            Enemy.Draw();
            Player.Move(Field.GetField());
        }


    }
}
