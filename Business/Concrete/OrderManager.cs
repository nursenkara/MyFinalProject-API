using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //Sipariş...
    public class OrderManager : IOrderService
    {
        
        IOrderDal _orderDal;
        //constructor injection
        ILogger _logger;
        IProductService _productService;
        public OrderManager(IOrderDal orderDal,IProductService productService)
        {
            _orderDal = orderDal;
            _productService = productService;
        }
        public IResult Add(Order order)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _orderDal.Add(order);

            return new SuccessResult(Messages.OrderAdded);
        }

        public IDataResult<List<Order>> GetAll()
        {
           
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(), Messages.OrdersListed);
        }

        public IDataResult<Order> GetById(int orderId)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.Id == orderId));
        }

        

        public IResult Update(Order order)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _orderDal.Update(order);

            return new SuccessResult(Messages.OrderUpdated);
        }
    }
}
