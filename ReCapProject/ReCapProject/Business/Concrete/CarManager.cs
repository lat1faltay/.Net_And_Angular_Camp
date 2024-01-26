using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddCar(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else if (car.CarName.Length < 2)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalıdır!");
            }else if (car.DailyPrice > 0) 
            { 
                Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır!");
            }
            Console.WriteLine("Araba Başarıyla Eklendi");
        }

        public List<CarDetailDto> CarDetailDto()
        {
            return _carDal.CarDetailDto();
        }


        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.Id==id);
        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(c => c.ColorId == ColorId);
        }

 

        // Crud operasyonları



    }
}
