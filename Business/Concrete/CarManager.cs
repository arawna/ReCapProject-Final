using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _productDal;

        public CarManager(ICarDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Car car)
        {
            _productDal.Add(car);
        }

        public void Delete(Car car)
        {
            _productDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Car car)
        {
            _productDal.Update(car);
        }
    }
}
