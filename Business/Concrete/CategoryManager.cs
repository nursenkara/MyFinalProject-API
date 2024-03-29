﻿using Business.Abstract;
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
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId));
        }
        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _categoryDal.Add(category);

            return new SuccessResult(Messages.CategoryAdded);

        }
        public IResult Delete(Category category)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _categoryDal.Delete(category);

            return new SuccessResult(Messages.CategoryDeleted);

        }
        public IResult Update(Category category)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;

            }

            _categoryDal.Update(category);

            return new SuccessResult(Messages.CategoryUpdated);
        }
    }
}
