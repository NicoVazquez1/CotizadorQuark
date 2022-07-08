using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal class Camisas : Prenda
    {
        bool EsMangaCorta { get; set; }
        bool EsCuelloMao { get; set; }
        public Camisas(double precio, bool esPremium, bool esMangaCorta, bool esCuelloMao) : base(precio, esPremium)
        {
            EsMangaCorta = esMangaCorta;
            EsCuelloMao = esCuelloMao;

            //Buscar forma de implementar lambda => 
            //Extraer las RN a otra clase 

            if (EsMangaCorta)
            {
                precio *= 0.9;
            }
            if (EsCuelloMao)
            {
                precio *= 1.03;
            }
            Precio = precio;
        }
    }
}
