using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace loveNet.Controllers
{
    public class RegisterUserController : Controller
    {
        
        public ActionResult Register()
        {
            ViewBag.userRegistrated = "Fyll i formuläret och tryck på submitknappen";
            return View();
        }

        
        //Denna actionmetod har samma namn som den ovan. Attributet "Actionname" gör
        //att den ändå routar till rätt sida. "HttpPost" gör att denna körs bara när
        //man postar något från viewn.
        [ActionName("Register")]
        [HttpPost]
        public ActionResult RegisterPost()
        {
            ViewBag.userRegistrated = "Du har lagts till som användare, nu kan du logga in";
            //man kan nå dom olika form values på samma sätt som elementen i en array.
            //istället för myArray[i], skriver man Request.Form[name på den formrad man vill komma åt]
            string firstName = Request.Form["user_firstname"];
            //man bör kunna skicka med "form" som en parameter till en repositorymetod som
            //lägger till användare i databasen
            var form = Request.Form;
            return View();
        }
    }
}