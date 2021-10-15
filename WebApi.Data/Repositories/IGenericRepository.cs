using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Data.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<ICollection<T>> GetAll();
        //Task<ICollection<T>> GetAllPaging(Expression<Func<T, bool>> filter, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //    string includeProperties = "", int pageSize = 10, int pageNumber = 1);
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
