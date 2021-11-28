using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //ORM: veritabanı nesneleri ile classları bir arada kullanmayı sağlar. linq ile çalışır. object relational mapping
    public class EfProductDal : EfEntityRepositoryBase<Product, ECommerceContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (ECommerceContext context=new ECommerceContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.Id
                             select new ProductDetailDto { ProductId = p.Id, ProductName = p.Name, CategoryName = c.Name };
                //IQueryable döndürür bundan dolayı tolist komutunu kullandık.
                //linq ile sorgu
                return result.ToList();
            } 
        }
    }
}
