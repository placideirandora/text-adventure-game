using System;

namespace text_adventure_game
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome To My Game: Text Adventure");
            Console.WriteLine("Press 'Enter' To Begin:");
            Console.ReadLine();
            Console.Clear();
            firstSection();
        }

        public static void firstSection()
        {
            string choice;

            Console.WriteLine("You Wake Up In Class With An Angry Mr. Storm Standing Over You.");
            Console.WriteLine("What Do You Do?");
            Console.WriteLine("1. Punch Him.");
            Console.WriteLine("2. Cry.");
            Console.WriteLine("3. Pee A Little. ");
            Console.WriteLine("Choice: ");

            choice = Console.ReadLine().ToLower();

            Console.Clear();
        }

        public static void secondSection()
        {

        }

        public static void thirdSection()
        {

        }

        public static void gameOver()
        {

        }

        public static void gameSuccess()
        {

        }
    }
}
