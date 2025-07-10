using STFSA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Domain.Entities
{
    public class SalesRecord : AuditEntity<int>
    {
        public int DatasetId { get; set; }
        public DateTime Date { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Region { get; set; }
        public int Quantity { get; set; }
        public decimal Revenue { get; set; }
        public SalesDataset Dataset { get; set; }
    }
}
