using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;
        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }
        public IResult Delete(Basket basket)
        {
            _basketDal.Delete(basket);
            return new SuccessResult(Messages.BasketDeleted);
        }

        public IDataResult<List<Basket>> GetAll()
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll());
        }

        public IDataResult<Basket> GetById(int basketId)
        {
            return new SuccessDataResult<Basket>(_basketDal.Get(b => b.Id == basketId));
        }

        public IResult Update(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult(Messages.BasketUpdated);
        }
    }
}
