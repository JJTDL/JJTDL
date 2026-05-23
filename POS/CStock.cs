using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class CStock
    {
        public int StockId { get; set; }

        // Text fields (strings)
        public string Supplier { get; set; } = string.Empty;
        public string Invoice_no { get; set; } = string.Empty;
        public string Item_description { get; set; } = string.Empty;

        // Numeric fields
        public int quantity_received { get; set; }

        // Financial fields (decimal is best for money/currency)
        public decimal cost_exc_vat { get; set; }
        public decimal cost_inc_vat { get; set; }

        // Nullable decimals (because these can be blank/null in your database)
        public decimal? margin { get; set; }
        public decimal? mark_up { get; set; }

        public decimal selling_exc_vat { get; set; }
        public decimal selling_inc_vat { get; set; }
    }
}
