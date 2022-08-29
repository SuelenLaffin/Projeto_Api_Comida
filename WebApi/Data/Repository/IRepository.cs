using Data.Model;

namespace Data.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        string Create(T entity);
        string Update(T entity);
        string Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}