using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        bool _gameOver = false;
        string _playerName = "none";

        void NewName()
        {
            if (_playerName != "")
            {
                return;
            }



            char input = ' ';
            while (input != '1')
            {
                Console.Clear();
                Console.WriteLine("Please enter your name loser.");
                _playerName = Console.ReadLine();
                Console.WriteLine("Hello " + _playerName);
                Console.WriteLine("Are you sure you want the name " + _playerName + "?");
                input = GetInput("Yes", "No", "Are you sure want that dumb name " + _playerName + "?");
                if (input == '2')
                {
                    Console.WriteLine("Stop wasting my time and pick a name ");
                }
            }

        }

        void Explore()
        {
            char input = ' ';
            Console.WriteLine(".");
            input = GetInput("Press 1 to go white", "Press 2 to go leaf", " You find a pat");
            if (input == '1')
            {
                Console.WriteLine("You went write and meet a weirded cat that borks.");
                Console.WriteLine("It wants to fite you.");


            }

            else if (input == '2')
            {
                Console.WriteLine("Are you stupid! GO RITE BECAUSE ITS RIGHT.");
                Console.WriteLine("Whutever, just gone.");
                Console.WriteLine("You see a dragon");
                Console.WriteLine("It kills you, I laughed cuz you dead.");
                _gameOver = true;
            }


        }
        void ViewStats()
        {
            // Console.WriteLine("_playerName");


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
                Explore();
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
            NewName();
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("\nThank you for not being a total let down and playing my game, just kiddin you suck :D.");
        }
    }
}
