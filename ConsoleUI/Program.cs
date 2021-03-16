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
            CarTest();
            //CarAdd();
            //CarManagerTest();

        }

        //private static void CarManagerTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.BrandId);

        //    }
        //}

        //private static void CarAdd()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    carManager.Add(new Car { BrandId = 3, CarName = "şdfkşdfşd", DailyPrice = 5000 });
        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.CarId);

        //    }
        //}

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("Brand Name :"+ car.BrandName);
                Console.WriteLine("Color Name :" + car.ColorName);
                Console.WriteLine("Car Name :" + car.CarName);
                Console.WriteLine("DailyPrice :" + car.DailyPrice);
                
            }

            }
            
        }
    }
}
