using AchadosPerdidos.Data.DataBase;
using AchadosPerdidos.Infra.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace AchadosPerdidos.WebAPI.Controllers
{
    public class UsuarioController : ApiController
    {
        public IEnumerable<Usuario> Get()
        {
            return new Usuario[] { };
        }

        public Usuario Get(int id)
        {
            UsuarioProcs _usuario = new UsuarioProcs();

            var usuario = _usuario.ObterUsuario(12);

            return usuario;
        }
    }
}
