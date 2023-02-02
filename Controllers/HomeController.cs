using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using TPLOCAL1_base.Models;

//L'énoncé du tp et le logo hn sont livrés dans le répertoire /ressources de la solution
//--------------------------------------------------------------------------------------
//Attention, le modèle MVC est un modèle dit de convention plutot que configuration, 
//Le controller doit donc obligatoirement se nommer avec "Controller" à la fin!!!
namespace TPLOCAL1_base.Controllers
{
    public class HomeController : Controller
    {
        // méthode appelée par la routeur "naturellement"
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //renvoie vers la vue Index (voir routage dans RouteConfig.cs)
                return View();
            else
            {
                //en fonction du paramètre id, on appelle les différentes pages
                switch (id)
                {
                    case "ListeAvis":
                        //declarer une liste vide
                        ListeAvis avisDonnes = new ListeAvis();
                        // remplir et retourné cette liste 
                        return View(id, avisDonnes.GetAvis("FichierXML/DataAvis.xml"));
                    case "Formulaire":
                        //Afficher la vue Formulaire avec le modèle de données vide
                        return View(id);
                    default:
                        //renvoie vers Index (voir routage dans RouteConfig.cs)
                        return View();
                }
            }
        }


        //méthode pour envoyer les données du formulaire vers la page de validation
        [HttpPost]
        public ActionResult ValidationFormulaire(FormulaireModel mod)
        {
            //Si l'utilisateur ne choissie pas le sexe 
            if (mod.Sexe == "Sélectionner un sexe")
            {
                ModelState.AddModelError("", "Merci de vérifier le Sexe");
            }
            //Si l'utulisateur ne choissie pas de formation
            if (mod.TypeFormation == "Sélectionner une formation")
            {
                ModelState.AddModelError("", "Merci de vérifier le Type de Formation");

            }



            if (!ModelState.IsValid)
            {
                return View("Formulaire");
            }

            return View(mod);

        }
    }
}