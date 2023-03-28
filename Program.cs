using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PokemonBattle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string asciiArt = @"
                                                                                          ,'\ 
                                                            _.----.        ____         ,'  _\   ___    ___     ____  
                                                        _,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |\` 
                                                        \      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ | |
                                                         \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \| |
                                                           \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     | |
                                                            \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
                                                             \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
                                                              \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
                                                               \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
                                                                \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                                                                        `'                            '-._|";
            Console.WriteLine(asciiArt);
            Console.ResetColor();

            while (true) 
            {
                Console.WriteLine("Welcome to Professor Oak's Lab.");
                Console.WriteLine("My name is Britnie and I am Professor Oak's assistant.");
                Console.WriteLine("Here you can choose your beginner Pokemon and practice battling!");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press 1 for Bulbasaur.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press 2 for Charmander.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Press 3 for Squirtle.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Press 4 for Pikachu.");
                Console.ResetColor();
                Console.WriteLine("Type exit to end the game.");
                string userInput = Console.ReadLine();
                Console.Clear();

                Ability Growl = new("Growl", 0, 100, "Growl lowers the target's Attack by one stage.");
                Ability Tackle = new("Tackle", 40, 100, "Tackle is one of the most common and basic moves a Pokémon learns. It deals damage with no additional effects.");
                Ability VineWhip = new("Vine Whip", 45, 100, "Vine Whip deals damage with no additional effect.");
                Ability Scratch = new("Scratch", 40, 100, "Scratch is one of the most common and basic moves a Pokémon learns. It deals damage with no additional effects.");
                Ability Ember = new("Ember", 40, 100, "Ember deals damage and has a 10% chance of burning the target.");
                Ability TailWhip = new("Tail Whip", 0, 100, "Tail Whip lowers the target's Defense by one stage.");
                Ability WaterGun = new("Water Gun", 40, 100, "Water Gun deals damage with no additional effect.");
                Ability ThunderShock = new("Thunder Shock", 40, 100, "Thunder Shock deals damage and has a 10% chance of paralyzing the target.");
                Ability QuickAttack = new("Quick Attack", 40, 100, "Quick Attack deals damage and has a priority of +1.");
                Pokemon pikachu = new("Pikachu", 0025, "Electric", "Mouse Pokemon", 35, 55, 40, 90, ThunderShock, Growl, QuickAttack);
                Pokemon squirtle = new("Squirtle", 007, "Water", "Tiny Turtle Pokemon", 44, 48, 65, 43, Tackle, TailWhip, WaterGun);
                Pokemon charmander = new("Charmander", 004, "Fire", "Lizard Pokemon", 39, 52, 43, 65, Growl, Scratch, Ember);
                Pokemon bulbasaur = new("Bulbasaur", 001, "Grass", "Seed Pokemon", 45, 49, 49, 45, Growl, Tackle, VineWhip);
                Pokemon playerPokemon;
                Pokemon opponentPokemon;
                while (userInput.ToLower() != "exit")
                {
                    switch (userInput)
                    {
                        case "1":
                            bulbasaur.DisplayPokemon();
                            playerPokemon = bulbasaur;
                            opponentPokemon = charmander;
                            Console.ReadLine();
                            Console.Clear();
                            // Adding a Console.WriteLine() to see that playerPokemon and opponentPokemon are set correctly
                            Console.WriteLine($"{playerPokemon.Name}, I choose you!"); // this does show "Bulbasaur Charmander"
                                                                                       // Because playerPokemon and opponentPokemon are in scope we can actually call the startBattle function.
                            Battle.StartBattle(playerPokemon, opponentPokemon);
                            // Battle was just started, now the next block of code will be called, the confirmation dialog.
                            break;
                        case "2":
                            charmander.DisplayPokemon();
                            playerPokemon = charmander;
                            opponentPokemon = squirtle;
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"{playerPokemon.Name}, I choose you!");
                            Battle.StartBattle(playerPokemon, opponentPokemon);
                            break;
                        case "3":
                            squirtle.DisplayPokemon();
                            playerPokemon = squirtle;
                            opponentPokemon = pikachu;
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"{playerPokemon.Name}, I choose you!");
                            Battle.StartBattle(playerPokemon, opponentPokemon);
                            break;
                        case "4":
                            pikachu.DisplayPokemon();
                            playerPokemon = pikachu;
                            opponentPokemon = bulbasaur;
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine($"{playerPokemon.Name}, I choose you!");
                            string asciiArtPika = @"
                                            quu..__
                                             $$$b  `---.__
                                              ""$$b        `--.                          ___.---uuudP
                                               `$$b           `.__.------.__     __.---'      $$$$""              .
                                                 ""$b          -'            `-.-'            $$$""              .'|
                                                   "".                                       d$""             _.'  |
                                                     `.   /                              ...""             .'     |
                                                       `./                           ..::-'            _.'       |
                                                        /                         .:::-'            .-'         .'
                                                       :                          ::''\          _.'            |
                                                      .' .-.             .-.           `.      .'               |
                                                      : /'$$|           .@""$\           `.   .'              _.-'
                                                     .'|$u$$|          |$$,$$|           |  <            _.-'
                                                     | `:$$:'          :$$$$$:           `.  `.       .-'
                                                     :                  `""--'             |    `-.     \
                                                    :##.       ==             .###.       `.      `.    `\
                                                    |##:                      :###:        |        >     >
                                                    |#'     `..'`..'          `###'        x:      /     /
                                                     \                                   xXX|     /    ./
                                                      \                                xXXX'|    /   ./
                                                      /`-.                                  `.  /   /
                                                     :    `-  ...........,                   | /  .'
                                                     |         ``:::::::'       .            |<    `.
                                                     |             ```          |           x| \ `.:``.
                                                     |                         .'    /'   xXX|  `:`M`M':.
                                                     |    |                    ;    /:' xXXX'|  -'MMMMM:'
                                                     `.  .'                   :    /:'       |-'MMMM.-'
                                                      |  |                   .'   /'        .'MMM.-'
                                                      `'`'                   :  ,'          |MMM<
                                                        |                     `'            |tbap\
                                                         \                                  :MM.-'
                                                          \                 |              .''
                                                           \.               `.            /
                                                            /     .:::::::.. :           /
                                                           |     .:::::::::::`.         /
                                                           |   .:::------------\       /
                                                          /   .''               >::'  /
                                                          `',:                 :    .'
                                                                               `:.:' ";
                            Console.WriteLine(asciiArtPika);
                            Battle.StartBattle(playerPokemon, opponentPokemon);
                            break;
                        default:
                            Console.WriteLine("Invalid response. Please select a Pokemon using 1-4.");
                            break;
                    }
                }
            Console.WriteLine("Would you like to play again? Y or N?");
            string userContinue = Console.ReadLine();

                if (userContinue.ToLower() == "y")
                {
                    
                    continue; // Continue the infinite loop
                }
                else
                {
                    // Exit the game
                    break; // Break out of the infinite loop
                }
            }
                Console.WriteLine("Thanks for playing!");
                Environment.Exit(0);
            }
        }
    }