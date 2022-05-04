using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    /// <summary>
    /// Şartlarımız;
    /// Bir "T" al, bu bir class olmalı ve IEntity ile implement edilmiş olmalı ve aynı zamanda new'lenebilir olsun.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Bir sorgu yapabiliriz ve bu sorgu null'da olabilir.
        T Get(Expression<Func<T, bool>> filter);
    }
}
