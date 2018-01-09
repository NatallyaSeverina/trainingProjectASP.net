using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR.Entities
{
    class CarContextInitializer:
        //CreateDatabaseIfNotExists<CarContext>
        DropCreateDatabaseIfModelChanges<CarContext>
    {
        protected override void Seed(CarContext context)
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
            context.Cars.AddRange(cars);
            context.SaveChanges();
        }
    }
}
