using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            // DeleteCustomer(customerManager);
            //AddCustomer(customerManager);
            //UpdateCustomer(customerManager);

          

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetCarDetails();
            //if(result.Success==true)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine("{0}--{1}--{2}",car.BrandName,car.CarName,car.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


        }
        public static void DeleteCustomer(CustomerManager customerManager)
        {
            Console.Clear();
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine($"{customer.Id}. {customer.CompanyName}");
            }
            Console.Write("Lütfen Sistemden Silmek Istediğiniz Müşterinin Id sini Giriniz:");
            int customerId = Convert.ToInt32(Console.ReadLine());
            customerManager.Delete(new Customer { Id = customerId });
        }
        public static void AddCustomer(CustomerManager customerManager)
        {
            Console.Clear();
            Console.WriteLine("Lütfen Yeni Müşteri Kaydı İçin Aşağıda ki Bilgileri Giriniz.");
            Console.Write("Lütfen  eklemek Istediğiniz Müşterinin userId sini Giriniz:");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Şirket Adı: ");
            string companyName = Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine(customerManager.Add(new Customer {UserId=userId, CompanyName = companyName }).Message);
        }
        public static void UpdateCustomer(CustomerManager customerManager)
        {
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(" CustomerId:{0} UserId:{1} CompanyName:{2}\n", customer.Id, customer.UserId, customer.CompanyName);
            }
            Console.Write("Lütfen güncellemek Istediğiniz Müşterinin id sini Giriniz:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("UserId Id:");
            int userId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Şirket Adı:");
            string companyName = Console.ReadLine();
            Console.WriteLine( customerManager.Update(new Customer { Id = id, UserId = userId, CompanyName = companyName}).Message);
        }
    }
}
