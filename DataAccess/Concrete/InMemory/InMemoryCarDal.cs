using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() 
            {
                new Car{ CarId = 1 ,BrandId= 1, ColorId = 1, DailyPrice = 500,  ModelYear = 2010,Description = "aa"},
                new Car{ CarId = 2 ,BrandId= 1, ColorId = 2, DailyPrice = 480,  ModelYear = 2008,Description = "ab"},
                new Car{ CarId = 3 ,BrandId= 2, ColorId = 2, DailyPrice = 600,  ModelYear = 2018,Description = "ac"},
                new Car{ CarId = 4 ,BrandId= 3, ColorId = 3, DailyPrice = 400,  ModelYear = 2000,Description = "ad"},
                new Car{ CarId = 5 ,BrandId= 3, ColorId = 4, DailyPrice = 750,  ModelYear = 2020,Description = "af"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car DeleteCar = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(DeleteCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c=>c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car UpdateCar = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            UpdateCar.ColorId = car.ColorId;
            UpdateCar.BrandId = car.BrandId;
            UpdateCar.DailyPrice = car.DailyPrice;
            UpdateCar.ModelYear = car.ModelYear;
            UpdateCar.Description = car.Description;
            
        }
    }
}
