using System;
using System.Collections.Generic;

namespace SingleResponsibility
{
    internal class Invoice
    {
        public IEnumerable<LineItem> LineItems { get; set; }
        public string Vendor { get; set; }
        public string Vendee { get; set; }
        public float Total { get; set; }

        public Invoice(IEnumerable<LineItem> lineItems, string vendor, string vendee)
        {
            LineItems = lineItems;
            Vendor = vendor;
            Vendee = vendee;
            Total = this.CalculateTotal();
        }
        public float CalculateTotal()
        {
            float total = 0;
            foreach (var lineItem in LineItems)
            {
                total += lineItem.Price * lineItem.Count * (1 + lineItem.TaxRate);
            }
            return total;
        }
    }
}