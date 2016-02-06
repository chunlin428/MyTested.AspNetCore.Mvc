﻿namespace MyTested.Mvc.Tests.Setups.Routes
{
    using Microsoft.AspNet.Mvc.ApplicationModels;
    using System;

    public class CustomControllerConventionAttribute : Attribute, IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            controller.ControllerName = "ChangedController";
        }
    }
}