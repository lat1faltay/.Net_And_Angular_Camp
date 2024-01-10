using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarRepository
    {
        public Car? GetById(int id);
        public List<Car> GetAll();
        public bool Add(Car car);
        public bool Update(Car car);
        public bool Delete(Car car);

    }
}
