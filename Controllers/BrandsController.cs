using System;
using Microsoft.AspNet.Mvc;
using Frank.Web.Models;

namespace Frank.Web
{
    public class BrandsController : Controller
    {
        public Brand[] Get()
        {
            return new[] { new Brand()
            {
                BrandId = Guid.NewGuid(),
                Name = "Gucci"
            }};
        }
    }
}