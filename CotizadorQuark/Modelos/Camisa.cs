﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizadorQuark.Modelos
{
    internal class Camisa : Prenda
    {
        public bool EsMangaCort { get; set; }
        public bool EsCuelloMao { get; set; }
        public Camisa(bool esPremium, bool esMangaCort, bool esCuelloMao, int cantidad) : base(esPremium, cantidad)
        {
            EsMangaCort = esMangaCort;
            EsCuelloMao = esCuelloMao;
        }
        public new double ValidarPrecio(double precio)
        {
            precio = base.ValidarPrecio(precio);
            if (EsMangaCort)
            {
                precio *= 0.9;
            }
            if (EsCuelloMao)
            {
                precio *= 1.03;
            }
            Precio = precio;
            return Precio;
        }
    }
}