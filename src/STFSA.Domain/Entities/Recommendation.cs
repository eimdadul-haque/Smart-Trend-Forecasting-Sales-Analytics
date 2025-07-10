using STFSA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Domain.Entities
{
    public class Recommendation : AuditEntity<int>
    {
        public int DatasetId { get; set; }
        public string SuggestedAction { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedAt { get; set; }
        public SalesDataset Dataset { get; set; }
    }
}
