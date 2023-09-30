using BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Models;
using System.Security.Cryptography;
using UIWebApplication.Dto;

namespace UIWebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<Usuario> Get()
        {
            return new UsuarioBLL().BuscarTodos();
        }

        [HttpPost]
        public ActionResult Add([FromBody] UsuarioDTO _usuario)
        {
            Usuario usuario = CarregarDados(_usuario);

            new UsuarioBLL().Inserir(usuario, _usuario.ConfirmacaoSenha);

            return Ok();
        }

        [HttpPut]
        public ActionResult Update([FromBody] UsuarioDTO _usuario, int _id)
        {
            Usuario usuario = CarregarDados(_usuario, _id);

            new UsuarioBLL().Alterar(usuario, _usuario.ConfirmacaoSenha);

            return Ok();
        }

        private static Usuario CarregarDados(UsuarioDTO _usuario, int _id = 0)
        {
            return new Usuario()
            {
                Id = _id,
                Nome = _usuario.Nome,
                NomeUsuario = _usuario.NomeUsuario,
                Senha = _usuario.Senha,
                Ativo = _usuario.Ativo,
            };
        }

        [HttpDelete]
        public ActionResult Update(int _id)
        {
            new UsuarioBLL().Excluir(_id);

            return Ok();
        }
    }
}