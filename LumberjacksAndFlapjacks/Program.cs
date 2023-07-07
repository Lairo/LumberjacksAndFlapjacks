using System;
using System.Collections.Generic;

namespace LumberjacksAndFlapjacks
{
    class Program
    {
        static Random random = new Random();

        static void Main()
        {

            Queue<Lumberjack> lumberjackQueue = new Queue<Lumberjack>();


            while (true)
            {
                string lumberjacksName;
                if (lumberjackQueue.Count == 0)
                    Console.Write("First lumberjack's name: ");
                else
                    Console.Write("Next lumberjack's name (blank to end): ");
                lumberjacksName = Console.ReadLine();
                if (lumberjacksName == "") break;
                Console.Write("\nNumber of flapjacks: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfFlapjacks))
                {
                    Lumberjack lumberjack = new Lumberjack(lumberjacksName);
                    for (int i = 0; i < numberOfFlapjacks; i++)
                    {
                        lumberjack.TakeFlapjack((Flapjack)random.Next(0, 3));
                    }
                    lumberjackQueue.Enqueue(lumberjack);

                }
            }
            while (lumberjackQueue.Count != 0)
            {
                lumberjackQueue.Peek().EatFlapjacks();
                lumberjackQueue.Dequeue();
            }
        }
    }
}
