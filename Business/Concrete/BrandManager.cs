using Business.Abstract;
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

        public BrandManager(IBrandDal branDal)
        {
            _brandDal = branDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();

        }
    }
}
