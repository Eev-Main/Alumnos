using System;
using System.Collections.Generic;

namespace Alumnos
{
    class Grupo
    {
        public Dictionary<RegAlumnos,string> segundoM;

        public Dictionary<RegAlumnos,string> cuartoM;

        public Dictionary<RegAlumnos,string> sextoM;

        public Dictionary<RegAlumnos,string> octavoM;

        public Dictionary<RegAlumnos,string> segundoA;

        public Dictionary<RegAlumnos,string> cuartoA;

        public Dictionary<RegAlumnos,string> sextoA;

        public Dictionary<RegAlumnos,string> octavoA;
        
        public Grupo()
        {
            segundoM = new Dictionary<RegAlumnos,string>();
            segundoM.Add(new RegAlumnos("Hicham Millan", "Pina Ortero", 2000), "Segundo semestre");                    //segundoM
            segundoM.Add(new RegAlumnos("Alfredo Rios", "Cabo Gomilla", 2001), "Segundo semestre");
            segundoM.Add(new RegAlumnos("Nayra Segovia", "Arango Barrientos", 2002), "Segundo semestre");
            segundoM.Add(new RegAlumnos("Ayoub Aguado", "Mordelada Tur", 2003), "Segundo semestre");
            segundoM.Add(new RegAlumnos("Imanol Perera", "Zafra Conejo", 2004), "Segundo semestre");
            cuartoM = new Dictionary<RegAlumnos,string>();
            cuartoM.Add(new RegAlumnos("Aquilino Herrera", "Nogales Goncalvez", 2005), "Cuarto semestre");            //cuartoM
            cuartoM.Add(new RegAlumnos("Hugo Adan", "Gudes Romano", 2006), "Cuarto semestre");
            cuartoM.Add(new RegAlumnos("Lazaro Barroso", "Gonzalez Orona", 2007), "Cuarto semestre");
            cuartoM.Add(new RegAlumnos("Nicolas Gil", "Mendizabal Hanamura", 2008), "Cuarto semestre");
            cuartoM.Add(new RegAlumnos("Pedro Luis Abellan", "Tejedor Molina", 2009), "Cuarto semestre");
            sextoM = new Dictionary<RegAlumnos,string>();
            sextoM.Add(new RegAlumnos("Ivan de las Heras", "Zavodila Piera", 2010), "Sexto semestre");              //sextoM
            sextoM.Add(new RegAlumnos("Mariano Valdes", "Muhamed Pardes", 2011), "Sexto semestre");
            sextoM.Add(new RegAlumnos("Felix Guirado", "Reina Boix", 2012), "Sexto semestre");
            sextoM.Add(new RegAlumnos("Joseba Valencia", "Pintor Briz", 2013), "Sexto semestre");
            sextoM.Add(new RegAlumnos("Juan Angel", "Pacheco Ventura", 2014), "Sexto semestre");
            octavoM = new Dictionary<RegAlumnos,string>();
            octavoM.Add(new RegAlumnos("Ibon Alamo", "Balboa Miñana", 2015), "Octavo Semestre");                      //octavoM
            octavoM.Add(new RegAlumnos("Ibai LLanos", "Tague de Paz", 2016), "Octavo Semestre");
            octavoM.Add(new RegAlumnos("Samuel Becerra", "De Luque", 2017), "Octavo Semestre");
            octavoM.Add(new RegAlumnos("Manuel Francisco", "Guillermo del toro", 2018), "Octavo Semestre");
            octavoM.Add(new RegAlumnos("Jose Gaspar", "Jordan Caño", 2019), "Octavo Semestre");
            segundoA = new Dictionary<RegAlumnos, string>();
            segundoA.Add(new RegAlumnos("Juan Luis ", "Londoño Arias", 2050), "Segundo semestre");                      //segundoA
            segundoA.Add(new RegAlumnos("Erik Villegas", "Caro Domenech", 2051), "Segundo semestre");
            segundoA.Add(new RegAlumnos("Felipe", "Garcia Cristobal", 2052), "Segundo semestre");
            segundoA.Add(new RegAlumnos("Salvador Saenz", "Zapatero LLanos", 2053), "Segundo semestre");
            segundoA.Add(new RegAlumnos("Manuel Ayala", "Cavero Ramis", 2054), "Segundo semestre");
            cuartoA = new Dictionary<RegAlumnos,string>();
            cuartoA.Add(new RegAlumnos("Maria Asuncion", "Rodriguez", 2055), "Cuarto semestre");                      //CuartoA
            cuartoA.Add(new RegAlumnos("Sebastiana Saavedra", "Mate Mondero", 2056), "Cuarto semestre");
            cuartoA.Add(new RegAlumnos("Georgina Peris", "Garcia Barbosa", 2057), "Cuarto semestre");
            cuartoA.Add(new RegAlumnos("Myriam Menendez", "Leon Galvez", 2058), "Cuarto semestre");
            cuartoA.Add(new RegAlumnos("Maria Maria", "Maria de Vadillo", 2059), "Cuarto semestre");
            sextoA = new Dictionary<RegAlumnos,string>();
            sextoA.Add(new RegAlumnos("Arnau Paz ", "Aragones Cortes", 2060), "Sexto semestre");                      //sexto
            sextoA.Add(new RegAlumnos("Adam Navarrete", "Ordoñez Ugarte", 2061), "Sexto semestre");
            sextoA.Add(new RegAlumnos("Federico Peral", "Berbel saiz", 2062), "Sexto semestre");
            sextoA.Add(new RegAlumnos("Saida Sierra", "Nogues Vasquez", 2063), "Sexto semestre");
            sextoA.Add(new RegAlumnos("Elisabeth Fajardo", "Castaño Cuello", 2064), "Sexto semestre");
            octavoA = new Dictionary<RegAlumnos,string>();
            octavoA.Add(new RegAlumnos("Micaela Enriquez", "padin sanez", 2055), "Octavo Semestre");                      //Octavo
            octavoA.Add(new RegAlumnos("Daniela Aparicio", "Jaen Carbo", 2056), "Octavo Semestre");
            octavoA.Add(new RegAlumnos("Esteban Pico", "Santos Aranda", 2057), "Octavo Semestre");
            octavoA.Add(new RegAlumnos("Sergi Rodríguez ", "Latorre Flores", 2058), "Octavo Semestre");
            octavoA.Add(new RegAlumnos("Fabian Hervas", "Labrador Santana", 2059), "Octavo Semestre");
        }
    }
}