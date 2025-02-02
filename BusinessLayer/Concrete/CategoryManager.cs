﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager:ICategoryService
    {

        ICategoryDal _categoryDal;

        //GenericRepository<Category> repo = new GenericRepository<Category>();

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //public List<Category> GetAllBL()
        //{
        //    return repo.List();
        //}

        //public void CategoryAddBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 ||
        //        p.CategoryDescription == "" || p.CategoryName.Length >= 51)
        //    {
        //        //hata
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x => x.CategoryID == id);
        }

        public void CategoryDeleteBL(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }
    }
}
