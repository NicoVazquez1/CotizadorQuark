using CotizadorQuark.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Repositorios
{
    internal class Tienda <T> where T : Prenda
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Vendedor> Vendedores { get; set; } /// Opcional
        public List<Prenda> prendas { get; set; }
        public Tienda(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
            prendas = new List<Prenda>();//lista o hashmap o dictionary
        }

        public void crearStock()
        {
            Prenda camisaSCortComun = new Camisa(false, true, false, 150);
            Prenda camisaPCortComun = new Camisa(true, true, false, 150);
            Prenda camisaSCortMao = new Camisa(false, true, true, 100);
            Prenda camisaPCortMao = new Camisa(true, true, true, 100);

            Prenda camisaSLargaComun = new Camisa(false, false, false, 75);
            Prenda camisaPLargaComun = new Camisa(true, false, false, 75);
            Prenda camisaSLargaMao = new Camisa(false, false, true, 175);
            Prenda camisaPLargaMao = new Camisa(true, false, true, 175);

            Prenda PantalonSComun = new Pantalon(false, false, 250);
            Prenda PantalonPComun = new Pantalon(true, false, 250);
            Prenda PantalonSChupin = new Pantalon(false, true, 750);
            Prenda PantalonPChupin = new Pantalon(true, true, 750);
        }
        
        //metodos de filtrosBy()

    }
}
