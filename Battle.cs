using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PokemonBattle
{
    public class Battle
    {
        public static void StartBattle(Pokemon playerPokemon, Pokemon opponentPokemon)

        {
            Random random = new Random();
            int playerHP = playerPokemon.HP;
            int opponentHP = opponentPokemon.HP;
            bool isPlayerTurn = true;

            Console.WriteLine($"A wild {opponentPokemon.Name} appeared!");
            Console.WriteLine("Let's Begin!");





            while (playerHP > 0 && opponentHP > 0)
            {


                if (isPlayerTurn)
                {
                    Console.WriteLine($"Choose Your Attack!");
                    Console.WriteLine($"1) {playerPokemon.Ability1.Name}");
                    Console.WriteLine($"2) {playerPokemon.Ability2.Name}");
                    Console.WriteLine($"3) {playerPokemon.Ability3.Name}");
                    int playerAttack = int.Parse(Console.ReadLine());
                    bool playerHit = random.Next(0, 2) == 1;

                    if (playerHit)
                    {
                        Console.WriteLine("Your attack hit!");
                        switch (playerAttack)
                        {
                            case 1:
                                opponentHP -= 5;
                                break;
                            case 2:
                                opponentHP -= 10;
                                break;
                            case 3:
                                opponentHP -= 7;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your attack missed!");
                    }

                    Console.WriteLine($"You have {playerHP} HP!");
                    Console.WriteLine($"The wild Pokemon has {opponentHP} HP!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    Console.Clear();


                    isPlayerTurn = false;

                }
                else
                {
                    Console.WriteLine($"{opponentPokemon.Name}'s turn...");

                    int opponentAttack = random.Next(1, 4);
                    bool opponentHit = random.Next(0, 2) == 1;

                    if (opponentHit)
                    {
                        Console.WriteLine($"{opponentPokemon.Name}'s attack hit!");
                        switch (opponentAttack)
                        {
                            case 1:
                                playerHP -= 5;
                                break;
                            case 2:
                                playerHP -= 10;
                                break;
                            case 3:
                                playerHP -= 7;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{opponentPokemon.Name}'s attack missed!");
                    }

                    Console.WriteLine($"You have {playerHP} HP!");
                    Console.WriteLine($"The wild Pokemon has {opponentHP} HP!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    Console.Clear();



                    isPlayerTurn = true;
                }
            }

            if (playerHP <= 0)
            {
                Console.WriteLine($"You fainted! Let's head to the Pokemon Center!");
            }
            else if (opponentHP <= 0)
            {
                Console.WriteLine("Congratulations! You won the battle!");
                Console.WriteLine($"You two make a great team!!");
            }
        }
    }
}