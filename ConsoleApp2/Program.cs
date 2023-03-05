using System;
using System.Threading;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Booty.GeneratePosition(Field.GetField());

            while (true)
            {
                Cycle();
            }
        }

        static private void Cycle()
        {
            Booty.CatchCheck();

            Field.Draw();

            Booty.Draw();

            Player.Draw();

            Enemy.Draw();

            Enemy.Move();

            Field.DrawFooter();

            Player.CheckMove(Field.GetField());

            Thread.Sleep(10);
            Console.Clear();
        }


    }
}
