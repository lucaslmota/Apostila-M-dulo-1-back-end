using System.Collections.Generic;
using System.Threading.Tasks;
using api_rest.Domain.Models;
using SuperMercado.API.Domain;

namespace api_rest.Domain.Repositorios
{  
        public interface ICategoriaDeRepositorio{
            Task<IEnumerable<Categoria>> ListAsync();
        }
    
}