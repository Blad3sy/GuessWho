//20 names - 5 characteristics each -Pick random name -Characteristics are random -Check characteristics -Eliminate suspects (characteristics) -Guess

using System;

namespace GuessWho
{
    class MainClass
    {
        static void Main(string[] args)
        {
            bool guessed;
            string option;
            int optionNum;
            guessed = false;

            Random randm = new Random();
            int theName = randm.Next(1, 6);

            string[] names = { "Paula", "Jack", "Jane", "Riley", "Joseph" };

            Character char1 = new Character(names[0]);
            Character char2 = new Character(names[1]);
            Character char3 = new Character(names[2]);
            Character char4 = new Character(names[3]);
            Character char5 = new Character(names[4]);

            while (!guessed)
            {
                Console.WriteLine("The names of all the characters :");
                for (int row2 = 0; row2 < names.GetLength(0); ++row2) //Literal witchcraft i'm going to pretend I understand because I thought I did this and it didn't work?!?!?!
                {
                    Console.WriteLine(names[row2]);
                }

                Console.Write("\nPick an option :\n1. Guess the person\n2. Ask some characteristics\n3. Quit\nEnter the integer of the option. ");
                option = Console.ReadLine();

                if (!int.TryParse(option, out optionNum))
                {
                    Console.WriteLine("You didn't enter an integer!\nPress ENTER to continue.");
                    Console.ReadLine();
                    Main(null);
                }

                optionNum = Convert.ToInt32(option);

                if (optionNum == 1)
                {
                    string input;
                    int inputNum;
                    Console.WriteLine("\nPlease choose which person you would like to guess.");
                    Console.WriteLine("Would you like to pick 1. " + names[0] + "?");
                    Console.WriteLine("Would you like to pick 2. " + names[1] + "?");
                    Console.WriteLine("Would you like to pick 3. " + names[2] + "?");
                    Console.WriteLine("Would you like to pick 4. " + names[3] + "?");
                    Console.WriteLine("Would you like to pick 5. " + names[4] + "?");
                    Console.WriteLine("Please enter the integer of your option.");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out inputNum))
                    {
                        Console.WriteLine("You didn't enter an integer!\nPress ENTER to continue.");
                        Console.ReadLine();
                        Main(null);
                    }
                    inputNum = Convert.ToInt32(input);
                    if (inputNum == theName)
                    {
                        Console.WriteLine("Congratulations! You guessed the name of the character!\nPress ENTER to continue.");
                        guessed = true;
                    }
                    else
                    {
                        Console.WriteLine("Oh dear... you guessed incorrectly!\nPress ENTER to continue.");
                    }
                }
                else if (optionNum == 2)
                {
                    string input2;
                    int inputNum2;
                    Console.WriteLine("\nWhose characteristics would you like to check?");
                    Console.WriteLine("Would you like to check 1. " + names[0] + "?");
                    Console.WriteLine("Would you like to check 2. " + names[1] + "?");
                    Console.WriteLine("Would you like to check 3. " + names[2] + "?");
                    Console.WriteLine("Would you like to check 4. " + names[3] + "?");
                    Console.WriteLine("Would you like to check 5. " + names[4] + "?");
                    Console.WriteLine("Please enter the integer of your option.");
                    input2 = Console.ReadLine();
                    if (!int.TryParse(input2, out inputNum2))
                    {
                        Console.WriteLine("You didn't enter an integer!\nPress ENTER to continue.");
                        Console.ReadLine();
                        Main(null);
                    }
                    inputNum2 = Convert.ToInt32(input2);

                    switch (inputNum2)
                    {
                        case 1:
                            Console.WriteLine(char1.name + char1.hair + char1.eyes + char1.height);
                            Console.WriteLine("Press ENTER to continue.");
                            break;
                        case 2:
                            Console.WriteLine(char2.name + char2.hair + char2.eyes + char2.height);
                            Console.WriteLine("Press ENTER to continue.");
                            break;
                        case 3:
                            Console.WriteLine(char3.name + char3.hair + char3.eyes + char3.height);
                            Console.WriteLine("Press ENTER to continue.");
                            break;
                        case 4:
                            Console.WriteLine(char4.name + char4.hair + char4.eyes + char4.height);
                            Console.WriteLine("Press ENTER to continue.");
                            break;
                        case 5:
                            Console.WriteLine(char5.name + char5.hair + char5.eyes + char5.height);
                            Console.WriteLine("Press ENTER to continue.");
                            break;
                        default:
                            Console.WriteLine("\nInvalid input.\n");
                            break;
                    }
                }
                else if (optionNum == 3)
                {
                    Console.Write("\nQuitting program...\nPress ENTER to continue.");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.ReadLine();
            }
        }
    }
}