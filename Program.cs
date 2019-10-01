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

            switch (choice)
            {
                case "1":
                case "Punch Him":
                case "punch him":
                case "PUNCH HIM":
                case "Punch":
                case "punch":
                case "PUNCH":
                    {
                        Console.WriteLine("Your Fist Pounds Into Mr. Storm's Face.");
                        Console.WriteLine("All The Other Students In Class Cheer Your Name.");
                        Console.WriteLine("Mrs. Storm Hears The Commotion And Comes To Investigate.");
                        Console.WriteLine("When She Sees Her Husband Crying In The Corner, She Shoots You With Her Lazer Eyes.");
                        Console.WriteLine("Press 'Enter' To Continue.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "Cry":
                case "cry":
                case "CRY":
                    {
                        Console.WriteLine("Mr. Storm's Face Becomes The Color Of Ripe Tomatoes.");
                        Console.WriteLine("You Wanna Cry? Do It Out In The Hall! He Screams At The Top Of His Lungs.");
                        Console.WriteLine("Press 'Enter' To Continue.");
                        Console.ReadLine();
                        secondSection();
                        break;
                    }
                case "3":
                case "Pee":
                case "pee":
                case "PEE":
                case "Pee A Little":
                case "pee a little":
                case "PEE A LITTLE":
                    {
                        Console.WriteLine("Mr. Storm Sniffs The Air. The Other Students Begin Plugging Their Noses.");
                        Console.WriteLine("'Did You Just...? Get Out Of Here.' He Screams At The Top Of His Lungs.");
                        Console.WriteLine("Press 'Enter' To Continue.");
                        Console.ReadLine();
                        secondSection();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I Don't Understand That Command...");
                        Console.WriteLine("Press 'Enter' To Continue.");
                        Console.ReadLine();
                        Console.Clear();
                        firstSection();
                        break;
                    }

            }
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
