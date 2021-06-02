using Fr.EQL.AI109.TPPokemon.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr.EQL.AI109.TPPokemon.DataAccess
{
    public class DresseurDAO : DAO
    {
        public void Create(Dresseur d)
        {
            //Créer une instance de connexion
            MySqlConnection cnx = new();
            cnx.ConnectionString = "Server=localhost;Database=pokemon_bdd;Uid=root;Pwd=root;";

            //Créer une instance de commande
            MySqlCommand cmd = new();
            //Configurer la commande
            //INSERT INTO pokemon (nom, taille, date_creation) values ('pikachu', 1.23, '2020-05-27') -- ceci est un commentaire en SQL

            //Dégueulasse car rend possibles les injections SQL
            //cmd.CommandText = "INSERT INTO pokemon taille, date_creation) values ('" + p.Nom + "', " + p.Taille + ", '" + p.DateCreation.Month + "-" + p.DateCreation.Day + "')";

            cmd.CommandText = "INSERT INTO dresseur (lastname, firstname, birthdate) values (@lastname, @firstname, @birthdate)";
            cmd.Parameters.Add(new MySqlParameter("@lastname", d.Lastname));
            cmd.Parameters.Add(new MySqlParameter("@firstname", d.Firstname));
            cmd.Parameters.Add(new MySqlParameter("@birthdate", d.BirthDate));

            //IMPORTANT : lier la commande à sa connexion
            cmd.Connection = cnx;

            //Ouvrir la connexion
            cnx.Open();

            //Exécuter la commande :
            cmd.ExecuteNonQuery(); //pour les commandes INSERT, UPDATE et DELETE (renvoie un int étant le nombre de lignes impactées)

            //Fermer la connexion
            cnx.Close();
        }
        public List<Dresseur> GetAll()
        {
            MySqlCommand cmd = CreerCommande();
            cmd.CommandText = "SELECT * FROM Dresseur";

            cmd.Connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();

            List<Dresseur> result = new();

            while (dr.Read())
            {
                Dresseur d = new();
                d.Lastname = dr.GetString("lastname");
                d.Firstname = dr.GetString("firstname");
                d.BirthDate = dr.GetDateTime("birthdate");
                d.Id = dr.GetInt32("id");
                result.Add(d);
            }
            cmd.Connection.Close();
            return result;
        }
    }
}
