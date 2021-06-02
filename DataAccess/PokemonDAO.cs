using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fr.EQL.AI109.TPPokemon.Model;
using MySql.Data.MySqlClient;

namespace Fr.EQL.AI109.TPPokemon.DataAccess
{
    public class PokemonDAO : DAO
    {

        public void Create(Pokemon p)
        {
            MySqlCommand cmd = CreerCommande();

            #region Configuration de la commande
            //Configurer la commande
            //Dégueulasse car rend possibles les injections SQL
            //cmd.CommandText = "INSERT INTO pokemon taille, date_creation) values ('" + p.Nom + "', " + p.Taille + ", '" + p.DateCreation.Month + "-" + p.DateCreation.Day + "')";

            cmd.CommandText = "INSERT INTO pokemon (name, height, creation_date) values (@name, @height, @creation_date)";
            cmd.Parameters.Add(new MySqlParameter("@name", p.Name));
            cmd.Parameters.Add(new MySqlParameter("@height", p.Height));
            cmd.Parameters.Add(new MySqlParameter("@creation_date", p.CreationDate));
            #endregion

            cmd.Connection.Open();
            cmd.ExecuteNonQuery(); //pour les commandes INSERT, UPDATE et DELETE (renvoie un int étant le nombre de lignes impactées)
            cmd.Connection.Close();
        }

        public List<Pokemon> GetAll()
        {
            MySqlCommand cmd = CreerCommande();
            cmd.CommandText = "SELECT * FROM Pokemon";

            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            List<Pokemon> result = new();

            while (dr.Read())
            {
                Pokemon p = new();
                p.Name = dr.GetString("name");
                p.Height = dr.GetFloat("height");
                p.Id = dr.GetInt32("id");
                result.Add(p);
            }
            cmd.Connection.Close();
            return result;
        }
    }
}
