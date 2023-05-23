using Capa_Datos.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Query
{
    public class CD_Estudiante
    {

        public async Task InsertarEstudiante(Estudiante est)
        {
            using (var data = new Context())
            {
                data.Add(est);
                await data.SaveChangesAsync();
            }

        }

        public async Task ActualizarEstudiante(Estudiante est)
        {
            using (var data = new Context())
            {
                Estudiante estudent = await data.Estudiantes.FindAsync(est.EstudianteId);

                estudent.Nombre = est.Nombre;
                estudent.Apellido = est.Apellido;
                estudent.Telefono = est.Telefono;
                estudent.Correo = est.Correo;
                



                data.Estudiantes.Update(estudent);
                await data.SaveChangesAsync();
            }

        }

        public async Task BorrarEstudiante(int id)
        {
            using (var data = new Context())
            {
                Estudiante estudent = await data.Estudiantes.FindAsync(id);
                data.Remove(estudent);
                await data.SaveChangesAsync();
            }

        } 
        
        public List<Estudiante> MostrarEstudiantes()
        {
            using (var data = new Context())
            {
                return data.Estudiantes.ToList();
            }
        }








    }
}
