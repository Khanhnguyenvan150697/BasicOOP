using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentM.A._010
{
    public class Invoice : IPayable
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public double PricePerItem { get; set; }

        public double GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
    }
}
