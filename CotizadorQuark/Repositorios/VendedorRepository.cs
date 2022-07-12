using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorQuark.Modelos;

namespace CotizadorQuark.Repositorios
{
    internal class VendedorRepository
    {
        public static List<Vendedor> GetVendedores()
        {
            return new List<Vendedor>()
            {
                new Vendedor("Jorge", "Perez"),
                new Vendedor("Juan", "Fernandez"), 
            };
        }
    }
    
}
