using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleUI 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RentACarContext context = new RentACarContext();
            CarManager carManager = new CarManager(new EfCarDal());


            List<CarDetailDto> test3 = carManager.CarDetailDto();

            //Add(carManager);

            //Getby(carManager);

            Console.ReadLine();

        }

        private static void Add(CarManager carManager)
        {
            Car Car1 = new Car
            {
                Id = 2,
                BrandId = 1,
                CarName = "Test Car2",
                ColorId = 2,
                ModelYear = 2022,
                DailyPrice = 150,
                Description = "Car is Car"
            };

            carManager.AddCar(Car1);

            List<Car> Test = carManager.GetAll();

            foreach (Car car in Test)
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.CarName);
            }
        }

        private static void Getby(CarManager carManager)
        {
            List<Car> test1 = carManager.GetById(2);
        }
    }
}