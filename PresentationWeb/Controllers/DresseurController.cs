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
    public class DresseurController : Controller
    {
        // GET: PokemonController
        public EmptyResult Index()
        {
            Response.ContentType = "text/html";
            Response.WriteAsync("<!DOCTYPE HTML>");
            Response.WriteAsync("<html lang=\"fr\">");
            Response.WriteAsync("<header>");
            Response.WriteAsync("<meta charset=\"utf-8\" />");
            Response.WriteAsync("<title>Mes dresseurs</title>");
            Response.WriteAsync("</header>");
            Response.WriteAsync("<body>");
            Response.WriteAsync("<h1>Mes dresseurs</h1>");
            Response.WriteAsync("<ul>");
            DresseurBU bu = new();
            foreach (Dresseur d in bu.GetDresseurs())
            {

                Response.WriteAsync("<li>" + d.Firstname + " " + d.Lastname + " - " + d.BirthDate + "</li>");

            }

            Response.WriteAsync("</ul>");
            Response.WriteAsync("<a href=\"Pokemon\">Voir les pokémons</a>");
            Response.WriteAsync("</body>");
            Response.WriteAsync("</html>");

            return new EmptyResult();
        }

    }
}
