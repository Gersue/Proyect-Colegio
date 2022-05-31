using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WepAPIColegio.Context;
using WepAPIColegio.Models;
using System.Linq;

namespace WepAPIColegio.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        ColegioDBContext db = new ColegioDBContext();

        [HttpGet]
        public Response GET()
        {
            var data = (from Usuarios in db.Usuarios select Usuarios).ToList();

            return new Response { Success = true, Data = data };
        }

        [HttpPost]
        public Response POST(Usuarios user)
        {
            if (user.NombreUsuario == null)
            {
                return new Response { Success = false, Message = "Nombre de usuario es un dato requerido" };
            }

            try
            {
                db.Usuarios.Add(user);

                db.SaveChanges();

                return new Response { Success = true, Data = user };
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(DateTime.Now + " - " + ex.Message + "Inner Details: " + ex.InnerException.Message);
                return new Response { Success = false, Message = "Se ha producido un error" };
            }
        }
    }
}
