
using System.Web.Mvc;
using WebLogin.Models.Action;
using WebLogin.Models.Entity;

namespace WebLogin.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
         
        [HttpPost]
        public ActionResult Authentication(string usuario,string contraseña)
        {

            if (Isvalid(UsuarioA.Get(usuario), usuario, contraseña)){

                return RedirectToAction("Index","Home");
            }
            else
            {
                return RedirectToAction("Login", "Auth");
            }
            
        }

        private bool Isvalid(UsuarioE ClassUsuario,string usuario, string contraseña)
        {
            if (usuario  == ClassUsuario.Usuario && contraseña == ClassUsuario.Contraseña)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}