using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fr.EQL.AI109.TPPokemon.Business;
using Fr.EQL.AI109.TPPokemon.Model;

namespace Fr.EQL.AI109.TPPokemon.Presentation
{
    class GestionPokemon
    {
        public void Ajouter()
        {
            Console.WriteLine("Création d'un nouveau pokémon");
            Console.WriteLine("-----------------------------");

            //Récupération des informations saisies :

            Console.Write("Saisissez un nom : ");
            string nom = Console.ReadLine();

            Console.WriteLine("Saisissez une taille : ");
            float taille = float.Parse(Console.ReadLine());

            //Créer une instance de pokémon :

            Pokemon p2 = new Pokemon(nom,taille, DateTime.Now, 0);

            //Pokemon p = new Pokemon();
            //p.Nom = nom;
            //p.Taille = taille;
            //p.DateCreation = DateTime.Now; // date/heure courante

            //Envoyer le pokémon au business :
            PokemonBU bu = new PokemonBU();
            bu.InsererPokemon(p2);

            Console.WriteLine("Pokémon inséré avec succès");



        }

        public void AffichezLesTous()
        {
            PokemonBU bu = new();
            Console.WriteLine("Liste de vos pokémons : ");
            foreach (Pokemon p in bu.GetPokemons())
            {

                Console.WriteLine(p.Id + ". " + p.Name + " - " + p.Height);
            }
            Console.WriteLine("----------------");
        }
    }
}
