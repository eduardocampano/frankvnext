using System;
using System.ComponentModel.DataAnnotations;

namespace Frank.Web.Models
{
    public class Brand
    {
    	public Guid BrandId { get; set; }
        public string Name { get; set; }
    }
}