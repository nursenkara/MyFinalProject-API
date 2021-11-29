using Business.Abstract;
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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _brandDal.Add(brand);

            return new SuccessResult(Messages.BrandAdded);

        }
        public IResult Delete(Brand brand)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _brandDal.Delete(brand);

            return new SuccessResult(Messages.BrandDeleted);

        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == brandId));
        }

        public IResult Update(Brand brand)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _brandDal.Update(brand);

            return new SuccessResult(Messages.BrandUpdated);

        }
    }
}
