using CAR.Entities;
using CAR.Interfaces;
using CAR.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _60321_2_Severina.Services
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<Car>>().To<EFCarRepository>().WithConstructorArgument("name","CarConnection");
        }
    }
}