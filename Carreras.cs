using System;
using System.Collections.Generic;

namespace Alumnos
{
    class Carreras
    {
        public List<RegGrupo> IngenieriaMultiMedia;

        public List<RegGrupo> LicenciaturaArtesVisuales;

        public Carreras()
        {
            IngenieriaMultiMedia = new List<RegGrupo>();
            IngenieriaMultiMedia.Add(new RegGrupo("Segundo Semestre de Multimedia"));
            IngenieriaMultiMedia.Add(new RegGrupo("Cuarto Semestre de Multimedia"));
            IngenieriaMultiMedia.Add(new RegGrupo("Sexto Semestre de Multimedia"));
            IngenieriaMultiMedia.Add(new RegGrupo("Octavo Semestre de Multimedia"));

            LicenciaturaArtesVisuales = new List<RegGrupo>();
            IngenieriaMultiMedia.Add(new RegGrupo("Segundo Semestre de Artes Visuales"));
            IngenieriaMultiMedia.Add(new RegGrupo("Cuarto Semestre de Artes Visuales"));
            IngenieriaMultiMedia.Add(new RegGrupo("Sexto Semestre de Artes Visuales"));
            IngenieriaMultiMedia.Add(new RegGrupo("Octavo Semestre de Artes Visuales"));
            
        }
    }
}