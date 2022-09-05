using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestCar();

            //TestColor();

            //TestBrand();

            TestRental();
        }

        private static void TestRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            //Console.WriteLine(rentalManager.Add(new Rental { CarId = 2, CustomerId = 2,RentalId=8, RentDate = DateTime.Now}).Success);
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.ReturnDate);
            }
        }

        private static void TestBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void TestColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void TestCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} -- {1} -- {2} -- {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}
