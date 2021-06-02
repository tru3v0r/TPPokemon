using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.EQL.AI109.TPPokemon.Model
{
    public class Dresseur
    {
        public const int MIN_AGE = 6;
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime BirthDate { get; set; }


    public Dresseur()
    {
    }

    public Dresseur(int id, string lastname, string firstname, DateTime birthDate)
    {
            Id = id;
            Lastname = lastname;
            Firstname = firstname;
            BirthDate = birthDate;
    }
    }
}
