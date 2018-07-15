using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_Low_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;

            Console.WriteLine("player one, please enter to the number to be guessed by player 2");

            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ok player 2 its your turn");

            int guess = Convert.ToInt32(Console.ReadLine());

            while (guess != answer)
                {
                    if (guess > answer)
                    {
                        Console.WriteLine("try lower");
                        guess = Convert.ToInt32(Console.ReadLine());
                        count++;
                    }

                    if (guess < answer)
                    {
                        Console.WriteLine("try higher");
                        guess = Convert.ToInt32(Console.ReadLine());
                        count++;
                    }
                    
                }

            Console.WriteLine("well done you got it !!!!!!!" + " it took you " + count + " times");


            Console.ReadLine();
        }
    }
}
