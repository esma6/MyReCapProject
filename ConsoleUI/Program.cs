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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails()) 
            {
                Console.WriteLine("{0}--{1}--{2}---{3}",car.BrandName,car.CarName,car.ColorName,car.DailyPrice);
            }

        }
    }
}
