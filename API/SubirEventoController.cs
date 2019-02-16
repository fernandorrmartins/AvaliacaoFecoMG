using System;
using System.Web.Http;

namespace API
{
    [RoutePrefix("api/SubirEvento")]
    public class SubirEventoController : ApiController
    {
        [HttpGet]
        [Route("Retorno")]
        public bool Retorno()
        {
            return false;
        }
    }
}