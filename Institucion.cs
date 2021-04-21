using System;
using System.Collections.Generic;

namespace Alumnos
{
    class Institucion
    {
        public List<RegCarreras> listaCarreras;

        public Institucion()
        {
            listaCarreras = new List<RegCarreras>();

            listaCarreras.Add(new RegCarreras("Ingenieria en Multimedia"));
            listaCarreras.Add(new RegCarreras("Licenciatura en Artes Visuales"));
        }

    }
}