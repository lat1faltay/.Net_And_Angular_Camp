using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentACarContext context = new RentACarContext();
            CarManager carManager = new CarManager(new EfCarDal());

            Car Car1 = new Car
            {
                Id = 1,
                BrandId = 1,
                CarName = "Test Car",
                ColorId = 2,
                ModelYear = 2022,
                DailyPrice = 150,
                Description = "Car is Car"
            };

            carManager.AddCar(Car1);
            



        }
    }
}