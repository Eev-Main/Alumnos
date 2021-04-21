using System;
using System.Collections.Generic;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
          Alumnos alumnos = new Alumnos();

          Grupo grupo = new Grupo();

          Carreras carreras = new Carreras();

          Institucion institucion = new Institucion();

          Console.WriteLine("--------------------------------------------");
          Console.WriteLine("Alumnos consultado");

          RegAlumnos resultadoConsulta = alumnos.ConsultarAlumnos(2000);
          Console.WriteLine(resultadoConsulta.nombres + " " + resultadoConsulta.Aplleidos + " " + resultadoConsulta.matricula);
          Console.WriteLine("Matricula: " + resultadoConsulta.matricula);

          Console.WriteLine("--------------------------------------------");
          Console.WriteLine();
          Console.WriteLine("Totalidad de alumnos de la institucion");
          Console.WriteLine("Nombre completo Alumnos / Matricula");

          for (int i = 0; i < alumnos.listaAlumnos.Count; i++)
            {
               Console.WriteLine(alumnos.listaAlumnos[i].nombres + " " + alumnos.listaAlumnos[i].Aplleidos + " " + " / " + alumnos.listaAlumnos[i].matricula);
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Alumnos de Segundo Semestre:" );
            foreach (var key in grupo.segundoM.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.segundoM.GetValueOrDefault(key));
            }
            foreach (var key in grupo.segundoA.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.segundoA.GetValueOrDefault(key));
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Alumnos de Cuarto Semestre:" );
            foreach (var key in grupo.cuartoM.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.cuartoM.GetValueOrDefault(key));
            }
            foreach (var key in grupo.cuartoA.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.cuartoA.GetValueOrDefault(key));
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Alumnos de Sexto Semestre:");

            foreach (var key in grupo.sextoM.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.sextoM.GetValueOrDefault(key));
            }
            foreach (var key in grupo.sextoA.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.sextoA.GetValueOrDefault(key));
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Alumnos de octavo Semestre:" );
            foreach (var key in grupo.octavoM.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.octavoM.GetValueOrDefault(key));
            }
            foreach (var key in grupo.octavoA.Keys)
            {
                Console.WriteLine(key.nombres + " " + key.Aplleidos + " " + "(" + "Matricula:" + key.matricula + ")" + ":" + grupo.octavoA.GetValueOrDefault(key));
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Informacion General de la institucion" );
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Carreras disponibles ");

            for (int i = 0; i < institucion.listaCarreras.Count; i++)
            {
               Console.WriteLine(institucion.listaCarreras[i].nombres);
            }
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Grupos actuales ");

            for (int i = 0; i < carreras.IngenieriaMultiMedia.Count; i++)
            {
               Console.WriteLine(carreras.IngenieriaMultiMedia[i].Grupo);
            }
            for (int i = 0; i < carreras.LicenciaturaArtesVisuales.Count; i++)
            {
               Console.WriteLine(carreras.LicenciaturaArtesVisuales[i].Grupo);
            }
        }
    }
}