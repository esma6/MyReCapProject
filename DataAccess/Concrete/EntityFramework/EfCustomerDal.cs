
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.DataAccess;
using Entities.Concrete.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (var context = new RentACarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Status = u.Status,
                                 CompanyName = c.CompanyName
                             };

                return result.ToList();
            }
        }
    }
}

