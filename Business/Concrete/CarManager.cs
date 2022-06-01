using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
            if(car.Description.Length >=2 && car.DailyPrice > 0)
            {
                _productDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _productDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<CarDetailDto> GetAllCarsDetail()
        {
            return _productDal.GetAllCarsDetail();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _productDal.GetAll(p=> p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _productDal.GetAll(p => p.ColorId == colorId);
        }

        public void Update(Car car)
        {
            _productDal.Update(car);
        }
    }
}
