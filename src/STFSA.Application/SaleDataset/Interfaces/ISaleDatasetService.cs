using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.SaleDataset.Interfaces
{
    public interface ISaleDatasetService
    {
        Task Get();
        Task UploadDataset(IFormFile file);
        Task GetDatasetDetails(int id);
        Task DeleteDataset(int id);
    }
}
