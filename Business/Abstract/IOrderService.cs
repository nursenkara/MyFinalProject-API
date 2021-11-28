using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> GetById(int orderId);
        //data da döndürmek isteyenler için IDataResult
        IResult Add(Order order);
        //void döndürenler için IResult
        IResult Update(Order order);
    }
}
