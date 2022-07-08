using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    //Crear otro para ser repo?
    //Static o instancia?
    internal class Tienda //: list <T>  *Seria nuestro repo
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Vendedor> Vendedores { get; set; } /// Opcional
        public List<Prenda> prendas { get; set; }
        public Tienda(string nombre, string direccion)
        { 
            //se debe conectar con una BB DD
            Nombre = nombre;
            Direccion = direccion;
            Vendedores = new List<Vendedor>(); 
            prendas = new List<Prenda>();//lista o hashmap o dictionary
        }

        //metodos de filtrosBy()
        
    }
}
