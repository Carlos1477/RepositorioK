using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trabajoEje.Model;
using trabajoEje.Service;
using Microsoft.AspNetCore.Mvc;

namespace trabajoEje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private IAlumnoService alumnoService;
        public ValuesController(IAlumnoService alumnoService) 
        {
            this.alumnoService = alumnoService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IList<Alumno>> Get()
        {
            return alumnoService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            return alumnoService.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Alumno alumno)
        {
            alumnoService.Save(alumno);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Alumno alumno)
        {
            alumnoService.Save(alumno);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            alumnoService.Delete(id);
        }
    }
}
