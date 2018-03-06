using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Iterative Towers of Hanoi in c#

namespace ConsoleApplication1
{
   public class Program
    {
        class Move
        {
            public uint Number { get; private set; }

            public char Src { get; private set; }

            public char Dest { get; private set; }

            public char Alt { get; private set; }

            public Move(uint number, char src, char dest, char alt)
            {
                this.Number = number;
                this.Src = src;
                this.Alt = alt;
                this.Dest = dest;
            }
        }

        static void TowersIterative(uint number, char src, char dest, char alt)
        {
            var stack = new Stack<Move>();

            stack.Push(new Move(number, src, dest, alt));
            while (stack.Count != 0)
            {
                var move = stack.Pop();
                if (move.Number == 1)
                    Console.WriteLine("Move one disc from {0} to {1}", move.Src, move.Dest);
                else
                {
                    stack.Push(new Move(move.Number - 1, move.Alt, move.Dest, move.Src));
                    stack.Push(new Move(1, move.Src, move.Dest, move.Alt));
                    stack.Push(new Move(move.Number - 1, move.Src, move.Alt, move.Dest));
                }
            }
        }

       public static void Main()
        {
            TowersIterative(3, 'A', 'B', 'C');
            Console.ReadKey();
        }
    }
}
