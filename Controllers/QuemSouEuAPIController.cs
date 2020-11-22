using Microsoft.AspNetCore.Mvc;
using QuemSouEuAPI.Models;

namespace QuemSouEuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuemSouEuAPIController : ControllerBase
    {
        [HttpGet]
        public QuemSouEuAPIModel Get()
        {
            var resultado = new QuemSouEuAPIModel
            {
                nome = "Lorival",
                sobrenome = "Cardoso",
                githubUser = "looricardoso"
            };
            return resultado;
        }
    }
}