using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Entidad
{
    public class Matricula
    {
        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }
        public Estudiante Estudiante { get; set; }
        public Asignatura Asignatura { get; set; }

    }
}
