using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Models;
using SuperMercado.API.Domain;

namespace api_rest.Domain.Servicos
{
    public interface ICategoriaDeServicos{
        Task<IEnumerable<Categoria>> ListAsync();
    }
}