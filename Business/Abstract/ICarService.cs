using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void AddCar(Car car);
        void UpdateCar(Car car);
        Car GetById(int carId);
        List<Car> GetAll();
        void Delete(Car car);
    }
}
