using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _60321_2_Severina.Models
{
    //public class CartModelBinder : IModelBinder
    //{
    //    //public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    //    //{


    //    //    var valueProvider = bindingContext.ValueProvider;
    //    //    Cart model = new Cart();
    //    //    model.items = (List<CartItem>)controllerContext.;
    //    //    foreach (var a in model.items)
    //    //    {
    //    //        a.Car.CarId = (int)valueProvider.GetValue("CarId").ConvertTo(typeof(int));
    //    //        a.Car.Price = (int)valueProvider.GetValue("Price").ConvertTo(typeof(int));
    //    //        a.Car.CarName = (string)valueProvider.GetValue("CarName").ConvertTo(typeof(string));
    //    //        a.Quantity = (int)valueProvider.GetValue("Quantity").ConvertTo(typeof(int));
    //    //    }

    //    //    return model;
    //    //}

    //    //private string GetValue(ModelBindingContext context, string name)
    //    //{
    //    //    name = (context.ModelName == "" ? "" : context.ModelName + ".") + name;

    //    //    ValueProviderResult result = context.ValueProvider.GetValue(name);
    //    //    if (result == null || result.AttemptedValue == "")
    //    //    {
    //    //        return "<Не указано>";
    //    //    }
    //    //    else
    //    //    {
    //    //        return (string)result.AttemptedValue;
    //    //    }
    //    //}
    //}
}