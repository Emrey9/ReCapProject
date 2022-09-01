using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId=1,ColorId=1,BrandId=1,ModelYear=2018,DailyPrice=150,Description="BMW Red"},
                new Car{CarId=2,ColorId=2,BrandId=1,ModelYear=2020,DailyPrice=300,Description="Audi Black"},
                new Car{CarId=3,ColorId=3,BrandId=1,ModelYear=2019,DailyPrice=120,Description="Hyundai White"},
                new Car{CarId=4,ColorId=1,BrandId=1,ModelYear=2016,DailyPrice=100,Description="Nissan RED"},
                new Car{CarId=5,ColorId=2,BrandId=1,ModelYear=2018,DailyPrice=140,Description="Toyota Red"},
            };
        }
        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public void UpdateCar(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
