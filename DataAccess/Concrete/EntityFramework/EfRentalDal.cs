using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
       
            public List<RentalDetailDto> GetRentalDetails()
            {
                using (var context = new RentACarContext())
                {
                var result = from r in context.Rentals
                             join car in context.Cars on r.CarId equals car.CarId
                             join b in context.Brands on car.BrandId equals b.BrandId
                             join c in context.Customers on r.CustomerId equals c.Id
                             join u in context.Users on c.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 Id = b.BrandId,
                                 CarName = car.CarName,
                                 UserName = u.FirstName + " " + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate ?? DateTime.Now
                             };
                return result.ToList();
            }
            }
        }
    }

