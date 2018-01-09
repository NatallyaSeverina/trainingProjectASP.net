using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAR.Entities;
using CAR.Interfaces;

namespace CAR.Repositories
{
    public class FakeRepository : IRepository<Car>
    {
        public void Create(Car t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> Find(Func<Car, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            List<Car> cars = new List<Car>
            {
                new Car{CarId=1,CarName="BMW E60",Description="Мотор 2,5 бензиновый", CarYear=2003, Price=10000},
                new Car{CarId=2,CarName="BMW X5",Description="Мотор 3,0 бензиновый", CarYear=2007, Price=15000},
                new Car{CarId=3,CarName="BMW X5",Description="Мотор 4,8 бензиновый", CarYear=2007, Price=13000},
                new Car{CarId=4,CarName="BMW F01",Description="Мотор 2,0 дизельный", CarYear=2011, Price=19000},
                new Car{CarId=5,CarName="BMW F10",Description="Мотор 3,0 дизельный", CarYear=2011, Price=22000},
                new Car{CarId=6,CarName="BMW F10",Description="Мотор 2,0 дизельный", CarYear=2011, Price=22000},
                new Car{CarId=7,CarName="BMW E60",Description="Мотор 3,0 дизельный", CarYear=2007, Price=14000},
                new Car{CarId=8,CarName="BMW F01",Description="Мотор 2,0 дизельный", CarYear=2009, Price=22000}
            };
            return cars;
        }

        public Task<Car> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car t)
        {
            throw new NotImplementedException();
        }
    }
}
