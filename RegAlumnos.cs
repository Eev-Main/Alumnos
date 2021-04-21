using System;


namespace Alumnos
{
    class RegAlumnos
    {
        public string nombres;
        public string Aplleidos;
        public int matricula;

        public RegAlumnos(string nombres,string apellidos, int matricula)
        {
            this.nombres = nombres;
            this.Aplleidos = apellidos;
            this.matricula = matricula;
        }
    }
}