using System;
using System.Collections.Generic;

namespace Alumnos
{
    class Alumnos
    {
        public List<RegAlumnos> listaAlumnos;

        public Alumnos()
        {
            listaAlumnos = new List<RegAlumnos>();

            //multimedia
            listaAlumnos.Add(new RegAlumnos("Hicham Millan", "Pina Ortero", 2000));                    //segundo
            listaAlumnos.Add(new RegAlumnos("Alfredo Rios", "Cabo Gomilla", 2001));
            listaAlumnos.Add(new RegAlumnos("Nayra Segovia", "Arango Barrientos", 2002));
            listaAlumnos.Add(new RegAlumnos("Ayoub Aguado", "Mordelada Tur", 2003));
            listaAlumnos.Add(new RegAlumnos("Imanol Perera", "Zafra Conejo", 2004));
            listaAlumnos.Add(new RegAlumnos("Aquilino Herrera", "Nogales Goncalvez", 2005));            //cuarto
            listaAlumnos.Add(new RegAlumnos("Hugo Adan", "Gudes Romano", 2006));
            listaAlumnos.Add(new RegAlumnos("Lazaro Barroso", "Gonzalez Orona", 2007));
            listaAlumnos.Add(new RegAlumnos("Nicolas Gil", "Mendizabal Hanamura", 2008));
            listaAlumnos.Add(new RegAlumnos("Pedro Luis Abellan", "Tejedor Molina", 2009));
            listaAlumnos.Add(new RegAlumnos("Ivan de las Heras", "Zavodila Piera", 2010));              //sexto
            listaAlumnos.Add(new RegAlumnos("Mariano Valdes", "Muhamed Pardes", 2011));
            listaAlumnos.Add(new RegAlumnos("Felix Guirado", "Reina Boix", 2012));
            listaAlumnos.Add(new RegAlumnos("Joseba Valencia", "Pintor Briz", 2013));
            listaAlumnos.Add(new RegAlumnos("Juan Angel", "Pacheco Ventura", 2014));
            listaAlumnos.Add(new RegAlumnos("Ibon Alamo", "Balboa Miñana", 2015));                      //octavo
            listaAlumnos.Add(new RegAlumnos("Ibai LLanos", "Tague de Paz", 2016));
            listaAlumnos.Add(new RegAlumnos("Samuel Becerra", "De Luque", 2017));
            listaAlumnos.Add(new RegAlumnos("Manuel Francisco", "Guillermo del toro", 2018));
            listaAlumnos.Add(new RegAlumnos("Jose Gaspar", "Jordan Caño", 2019));

            //artes visuales
            listaAlumnos.Add(new RegAlumnos("Juan Luis ", "Londoño Arias", 2050));                      //segundo
            listaAlumnos.Add(new RegAlumnos("Erik Villegas", "Caro Domenech", 2051));
            listaAlumnos.Add(new RegAlumnos("Felipe", "Garcia Cristobal", 2052));
            listaAlumnos.Add(new RegAlumnos("Salvador Saenz", "Zapatero LLanos", 2053));
            listaAlumnos.Add(new RegAlumnos("Manuel Ayala", "Cavero Ramis", 2054));
            listaAlumnos.Add(new RegAlumnos("Maria Asuncion", "Rodriguez", 2055));                      //Cuarto
            listaAlumnos.Add(new RegAlumnos("Sebastiana Saavedra", "Mate Mondero", 2056));
            listaAlumnos.Add(new RegAlumnos("Georgina Peris", "Garcia Barbosa", 2057));
            listaAlumnos.Add(new RegAlumnos("Myriam Menendez", "Leon Galvez", 2058));
            listaAlumnos.Add(new RegAlumnos("Maria Maria", "Maria de Vadillo", 2059));
            listaAlumnos.Add(new RegAlumnos("Arnau Paz ", "Aragones Cortes", 2060));                      //sexto
            listaAlumnos.Add(new RegAlumnos("Adam Navarrete", "Ordoñez Ugarte", 2061));
            listaAlumnos.Add(new RegAlumnos("Federico Peral", "Berbel saiz", 2062));
            listaAlumnos.Add(new RegAlumnos("Saida Sierra", "Nogues Vasquez", 2063));
            listaAlumnos.Add(new RegAlumnos("Elisabeth Fajardo", "Castaño Cuello", 2064));
            listaAlumnos.Add(new RegAlumnos("Micaela Enriquez", "padin sanez", 2055));                      //Octavo
            listaAlumnos.Add(new RegAlumnos("Daniela Aparicio", "Jaen Carbo", 2056));
            listaAlumnos.Add(new RegAlumnos("Esteban Pico", "Santos Aranda", 2057));
            listaAlumnos.Add(new RegAlumnos("Sergi Rodríguez ", "Latorre Flores", 2058));
            listaAlumnos.Add(new RegAlumnos("Fabian Hervas", "Labrador Santana", 2059));

        }

        
        public RegAlumnos ConsultarAlumnos(int matricula)
         {
            for (int i = 0; i < listaAlumnos.Count; i++)
            {
                if(listaAlumnos[i].matricula == matricula)
                {
                    return listaAlumnos[i];
                }
            }
            return null;
        }

    }

}