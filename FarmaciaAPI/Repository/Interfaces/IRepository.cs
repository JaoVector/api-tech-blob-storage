using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using FarmaciaAPI.DTOS;
using System.Linq.Expressions;

namespace FarmaciaAPI.Repository.Interfaces;

public interface IRepository<T>
{
    IQueryable<T> Get(int skip = 0, int take = 4);
    Task<T> BuscaPorID(Expression<Func<T, bool>> expression);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    
}
