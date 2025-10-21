// AUTHOR: balkan-power
// VERSION: 1.1

using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(you must pick a number between 1 through 10, a random number will be selected. whether or not the number you called is the same, below, or above the random number, is randomized. you will have to guess correctly to get the good ending, or else you get the boring ending. do not try to pick outside 1 through 10, you will get the bad ending. now don't let the cat girl beat you!)");
            int loopProgram = 1;
            while (loopProgram == 1) // loopback for program
            {
                Console.WriteLine("");
                Console.WriteLine("hiyaaaaaaaaaa~! >.<");

                Random rnd = new Random();
                int aNumberBtwn = rnd.Next(1, 11); // random number 1 thru 10

                Console.WriteLine("");
                Console.WriteLine("pick a number between 1 through 10 <3");
                int chosenNumber;
                try
                {
                    chosenNumber = Convert.ToInt32(Console.ReadLine()); // converts string user input to 32-bit integer
                    if (chosenNumber > 10 || chosenNumber < 1)
                    {
                        Console.WriteLine("KYAAAAAAAA~~~! (O_o) u cant choose that! try again latew! u make me angy!!! 3:<");
                    }
                    else
                    {
                        Console.WriteLine("");
                        int modeSwitch = rnd.Next(2); // random between 0 and 1
                        if (modeSwitch == 1)
                        {
                            if (chosenNumber < aNumberBtwn)
                            {
                                Console.WriteLine("oh no!!! {{{(>_<)}}} u chose not cowwectly! so sowwy :''''( bettew wuck next time! ;3");
                            }
                            else
                            {
                                Console.WriteLine("nyaaah~! ^_^ u did very well 4 ur mommy! ^_~ lemme giv u a kiss!!! *MMMMMWWWA* see u next time~! :3 ;D");
                            }
                        }
                        else
                        {
                            if (chosenNumber > aNumberBtwn)
                            {
                                Console.WriteLine("oh no!!! {{{(>_<)}}} u chose not cowwectly! so sowwy :''''( bettew wuck next time! ;3");
                            }
                            else
                            {
                                Console.WriteLine("nyaaah~! ^_^ u did very well 4 ur mommy! ^_~ lemme giv u a kiss!!! *MMMMMWWWA* see u next time~! :3 ;D");
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("would you like to go again? (^///^) type 'n' or 'no' if you want to quit. press enter if you want to continue.");
                    string continueAnswer = Console.ReadLine();
                    if (continueAnswer == "n" || continueAnswer == "no") // if answers no, dont want to continue the program, it breaks and closes off
                    {
                        loopProgram = 0;
                        Console.WriteLine("sad to see u go!!! >ww< PLEASE come back 2 play wit ur favrit cat gurl!!!!11!");
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Dude, just do as she says. Why is that so difficult for you?");
                    Console.WriteLine("");
                    Console.WriteLine("would you like to go again? (^///^) type 'n' or 'no' if you want to quit. press enter if you want to continue.");
                    string continueAnswer = Console.ReadLine();
                    if (continueAnswer == "n" || continueAnswer == "no") // if answers no, dont want to continue the program, it breaks and closes off
                    {
                        loopProgram = 0;
                        Console.WriteLine("sad to see u go!!! >ww< PLEASE come back 2 play wit ur favrit cat gurl!!!!11!");
                        break;
                    }
                }
            }
        }
    }
}
