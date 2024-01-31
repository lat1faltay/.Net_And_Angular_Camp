using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length < 2)
            {
                // Magic String
                return new ErrorResult(Message.CarNameInvalid);
            }

            _carDal.Add(car);
            return new Result(true, Message.CarAdded);

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Message.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Message.CarUpdated);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Message.CarListed);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(),Message.CarListed );
        }

        public IDataResult<List<Car>> GetById(int id)
        {
            var IsThereCar = _carDal.Get(c => c.Id == id);
            if (IsThereCar == null) 
            {
                return new ErrorDataResult<List<Car>>(Message.CarIdInvalid);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id==id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int BrandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == BrandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int ColorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == ColorId));
        }

        // Crud operasyonları



    }
}
