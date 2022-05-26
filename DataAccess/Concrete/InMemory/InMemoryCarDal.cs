using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car {Id=1,BrandId=1,ColorId=2,ModelYear=2015,DailyPrice=300,Description="Voswogen Golf"},
                new Car {Id=2,BrandId=1,ColorId=1,ModelYear=2016,DailyPrice=350,Description="Voswogen Polo"},
                new Car {Id=3,BrandId=2,ColorId=5,ModelYear=2010,DailyPrice=200,Description="Fiat Linea"},
                new Car {Id=4,BrandId=2,ColorId=3,ModelYear=2016,DailyPrice=350,Description="Fiat Doblo"},
                new Car {Id=5,BrandId=2,ColorId=1,ModelYear=2020,DailyPrice=400,Description="Fiat Linea"}
            };
        }

        public bool Add(Car car)
        {
            _cars.Add(car);
            return true;
        }

        public bool Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
            return true;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public bool Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            return true;
        }

        void IEntityRepository<Car>.Add(Car entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Car>.Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<Car>.Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
