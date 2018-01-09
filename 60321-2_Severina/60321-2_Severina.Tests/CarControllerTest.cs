using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _60321_2_Severina.Controllers;
using _60321_2_Severina.Models;
using CAR.Entities;
using CAR.Interfaces;
using Moq;
using System.Web.Mvc;
using System.Web;
using System.Web.Routing;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace _60321_2_Severina.Tests
{
    [TestClass]
    public class CarControllerTest
    {
        [TestMethod]
        public void PagingTest()
        {
            // Arrange
            // Макет репозитория
            var mock = new Mock<IRepository<Car>>();
            mock.Setup(r => r.GetAll()).Returns(new List<Car> {
            new Car{ CarId=1},new Car{ CarId=2},new Car{ CarId=3},new Car{ CarId=4},new Car{ CarId=5}});
            // Создание объекта контроллера
            var controller = new CarController(mock.Object);
            var request = new Mock<HttpRequestBase>();
            var httpContext = new Mock<HttpContextBase>();
            httpContext.Setup(h => h.Request).Returns(request.Object);
            // Создание контекста контроллера
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = httpContext.Object;
            //NameValueCollection valueCollection = new NameValueCollection();
            //valueCollection.Add("X-Requested-With", "XMLHttpRequest");
            //valueCollection.Add("Accept", "application/json");
            //// другой вариант: valueCollection.Add("Accept", "HTML");
            //request.Setup(r => r.Headers).Returns(valueCollection);
            // Act
            // Вызов метода List
            var view = controller.List(null, 2) as ViewResult;
            // Assert
            Assert.IsNotNull(view, "Представление не получено");
            Assert.IsNotNull(view.Model, "Модель не получена");
            PageListViewModel<Car> model = view.Model as PageListViewModel<Car>;
            Assert.AreEqual(2, model.Count);
            Assert.AreEqual(4, model[0].CarId);
            Assert.AreEqual(5, model[1].CarId);
        }
        [TestMethod]
        public void CategoryTest()
        {
            // Arrange
            // Макет репозитория
            var mock = new Mock<IRepository<Car>>();
            mock.Setup(r => r.GetAll())
            .Returns(new List<Car>
            {   new Car { CarId = 1,CarYear=2003 },
                new Car { CarId = 2,CarYear=2004 },
                new Car { CarId = 3,CarYear=2003 },
                new Car { CarId = 4,CarYear=2004 },
                new Car { CarId = 5,CarYear=2004 }
            });
            // Создание объекта контроллера
            var controller = new CarController(mock.Object);
            // Макеты для получения HttpContext HttpRequest
            var request = new Mock<HttpRequestBase>(); var httpContext = new Mock<HttpContextBase>();
            httpContext.Setup(h => h.Request).Returns(request.Object);
            // Создание контекста контроллера
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = httpContext.Object;
            // Act
            // Вызов метода List
            var view = controller.List("2003", 1) as ViewResult;
            // Assert
            Assert.IsNotNull(view, "Представление не получено");
            Assert.IsNotNull(view.Model, "Модель не получена");
            PageListViewModel<Car> model = view.Model as
            PageListViewModel<Car>;
            Assert.AreEqual(2, model.Count);
            Assert.AreEqual(1, model[0].CarId);
            Assert.AreEqual(3, model[1].CarId);
        }
    }
}
