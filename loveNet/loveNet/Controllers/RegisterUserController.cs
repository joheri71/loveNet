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

        
        //Om en actionmetod har samma namn som en annan. Attributet "Actionname" gör
        //att den ändå routar till rätt sida. "HttpPost" gör att denna körs bara när
        //man postar något från viewn.
        //[ActionName("Register")]
        //Parametrarna känns igen från formfields, kallas "modelbinding". Eftersom denna metod har en annan signatur
        //än den ovan kan man använda samma namn (overloading). Parametern ska matcha formfields "name"
        //Parametrarna måste inte vara string (trots att värdet i formfields är string) 
        //MVCs modelbinder gör om string till den typ man anger som parameter
        //frågetecknet efter "int" i parameterlistan betyder att den kan vara null
        [HttpPost]
        public ActionResult Register(string user_firstname, string user_lastname, int? user_age)
        {
            ViewBag.userRegistrated = "Du har lagts till som användare, nu kan du logga in";
            //man kan nå dom olika form values på samma sätt som elementen i en array.
            //istället för myArray[i], skriver man Request.Form[name på den formrad man vill komma åt]
            string _firstName = user_firstname;
            //man bör kunna skicka med "form" som en parameter till en repositorymetod som
            //lägger till användare i databasen

            //återställ form med viewbag. Egentligen är det en bättre lösning att använda formvalidation
            ViewBag.VB_firstname = user_firstname;
            ViewBag.VB_lastname = user_lastname;
            ViewBag.VB_age = user_age;
            var form = Request.Form;
            return View();
        }
    }
}