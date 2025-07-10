using STFSA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Domain.Entities
{
    public class AnomalyDetection : AuditEntity<int>
    {
        public int DatasetId { get; set; }
        public DateTime AnomalyDate { get; set; }
        public decimal DetectedValue { get; set; }
        public decimal ExpectedValue { get; set; }
        public string Severity { get; set; }
        public SalesDataset Dataset { get; set; }
    }
}
