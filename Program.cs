using System;
using System.Collections.Generic;

namespace primoCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> eventNamesInOrder = new List<string>();
            List<int> primosInOrder = new List<int>();
            int apologems = 300;
            int apologems2 = 300;
            int eventCount = 0;
            int result = 0;
            int howManyPromogems;
            bool lantern_rite = false; // actually this part is a little bit useless :)
            bool welkinBought = false;
            int pinkWish = 0;
            int blueWish = 0;
            int choice = 3;
            int dailiesDays = 0;
            int welkinUserChechk = 0;
            int lanternRiteChechk = 0;
            string eventName;
            Console.WriteLine("==================================");
            Console.WriteLine("Welcome Genshin Primo Calculator");
            Console.WriteLine("==================================");
            Console.WriteLine("To exit, Click Zero, otherwise the program will asking to continue");
            while(choice != 0) //if chioce is not 0 this loop will continue :)
            {
                Console.WriteLine("How many event in this patch?");
                eventCount = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < eventCount; i ++)
                {
                    Console.WriteLine("Enter the Event name");
                    eventName = Console.ReadLine(); // event name taken.
                    eventNamesInOrder.Add(eventName);
                    Console.WriteLine("How many primogems do players gain?"); //error occured.
                    howManyPromogems = Convert.ToInt32(Console.ReadLine());
                    primosInOrder.Add(howManyPromogems);
                }
                for(int i = 0; i< primosInOrder.Count; i++)
                {
                    Console.WriteLine(" {2}. {0} event --> {1} primos", eventNamesInOrder[i], primosInOrder[i], i + 1);
                    result = primosInOrder[i] + result;
                }
                Console.WriteLine("Does the patch contains a starting for a month ? example: 1 January or ! february");
                Console.WriteLine("Click 1 if yes, otherwise two. To exit click 0");
                choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    pinkWish = 5; //The program will assume that you can get all wishes in the shop;
                    blueWish = 5;
                }
                else if(choice == 2)
                {
                    pinkWish = 0;
                    blueWish = 0;
                }
                else
                {
                    break;
                }
                Console.WriteLine("Did you bought Welkin?");
                Console.WriteLine("If yes --> 1");
                Console.WriteLine("Otherwise -->2");
                welkinUserChechk = Convert.ToInt32(Console.ReadLine());
                if(welkinUserChechk == 1)
                {
                    welkinBought = true;
                    result = result + 2700;
                }
                else if(welkinUserChechk == 2)
                {
                    welkinBought = false;
                }
                else
                {
                    break;
                }
                Console.WriteLine("Does this patch contains a lantern rite (chineese year) ?");
                error_thingy:
                Console.WriteLine("If yes --> 1");
                Console.WriteLine("Otherwise --> 2");
                lanternRiteChechk = Convert.ToInt32(Console.ReadLine());
                if (lanternRiteChechk == 1)
                {
                    lantern_rite = true;
                    pinkWish = pinkWish + 10;
                }
                else if (lanternRiteChechk == 2)
                {
                    lantern_rite = false;
                }
                else
                {
                    goto error_thingy;
                }
                error2:
                Console.WriteLine("How many days do you do yoru daily commisions");
                dailiesDays = Convert.ToInt32(Console.ReadLine());
                if (dailiesDays > 42)
                {
                    Console.WriteLine("Invalid day numbers, please write again");
                    goto error2;
                }
                else
                {
                    Console.WriteLine("The computer assumes that you all did the commusions even for asking kath for 20 primos.");
                    result = result + dailiesDays * 60;
                }
                Console.WriteLine("Wanna Exit now?");
                int exitingEarly;
                Console.WriteLine("If yes ---> 0");
                exitingEarly = Convert.ToInt32(Console.ReadLine());
                choice = exitingEarly;
            }
            result = result + apologems + apologems2;
            Console.WriteLine("Total primogems --> {0}, total wishes {1} (pink) , {2} (blue)", result, pinkWish, blueWish);
            //you can use this code for homeworks or other else.
            // you can assume that genshin anniversary as an event.
        }
    }
}
