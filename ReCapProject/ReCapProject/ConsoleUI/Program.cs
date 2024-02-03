using Business.Abstract;
using Business.Concrete;
using Core.Utilities;
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

            //var result = carManager.GetById(1);

            //foreach (var item in result.Data) 
            //{ 
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.CarName);
            //    Console.WriteLine(item.ModelYear);

            //}


            //List<CarDetailDto> test3 = carManager.CarDetailDto();

            //Add(carManager);

            //Getby(carManager);

            //var test2 = new ColorManager(new EfColorDal());
            //var test3 = new ColorManager(new EfColorDal2());

            //IDataResult<List<Color>> test4 = test2.GetAll();
            //IDataResult<List<Color>> test5 = test3.GetAll();
            //foreach (var color in test4.Data) 
            //{ 
            //    Console.WriteLine(color.ColorName);
            //}
            //Console.WriteLine("*********************");

            //foreach (var color in test5.Data)
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            //ColorGetir(test5.Data);
            //ColorGetir(test4.Data);

            Console.ReadLine();

        }

        // Fonksiyon color listesi alacak
        // bu listenin elemanlarını console'a yazacak
        static public void ColorGetir(List<Color> colors) 
        {
            
            foreach (var color in colors) 
            {
                Console.WriteLine(color.ColorName);
            }
            
        }

        //
        //
        // SORULACAK HATA VAR
        //
        //

        //private static void Add(CarManager carManager)
        //{
        //    Car Car1 = new Car
        //    {
        //        Id = 2,
        //        BrandId = 1,
        //        CarName = "Test Car2",
        //        ColorId = 2,
        //        ModelYear = 2022,
        //        DailyPrice = 150,
        //        Description = "Car is Car"
        //    };

        //    carManager.Add(Car1);

        //    List<Car> Test = carManager.GetAll();

        //    foreach (Car car in Test)
        //    {
        //        Console.WriteLine(car.Id);
        //        Console.WriteLine(car.CarName);
        //    }
        //}

        //private static void Getby(CarManager carManager)
        //{
        //    List<Car> test1 = carManager.GetById(2);
        //}
    }
}