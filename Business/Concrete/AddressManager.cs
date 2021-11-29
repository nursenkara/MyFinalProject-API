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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public IResult Add(Address address)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _addressDal.Add(address);
            return new SuccessResult(Messages.AddressAdded);
        }
        public IResult Delete(Address address)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _addressDal.Delete(address);
            return new SuccessResult(Messages.AddressDeleted);
        }
        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll());
        }

        public IDataResult<Address> GetById(int addressId)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(a => a.Id == addressId));
        }

        public IResult Update(Address address)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _addressDal.Update(address);
            return new SuccessResult(Messages.AddressUpdated);
        }
    }
}
