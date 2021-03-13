using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Models;
using api_rest.Domain.Repositorios;
using api_rest.Domain.Servicos;

namespace api_rest.Servicos
{
    public class CategoriaDeServicos : ICategoriaDeServicos{
        
        private readonly ICategoriaDeRepositorio _categoriaDeRepositorio;

        public CategoriaDeServicos(ICategoriaDeRepositorio categoriaDeRepositorio ){
            this._categoriaDeRepositorio = categoriaDeRepositorio;
        }
        public async Task<IEnumerable<SuperMercado.API.Domain.Categoria>> ListAsync(){
            return await _categoriaDeRepositorio.ListAsync();
        }
    }
}