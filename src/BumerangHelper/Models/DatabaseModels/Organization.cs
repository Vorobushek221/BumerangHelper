using System;

namespace BumerangHelper.Models.DatabaseModels
{
    public class Organization
    {
        public int OrganizationID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string AccountNumber { get; set; }

        public string BankInfo { get; set; }

        public string Pan { get; set; }

        public string AccordNumber { get; set; }

        public DateTime AccordDate { get; set; }

        public string About { get; set; }
    }
}