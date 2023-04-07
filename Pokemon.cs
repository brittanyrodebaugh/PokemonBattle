using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonBattle
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public List<Ability> Abilities { get; set; }



        public Pokemon(string Name, int Id, string Type, string Species, int HP, int Attack, int Defense, int Speed, Ability Ability1, Ability Ability2, Ability Ability3)
        {

            this.Name = Name;
            this.Id = Id;
            this.Type = Type;
            this.Species = Species;
            this.HP = HP;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Speed = Speed;
            this.Abilities = new List<Ability>();
            this.Abilities.Add(Ability1);
            this.Abilities.Add(Ability2);
            this.Abilities.Add(Ability3);
        }

        public void DisplayPokemon()
        {

            Console.WriteLine("******************************************************************************");
            Console.WriteLine($"                    You have chosen {this.Name}!");
            Console.WriteLine($"                    {this.Type} Type Pokemon.");
            Console.WriteLine($"                    {this.Name} is a {this.Species}.");
            Console.WriteLine($"                    Your Pokemon's Health is {this.HP}.");
            Console.WriteLine($"                       Attack | {this.Attack}");
            Console.WriteLine($"                      Defense | {this.Defense}");
            Console.WriteLine($"                        Speed | {this.Speed}");
            Console.WriteLine($"                    Abilities | {this.Abilities[0].Name}, {this.Abilities[1].Name}, and {this.Abilities[2].Name}");
            Console.WriteLine("******************************************************************************");


        }

    }

    public class Ability
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public decimal Accuracy { get; set; }
        public string Description { get; set; }

        public Ability(string Name, int Power, decimal Accuracy, string Description)
        {
            this.Name = Name;
            this.Power = Power;
            this.Accuracy = Accuracy;
            this.Description = Description;
        }
    }    
}