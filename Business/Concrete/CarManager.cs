using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length >= 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç eklendi.");

            }
            else
            {
                Console.WriteLine("Araç eklenemedi ");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba silindi.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0 && car.CarName.Length >= 2)
            {

                _carDal.Update(car);
                Console.WriteLine("Güncelleme işlemi başarılı.");
            }
            else
            {
                Console.WriteLine("Güncellenemedi ");
            }
        }
    }
}
