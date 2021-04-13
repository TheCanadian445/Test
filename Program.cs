using System;

namespace DrinkingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            bool play = true;

            do
            {
                if (play == true)
                {
                    int drinker = rnd.Next(0, 7);

                    if (drinker == 0)
                    {
                        Console.WriteLine("AJ drinks");
                    }
                    else if (drinker == 1)
                    {
                        Console.WriteLine("Will drinks");
                    }
                    else if (drinker == 2)
                    {
                        Console.WriteLine("Winter drinks");
                    }
                    else if (drinker == 3)
                    {
                        Console.WriteLine("Cameron drinks");
                    }
                    else if (drinker == 4)
                    {
                        Console.WriteLine("Chase drinks");
                    }
                    else if (drinker == 5)
                    {
                        Console.WriteLine("Braedon drinks");
                    }
                    else if (drinker == 1)
                    {
                        Console.WriteLine("Ram drinks");
                    }
                    else
                    {
                        Console.WriteLine("Social drinks");
                    }

                    Console.WriteLine("Play Again?(Y/N)");
                    {
                        if (Console.ReadLine() == "Y")
                        {
                            play = true;
                        }
                        else if (Console.ReadLine() == "N")
                        {
                            play = false;
                        }

                    }
                }


            } while (play == true);
             


           

        }
    }
}
