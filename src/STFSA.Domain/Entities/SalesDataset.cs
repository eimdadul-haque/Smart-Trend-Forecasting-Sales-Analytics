using STFSA.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Domain.Entities
{
    public class SalesDataset : AuditEntity<int>
    {
        public Guid UserId { get; set; }
        public string DatasetName { get; set; }
        public DateTime UploadedAt { get; set; }
        public string FilePath { get; set; }
        public List<SalesRecord> SalesRecords { get; set; }
        public List<ForecastResult> ForecastResults { get; set; }
        public List<AnomalyDetection> AnomalyDetections { get; set; }
        public List<Recommendation> Recommendations { get; set; }
    }
}
