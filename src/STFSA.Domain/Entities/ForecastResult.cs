using STFSA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Domain.Entities
{
    public class ForecastResult : AuditEntity<int>
    {
        public int DatasetId { get; set; }
        public DateTime ForecastDate { get; set; }
        public decimal ForecastValue { get; set; }
        public string ModelUsed { get; set; }
        public DateTime GeneratedAt { get; set; }
        public SalesDataset Dataset { get; set; }
    }
}
