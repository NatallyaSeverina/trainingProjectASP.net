using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR.Entities
{
    class CarContext:DbContext
    {
        public CarContext(string name):base(name)
        {
            Database.SetInitializer(new CarContextInitializer());
        }
        public DbSet<Car> Cars { get; set; }
    }
}
