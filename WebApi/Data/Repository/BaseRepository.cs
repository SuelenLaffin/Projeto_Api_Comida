using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public string Create(T entity)
        {
            throw new NotImplementedException();
        }

        public string Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
