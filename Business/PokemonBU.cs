using Fr.EQL.AI109.TPPokemon.DataAccess;
using Fr.EQL.AI109.TPPokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fr.EQL.AI109.TPPokemon.Business
{
    public class PokemonBU
    {

        public void InsererPokemon(Pokemon p)
        {
            //Vérification des règles de gestion :
            //Taille <= taille max :
            if (p.Height >= Pokemon.MAX_HEIGHT)
            {
                throw new Exception("Erreur de création de pokémon : taille supérieure à la limite");
            }
            //Tout est ok :

            //TODO : envoyer au dataAccess pour insertion
            PokemonDAO dao = new();
            dao.Create(p);
        }

        public List<Pokemon> GetPokemons()
        {
            PokemonDAO dao = new();
            return dao.GetAll();
        }
    }
}
