using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        Color GetById(int colorId);
        List<Color> GetAll();
        void Delete(Color color);
    }
}
