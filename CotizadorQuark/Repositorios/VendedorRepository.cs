using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizadorQuark.Modelos;

namespace CotizadorQuark.Repositorios
{
    internal class VendedorRepository : List<Vendedor>
    {
        private static VendedorRepository instancia;
        List<Vendedor> Vendedores = new List<Vendedor>();
        private VendedorRepository()
        {
            Vendedores.Add(new Vendedor("Jorge", "Perez"));
            Vendedores.Add(new Vendedor("Juan", "Fernandez"));
        }
        public static VendedorRepository Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new VendedorRepository();
                }
                return instancia;
            }
        }

        public Vendedor GetVendedor(string nombre)
        {
            return Vendedores.FirstOrDefault(v => v.Nombre == nombre);
        }
    }
}
