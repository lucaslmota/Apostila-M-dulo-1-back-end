using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_rest.Domain.Ajudantes;
using SuperMercado.API.Domain;

namespace api_rest.Domain.Models
{
    public class Produto{
        public int Id{get; set;}

         public string Nome {get; set;}

         public short QuantidadeNoPacote{get; set;}

         public EUnitOfMeasurement UnitOfMeasurement {get; set;}

         public int CategoriaId {get; set;}

         public Categoria Categoria {get; set;}
    }
    
}