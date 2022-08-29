using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalgadoController : ControllerBase
    {
        private SalgadoRepository _repository;

        public SalgadoController()
        {
            this._repository = new SalgadoRepository();
        }

        [HttpGet(Name = "Salgado")]
        public List<Salgado> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Salgado GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public string Post(Salgado model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public string Update(Salgado model)
        {
            return _repository.Update(model);
        }


    }
}
