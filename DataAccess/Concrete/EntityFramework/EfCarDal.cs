using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntitiyRepositoryBase<Car, RentCarContex>, ICarDal
    {
        public List<CarDetailDto> GetAllCarsDetail()
        {
            using (RentCarContex contex = new RentCarContex())
            {
                var result = from c in contex.Cars
                             join br in contex.Brands on c.BrandId equals br.Id
                             join cl in contex.Colors on c.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Brand = br.Name,
                                 Color = cl.Name,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear,
                                 Description = c.Description
                             };
                return result.ToList();
            }
        }
    }
}
