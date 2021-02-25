using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core : Evrensel katman
    //Core katmanları diğer katmanları referans almaz
    //generic constrait --> generic kısıtlama
    //class : referans olabilir
    //IEntity : IEntity olabilir veya IEntity implemente eden bir framework olabilir
    //new() : new lenebilir olmalı
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //bu kod ürünleri filtrelemekte kullanılır. category e göre bu ürün gibi filtreler
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
