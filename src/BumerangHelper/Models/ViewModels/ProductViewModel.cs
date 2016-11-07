using BumerangHelper.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BumerangHelper.Models.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(Product entity)
        {
            ProductID = entity.ProductID;
            Name = entity.Name;
            Country = entity.Country;
            LastPrice = entity.LastPrice;
            Unit = entity.Unit;
            About = entity.About;
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public decimal LastPrice { get; set; }

        public string Unit { get; set; }

        public string About { get; set; }

        public Product ToEntity()
        {
            return new Product
            {
                ProductID = this.ProductID,
                Name = this.Name,
                Country = this.Country,
                LastPrice = this.LastPrice,
                Unit = this.Unit,
                About = this.About
            };
        }

        public static ProductViewModel ToViewModel(Product entity)
        {
            return new ProductViewModel(entity);
        }
    }
}
