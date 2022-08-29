using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoceController : ControllerBase
    {
        private DoceRepository _repository;
         
        public DoceController()
        {
          this._repository = new DoceRepository();
        }

        [HttpGet(Name = "Doce")]
        public List<Doce> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Doce GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public string Post(Doce model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public string Update(Doce model)
        {
            return _repository.Update(model);
        }
        

    }
}
