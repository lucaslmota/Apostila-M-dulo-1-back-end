using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace api_rest.Domain.Ajudantes
{
   public enum EUnitOfMeasurement : byte
   {
       [Description("UN")]
       Unidade = 1,

       [Description("MG")]
       Miligrama = 2,

       [Description("G")]
       Grama = 3,

       [Description("KG")]
       kilograma = 1,

       [Description("L")]
       Litro = 5,

   }

}