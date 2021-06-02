using Fr.EQL.AI109.TPPokemon.Model;
using Fr.EQL.AI109.TPPokemon.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.EQL.AI109.TPPokemon.Presentation
{
    class GestionDresseur
    {
        public void Ajouter()
        {
            Console.WriteLine("Création d'un nouveau dresseur");
            Console.WriteLine("-----------------------------");

            Console.Write("Saisissez un nom : ");
            string nom = Console.ReadLine();

            Console.Write("Saisissez un prénom : ");
            string prenom = Console.ReadLine();

            Console.Write("Saisissez une date de naissance : ");
            DateTime dateNaissance = DateTime.Parse(Console.ReadLine());

            Dresseur d = new Dresseur(0, nom, prenom, dateNaissance);

            //Envoyer le pokémon au business :
            DresseurBU bu = new DresseurBU();
            try
            {
                bu.InsererDresseur(d);
                Console.WriteLine("Dresseur ajouté avec succès");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
