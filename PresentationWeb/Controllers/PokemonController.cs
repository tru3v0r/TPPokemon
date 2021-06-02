using Fr.EQL.AI109.TPPokemon.Business;
using Fr.EQL.AI109.TPPokemon.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fr.EQL.AI109.TPPokemon.PresentationWeb.Controllers
{
    public class PokemonController : Controller
    {
        // GET: PokemonController
        public EmptyResult Index()
        {
            Response.ContentType = "text/html";
            Response.WriteAsync("<!DOCTYPE HTML>");
            Response.WriteAsync("<html lang=\"fr\">");
            Response.WriteAsync("<header>");
            Response.WriteAsync("<meta charset=\"utf-8\" />");
            Response.WriteAsync("<title>Mes pokémons</title>");
            Response.WriteAsync("</header>");
            Response.WriteAsync("<body>");
            Response.WriteAsync("<h1>Mes pokémons</h1>");
            Response.WriteAsync("<ul>");
            PokemonBU bu = new();
            foreach(Pokemon p in bu.GetPokemons())
            {
                Response.WriteAsync("<li>" + p.Name + " - " + p.Height + "</li>");
                //Response.WriteAsync("<li>");
               // Response.WriteAsync(string.Format("{0} - {1:0.00} m - créé le {2:dddd d MMM yyyy}", p.Name, p.Height, p.CreationDate);
               // Response.WriteAsync("</li>");
            }

            Response.WriteAsync("</ul>");
            Response.WriteAsync("<a href=\"Dresseur\">Voir les dresseurs</a>");
            Response.WriteAsync("</body>");
            Response.WriteAsync("</html>");

            return new EmptyResult();
        }

    }
}
