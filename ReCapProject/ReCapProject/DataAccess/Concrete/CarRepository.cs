using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CarRepository : ICarRepository
    {
        private List<Car> _cars = new List<Car>();

        public bool Add(Car car)
        {
            try
            {
                _cars.Add(car);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
                
        }

        public bool Delete(Car car)
        {
            try
            {
                _cars.Remove(car);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car? GetById(int id)
        {
            return _cars.Find(x => x.Id == id);
        }

        public bool Update(Car car)
        {
            Car? temp = _cars.Find(x => x.Id == car.Id);
            bool deleteResult = Delete(temp);



            if (deleteResult == true)
            {
                bool addResult = Add(temp);
                //if (addResult == true)
                //{
                //    return true;
                //}
                //return false;
                return addResult;
            }
            return false;

        }
    }
}
