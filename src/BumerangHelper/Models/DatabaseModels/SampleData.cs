using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using BumerangHelper.Models.DatabaseModels;

namespace MobileStore.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<Context>();

            if (!context.Products.Any())
            {

                context.Products.AddRange(
                    new Product
                    {
                        Name = "iPhone 6S",
                        Country = "China",
                        LastPrice = 2000,
                        
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy Edge",
                        Country = "Russia",
                        LastPrice = 550
                    },
                    new Product
                    {
                        Name = "Lumia 950",
                        Country = "Germany",
                        LastPrice = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}