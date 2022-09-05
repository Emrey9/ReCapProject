using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        //burayı düzelt
        public IResult Add(Customer customer)
        {
            UserManager userManager = new UserManager(new EfUserDal());
            if (userManager.GetById(customer.CustomerId) != null)
            {
                _customerDal.Add(customer);

            }
            else
            {
                userManager.Add(new User { UserId = customer.CustomerId, Email = "", FirtName = "", LastName = "", Password = "" });
                _customerDal.Add(customer);
            }
            return new SuccessResult();

        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.CustomerId == customerId));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}
