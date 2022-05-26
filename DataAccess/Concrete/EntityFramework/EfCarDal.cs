using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RentCarContex contex = new RentCarContex())
            {
                var addedEntity = contex.Add(entity);
                addedEntity.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentCarContex contex = new RentCarContex())
            {
                var deletedEntity = contex.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentCarContex contex = new RentCarContex())
            {
                return contex.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarContex contex = new RentCarContex())
            {
                return filter == null ? contex.Set<Car>().ToList() : contex.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentCarContex contex = new RentCarContex())
            {
                var updatedEntity = contex.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
