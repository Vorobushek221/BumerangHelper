
namespace BumerangHelper.Models.DatabaseModels
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public decimal LastPrice { get; set; }

        public string Unit { get; set; }

        public string About { get; set; }
    }
}