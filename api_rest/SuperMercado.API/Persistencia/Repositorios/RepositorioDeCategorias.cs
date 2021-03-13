using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Repositorios;
using api_rest.Domain.Models;
using Microsoft.EntityFrameworkCore;
using SuperMercado.API.Domain;

namespace api_rest.Persistencia.Repositorios
{
    public class RepositorioDeCategoria : RepositorioBase, ICategoriaDeRepositorio
    {
        public RepositorioDeCategoria(AppDbContext context) : base(context){}

        public async Task<IEnumerable<Categoria>> ListAsync()
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}