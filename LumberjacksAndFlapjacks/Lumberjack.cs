using System;
using System.Collections.Generic;

namespace LumberjacksAndFlapjacks
{
    internal class Lumberjack
    {
        public string Name { get; set; }

        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks.\n");
            while (this.flapjackStack.Count > 0)
                Console.WriteLine($"{Name} ate a {flapjackStack.Pop()} flapjack.");
        }

        public Lumberjack(string name)
        {
            Name = name;

        }
    }
}
