using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Models;

namespace SuperMercado.API.Domain{
    
    public class Categoria{
        public int Id {get; set;}

        public string Nome {get; set;}

        public IList<Produto> Produtos {get; set;} = new List<Produto>();  
    }
}