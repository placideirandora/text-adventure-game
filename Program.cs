using System;

namespace text_adventure_game
{
    class Program
    {
        static void Main()
        {
            gameTitle();
        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome To My Game: Text Adventure\n");
            Console.WriteLine("Press 'Enter' To Begin:");
            Console.ReadLine();
            Console.Clear();
            firstSection();
        }

        public static void firstSection()
        {
            string choice;

            Console.WriteLine("You Wake Up In Class With An Angry Mr. Storm Standing Over You.\n");
            Console.WriteLine("What Do You Do?");
            Console.WriteLine("1. Punch Him.");
            Console.WriteLine("2. Cry.");
            Console.WriteLine("3. Pee A Little.\n");
            Console.Write("Choice: ");

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
                        Console.WriteLine("When She Sees Her Husband Crying In The Corner, She Shoots You With Her Lazer Eyes.\n");
                        Console.WriteLine("Press 'Enter' To Continue:");
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
                        Console.WriteLine("You Wanna Cry? Do It Out In The Hall! He Screams At The Top Of His Lungs.\n");
                        Console.WriteLine("Press 'Enter' To Continue:");
                        Console.ReadLine();
                        Console.Clear();
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
                        Console.WriteLine("'Did You Just...? Get Out Of Here.' He Screams At The Top Of His Lungs.\n");
                        Console.WriteLine("Press 'Enter' To Continue:");
                        Console.ReadLine();
                        Console.Clear();
                        secondSection();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I Don't Understand That Command...\n");
                        Console.WriteLine("Press 'Enter' To Continue:");
                        Console.ReadLine();
                        Console.Clear();
                        firstSection();
                        break;
                    }

            }
        }

        public static void secondSection()
        {
            Random rnd = new Random();
            string[] secondOptions = {
                                        "In The Hallway, You See That The Cops Are Searching Lockers.",
                                        "In The Hallway, You See Your Stalker Walking Toward You.",
                                        "In The Hallway, The Fire Alarm Goes Off."
                                    };
            int randomNumber = rnd.Next(0, 3);
            string secondText = secondOptions[randomNumber];

            string secondChoice;

            Console.WriteLine(secondText);
            Console.WriteLine("Do You Try To Hide In The Bathroom; Yes Or No?\n");
            Console.Write("Choice: ");
            secondChoice = Console.ReadLine().ToLower();

            if (secondChoice == "yes" || secondChoice == "y" || secondChoice == "YES" || secondChoice == "Y" || secondChoice == "Yes")
            {
                Console.Clear();
                thirdSection();
            }
            else if (secondChoice == "no" || secondChoice == "n" || secondChoice == "NO" || secondChoice == "N" || secondChoice == "No")
            {
                Console.Clear();
                Console.WriteLine("A Meteor Slams Into The School At That Exact Moment, Killing You Instantly.\n");
                Console.WriteLine("Press 'Enter' To Continue:");
                Console.ReadLine();
                gameOver();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nI Don't Understand That Command...\n");
                Console.WriteLine("Press 'Enter' To Continue:");
                Console.ReadLine();
                Console.Clear();
                secondSection();
            }
        }

        public static void thirdSection()
        {
            int age;

            Console.WriteLine("You Burst Into The Bathroom And All Of Your Friends And Family Are There.");
            Console.WriteLine("They Yell 'Suprise' And You Remember It's Your Birthday.\n");
            Console.WriteLine("How Old Are You Today?");
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out age);
            Console.Clear();

            while (age < 100)
            {
                Console.WriteLine("Seriously? You Look Older Than That.\n");
                Console.WriteLine("How Old Are You Really?");
                Console.Write("Age: ");
                int.TryParse(Console.ReadLine(), out age);
            }

            Console.Clear();
            Console.WriteLine("Wow, You're Old. You Must Have Been Held Back A Lot!\n");
            Console.WriteLine("Press 'Enter' To Continue:");
            Console.ReadLine();
            Console.Clear();
            gameSuccess();
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("At Your Funeral, They Sing Songs Of Your Bravery.");
            Console.WriteLine("Then, They Remember Whose Funeral They Are Attending And They Take It All Back.");
            Console.WriteLine("Better Luck Next Time.\n");
            Console.WriteLine("Press 'Enter' To Continue:");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void gameSuccess()
        {
            Console.Clear();
            Console.WriteLine("Your Birthday Party Was A Big Hit.");
            Console.WriteLine("The Cake Gave Everyone Super Powers.");
            Console.WriteLine("You Will All Live For Another 100 Years.\n");
            Console.WriteLine("Great Job! You Won.\n");
            Console.WriteLine("Press 'Enter' To Try Again:");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}
