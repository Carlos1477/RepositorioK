using trabajoEje.Model;
using System.Collections.Generic;
using System.Linq;

namespace trabajoEje.Service
{
    public class AlumnoService : IAlumnoService
    {
        private List<Alumno> list;

        public AlumnoService()
        {
            list = new List<Alumno>();

            var alumno1 = new Edit() { Id = 1, Nombre = "Alumno 1"};

            list.Add(new Alumno()
            {
                Id = 1,
                Nombre = "Pepe",
                Apellido = "Maripan",
                Edad = 13,
                Edit = alumno1
            });

            list.Add(new Alumno()
            {
                Id = 2,
                Nombre = "Juan",
                Apellido = "Alvarez",
                Edad = 17,
                Edit = alumno1
            });

            list.Add(new Alumno()
            {
                Id = 3,
                Nombre = "Sandra",
                Apellido = "Fernandez",
                Edad = 21,
                Edit = alumno1
            });
        }
        public List<Alumno>GetAll()
        {
            return list;
        }
        public Alumno Get(int id)
        {
            return list.FirstOrDefault(b => b.Id == id);
        }

        public void Save(Alumno alumno)
        {
            this.Delete(alumno.Id);
            list.Add(alumno);
        }
        public void Delete(int id)
        {
            var alumno = this.Get(id);
            if (alumno != null)
            {
                list.Remove(alumno);
            }
        }
    }
}
