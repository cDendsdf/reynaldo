using AutoMapper;
using Capa_Datos;
using Capa_Datos.DTOs;
using Capa_Datos.Entidad;

namespace Capa_Negocio
{
    public class CN_Estudiante
    {
        private Capa_Datos.Query.CD_Estudiante CD_Estudiante = new();

        public async Task InsertarEstudiante(EstudianteCreacionDTOs DTO)
        {
            Estudiante est = new();

            est.Nombre = DTO.Nombre;
            est.Apellido = DTO.Apellido;
            est.Telefono = DTO.Telefono;
            est.Correo = DTO.Correo;


            await CD_Estudiante.InsertarEstudiante(est);


        }

        public async Task ActualizarEstudiante(EstudianteDTO DTO)
        {
            Estudiante est = new();

            est.Nombre = DTO.Nombre;
            est.Apellido = DTO.Apellido;
            est.Telefono = DTO.Telefono;
            est.Correo = DTO.Correo;
            est.EstudianteId = DTO.EstudianteId;


            await CD_Estudiante.ActualizarEstudiante(est);



        }

        public async Task BorrarEstudiante(int id)
        {

            await CD_Estudiante.BorrarEstudiante(id);


        }

        public List<Estudiante> MostrarEstudiantes()
        {

            return CD_Estudiante.MostrarEstudiantes();

        }




    }
}