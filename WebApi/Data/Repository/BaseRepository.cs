using Data.Context;
using Data.Model;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        public string Create(T entity)
        {
            using (FoodContext foodContext = new FoodContext())
            {
                foodContext.Set<T>().Add(entity);
                foodContext.SaveChanges();
            }
            return "Objeto criado";
        }

        public string Delete(int id)
        {
            T entity = GetById(id);

            using (FoodContext foodContext = new FoodContext())
            {
                foodContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                foodContext.SaveChanges();
            }
            return "Objeto deletado";
        }

        public List<T> GetAll()
        {
            List<T> list = new List<T>();

            using (FoodContext foodContext = new FoodContext())
            {
                list = foodContext.Set<T>().ToList();
            }

            return list;
        }

        public T GetById(int id)
        {
            T entity = null;

            using (FoodContext foodContext = new FoodContext())
            {
                entity = foodContext.Set<T>().Find(id);
            }

            return entity;
        }

        public string Update(T entity)
        {
            using (FoodContext foodContext = new FoodContext())
            {
                foodContext.Entry<T>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                foodContext.SaveChanges();
            }
            return "Objeto alterado";
        }

    }
}
