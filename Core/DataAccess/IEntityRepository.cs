using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Repository Pattern
    //Generic constraint kısıt
    //class: referans tip olabilir
    //IEntity : IENTITY olabilir veya IEntity i implemente eden bir sınıf olabilir
    // new(): new'lenebilir olmalı IEntity new'lenemez
    //core katmanı hiçbir katmandan referans almaz!!!

    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //delegedir expression filter kullanmak için category ye göre ara, product id ye göre ara gibi
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
