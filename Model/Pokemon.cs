using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.EQL.AI109.TPPokemon.Model
{
    public class Pokemon
    {

        #region CONSTANTS
        public const float MAX_HEIGHT = 2.36f;
        #endregion

        #region PROPERTIES
        private int id;

        //Propriété abrégée pour un attribut
        private string name;
        public float Height { get; set; }

        //Snippet pour générer la property
        //On écrit prop + 2 fois Tab
        //Génère ceci : public int MyProperty { get; set; }

        public DateTime CreationDate { get; set; }
        #endregion

        //En C# il n'y a pas de getters/setters à proprement parler

        //PROPERTIES (=getter/setter) avec implémentation complète
        public int Id
        {
            get { return this.id; }
            set {
                if (value < 0)
                {
                    throw new Exception("Id incorrect");
                }
                this.id = value;
            }
        }

        //Propriété s'il n'y a rien à modifier
        public string Name { get => name; set => name = value; }

        public void Plop()
        {
            Pokemon p = new Pokemon();

            p.Id = 41;
            p.Id = p.Id + 1;
            p.Id += 1;
        }

        public Pokemon()
        {
        }

        public Pokemon(string name, float height, DateTime creationDate, int id)
        {
            Name = name;
            Height = height;
            CreationDate = creationDate;
            Id = id;
        }

    }


}
