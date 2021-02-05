using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    //class : referans tip olabilir,
    // IEntity : IEntity olabilir veya IEntity yi implemente eden bir nesne olabilir,
    //new() : new lenebilir olmalı yani şuan IEntity olamaz sadece onu implemente eden nesne olabilir, T.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
