using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<T>
    {
        IResult Add(T entity);
        IResult Update(T entity);
        IDataResult<T> GetById(int entityId);
        IDataResult<List<T>> GetAll();
        IResult Delete(T entity);
    }
}
