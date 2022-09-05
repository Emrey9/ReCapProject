﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService :  IEntityService<Car>
    {
        IDataResult<Car> GetByColorId(int colorId);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
    }
}
