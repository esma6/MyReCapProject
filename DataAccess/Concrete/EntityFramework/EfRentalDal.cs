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
                    var result = from rent in context.Rentals
                                 join car in context.Cars on rent.CarId equals car.CarId
                                 join brand in context.Brands on car.BrandId equals brand.BrandId
                                 join color in context.Colors on car.ColorId equals color.ColorId
                                 join cus in context.Customers on rent.CustomerId equals cus.Id
                                 join user in context.Users on cus.UserId equals user.Id
                                 select new RentalDetailDto
                                 {
                                     Id = rent.Id,
                                     CarName = car.CarName,
                                     BrandName = brand.BrandName,
                                     ColorName = color.ColorName,
                                     CompanyName = cus.CompanyName,
                                     FirstName = user.FirstName,
                                     LastName = user.LastName,
                                     RentDate = rent.RentDate,
                                     ReturnDate = (DateTime)rent.ReturnDate,
                                 };

                    return result.ToList();
                }
            }
        }
    }

