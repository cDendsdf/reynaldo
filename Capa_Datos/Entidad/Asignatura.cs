using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Entidad
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<Matricula> Matriculas { get; set; }

    }
}
