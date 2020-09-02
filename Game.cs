using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        bool _gameOver = false;
        string _playerName = "player";
        int playerHealth = 100;
        void RequestName(ref string name)
        {



            char input = ' ';
            Console.ReadKey();
            while (input != '1')
            {


                Console.Clear();
                Console.WriteLine("Please enter your name loser.");
                name = Console.ReadLine();
                Console.WriteLine("Hello " + _playerName);
                input = GetInput("Yes", "No", " Are you sure want that dumb name " + _playerName + "?");
                if (input == '1')
                {
                    return;
                }



                if (input == '2')
                {
                    Console.WriteLine(" Stop wasting my time and pick a name ");
                    RequestName(ref name);
                }
                Console.WriteLine(" Name accepted");
            }
        }

        void Explore()
        {
            string petName = "Huge boulder";
            char input = ' ';
            input = GetInput("Press 1 to go white", "Press 2 to go leaf", " You find a pat");
            if (input == '1')
            {
                Console.WriteLine(" Are you stupid! GO RITE BECAUSE ITS RIGHT!");
                Console.WriteLine(" Whutever, just gone." + "You see a dragon.");
                Console.WriteLine(" Dragon chases you, then random" + petName + "lands on the dragon (with no context where the boulder came from).");
                Console.WriteLine(" Boulder seems to be following you, you might as well keep it. Give it a name NOW!");
                Console.WriteLine(" New name is " + petName);
                Console.ReadLine();
                Console.ReadKey();
                Console.WriteLine("");

            }
            else if (input == '2')
            {
                Console.WriteLine(" You went write and meet a weirded cat that borks.");
                Console.WriteLine(" It wants to fite you.");
                Console.ReadKey();

            }
            Console.Clear();
            Console.WriteLine(" Put something here later.");

            int enemyHealth = 75;
            _gameOver = StartBattle(ref playerHealth, ref enemyHealth);
            Console.Clear();

        }
        void EnterRoom(int roomNumber)
        {
            string exitMessage = "";
            switch (roomNumber)
            {
                case 0:
                    exitMessage = " You depart away from the L shape castle.";
                    Console.WriteLine(" You see a L shape castle laughing at you ,cuz you stepped on bird poop.");
                    break;

                case 1:
                case 2:
                    {
                        exitMessage = " You left the L shape castle";
                        Console.WriteLine(" You enter the castle. There are rooms and a hallway to go to and, the paintings are talking about how ugly you are.");
                        break;

                    }

                default:
                    {
                        exitMessage = " You left the hallway";
                        Console.WriteLine(" You decide to stay in the hallway");
                        break;

                    }



            }
            Console.WriteLine(roomNumber);
            char input = ' ';
            input = GetInput(" Go forward", "Go back", "Which direction would you like to go?");
            if (input == '1')
            {
                EnterRoom(roomNumber + 1);
            }
            Console.WriteLine(exitMessage);
        }

        bool StartBattle(ref int playerHealth, ref int enemyHealth)
        {
            char input = ' ';
            while (playerHealth > 0 && enemyHealth > 0)
            {
                input = GetInput("Attack", "Defend", "What will you do?");
                if (input == '1')
                {
                    enemyHealth -= 10;
                    Console.WriteLine("You attacked and did something damage");
                }
                else if (input == '2')
                {
                    Console.WriteLine("You blocked the enemy's attack!");
                    Console.ReadKey();
                    continue;
                }
                playerHealth -= 20;
                Console.WriteLine("The enemy attacked and did something damage!");
                Console.ReadKey();
            }
            return playerHealth <= 0;
            
        }


        void ViewStats()
        {
            Console.WriteLine(_playerName);
            Console.Write("> ");
            Console.ReadKey();



        }







        char GetInput(string option1, string option2, string query)
        {
            char input = ' ';
            while (input != '1' && input != '2')
            {
                Console.WriteLine(query);

                Console.WriteLine("1. " + option1);
                Console.WriteLine("2 " + option2);
                Console.WriteLine("3. View Stats");
                Console.Write("> ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == '3')
                {

                }

            }
            return input;

        }
        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();

        }

        //Performed once when the game begins
        //Used for initializing variables
        //Also used for performing start up tasks that should only be done once
        public void Start()
        {
            Console.WriteLine("Welcome to the world idiot.");
        }

        //Repeated until the game ends
        //Used for all game logic that will repeat
        public void Update()
        {
            RequestName(ref _playerName);
            Explore();
            EnterRoom(0);
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThank you for not being a total let down and playing my game, just kiddin you suck :D.");
        }
    }
}
