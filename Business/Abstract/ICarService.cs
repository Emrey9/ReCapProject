using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        Car GetById(int carId);
        Car GetByColorId(int colorId);
        List<Car> GetAll();
        void Delete(Car car);
        List<CarDetailsDto> GetCarDetails();
    }
}
