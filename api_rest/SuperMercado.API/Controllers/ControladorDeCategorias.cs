using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_rest.Domain.Servicos;
using api_rest.Domain.Models;
using System.Collections.Generic;

namespace api_rest.Controllers
{
    [Route("api/[Contoller]")]
    [ApiController]
    
    public class ControladorDeCategorias : Controller{
        private readonly ICategoriaDeServicos _categoriaDeServicos;

        public ControladorDeCategorias(ICategoriaDeServicos categoriaDeServicos){
            _categoriaDeServicos = categoriaDeServicos;
        }

        [HttpGet]
        public async Task<IEnumerable<SuperMercado.API.Domain.Categoria>> GetAllAsync(){
            var categorias = await _categoriaDeServicos.ListAsync();
            return categorias;
        }
    }
}

