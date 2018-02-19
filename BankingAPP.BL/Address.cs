using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAPP.BL
{
    public class Address
    {
        public Address()
        {
                
        }
        public Address(int addressId)
        {
            this.addressId = addressId;
        }

        public int addressId { get; set; }
        public int AptNumber { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }



    }
}
