using trabajoEje.Model;
using System.Collections.Generic;
using System.Linq;


namespace trabajoEje.Service
{
    public interface IAlumnoService
    {
        List<Alumno> GetAll();
        Alumno Get(int id);
        void Save(Alumno alumno);
        void Delete(int id);

    }

}
