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
        private static Tienda<Prenda> instancia;
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public List<Camisa> camisas { get; set; }
        public List<Pantalon> pantalones { get; set; }
        private Tienda()
        {
            Nombre = "Marx Brothers deportes"; 
            Direccion = "Calle Mario de Savato 1260";
            camisas = new List<Camisa>();
            pantalones = new List<Pantalon>();
            //ActualizarStock();
        }
        public static Tienda<Prenda> Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Tienda<Prenda>();
                }
                return instancia;
            }
        }
        public void CrearStock()
        {
            Camisa camisaSCortComun = new Camisa(false, true, false, 150);
            Camisa camisaPCortComun = new Camisa(true, true, false, 150);
            Camisa camisaSCortMao = new Camisa(false, true, true, 100);
            Camisa camisaPCortMao = new Camisa(true, true, true, 100);

            Camisa camisaSLargaComun = new Camisa(false, false, false, 75);
            Camisa camisaPLargaComun = new Camisa(true, false, false, 75);
            Camisa camisaSLargaMao = new Camisa(false, false, true, 175);
            Camisa camisaPLargaMao = new Camisa(true, false, true, 175);

            Pantalon PantalonSComun = new Pantalon(false, false, 250);
            Pantalon PantalonPComun = new Pantalon(true, false, 250);
            Pantalon PantalonSChupin = new Pantalon(false, true, 750);
            Pantalon PantalonPChupin = new Pantalon(true, true, 750);

            camisas.Add(camisaSCortComun);
            camisas.Add(camisaPCortComun);
            camisas.Add(camisaSCortMao);
            camisas.Add(camisaPCortMao);

            camisas.Add(camisaSLargaComun);
            camisas.Add(camisaPLargaComun);
            camisas.Add(camisaSLargaMao);
            camisas.Add(camisaPLargaMao);

            pantalones.Add(PantalonSComun);
            pantalones.Add(PantalonPComun);
            pantalones.Add(PantalonSChupin);
            pantalones.Add(PantalonPChupin);
        }
        
        public List<Camisa> getCamisas()
        {
            return camisas;
        }
        public List<Pantalon> getPantalones()
        {
            return pantalones;
        }
        public int ActualizarLista(Prenda prenda, int cantidad) //Crear predicado
        {
            prenda.Cantidad -= cantidad;
            return prenda.Cantidad;
        }
       
    }
}
