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
            string lumberjacksName;

            while (true)
            {
                if (lumberjackQueue.Count == 0)
                    Console.Write("First lumberjack's name: ");
                else
                    Console.Write("Next lumberjack's name (blank to end): ");
                lumberjacksName = Console.ReadLine();
                if (lumberjacksName == "") break;
                Console.Write("\nNumber of flapjacks: ");
                if (int.TryParse(Console.ReadLine(), out int numberOfFlapjacks))
                {
                    lumberjackQueue.Enqueue(new Lumberjack(lumberjacksName));
                    for (int i = 0; i < numberOfFlapjacks; i++)
                    {
                        lumberjackQueue.Peek().TakeFlapjack((Flapjack)random.Next(0, 3));
                    }

                }
            }
            while (lumberjackQueue.Count != 0)
            {
                for (int i = 0; i < lumberjackQueue.Count; i++)
                {
                    while (lumberjackQueue.Peek().EatFlapjacks() ==  )
                    {
                        lumberjackQueue.Dequeue().TakeFlapjack()

                    }
                    lumberjackQueue.Dequeue();
                }
        }
    }
}
