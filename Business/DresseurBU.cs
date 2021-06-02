using Fr.EQL.AI109.TPPokemon.DataAccess;
using Fr.EQL.AI109.TPPokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.EQL.AI109.TPPokemon.Business
{
    public class DresseurBU
    {
        public void InsererDresseur(Dresseur d)
        {

            //Vérifier que l'âge minimum est respecté
            //var today = DateTime.Today;
            //var age = today.Year - d.DateNaissance.Year;
            TimeSpan duree = DateTime.Now - d.BirthDate;

            DateTime dateDeLAgeMin = d.BirthDate.AddYears(Dresseur.MIN_AGE);
            if (dateDeLAgeMin > DateTime.Now)
            {
                throw new Exception("Erreur de création de dresseur : âge inférieur à l'âge minimum requis");
            }

            //TODO Appel de la DAO
            DresseurDAO dao = new();
            dao.Create(d);
        }
        public List<Dresseur> GetDresseurs()
        {
            DresseurDAO dao = new();
            return dao.GetAll();
        }
    }
}
