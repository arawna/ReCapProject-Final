using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarService carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAllCarsDetail())
            {
                Console.WriteLine(car.Id +"---"+car.Brand+"---"+car.Color+"---"+car.DailyPrice+"---"+car.Description);
            }
        }
    }
}
