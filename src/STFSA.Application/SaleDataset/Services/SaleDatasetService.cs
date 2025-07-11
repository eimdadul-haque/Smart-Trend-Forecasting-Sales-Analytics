using Microsoft.AspNetCore.Http;
using STFSA.Application.SaleDataset.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STFSA.Application.SaleDataset.Services
{
    public class SaleDatasetService : ISaleDatasetService
    {
        public SaleDatasetService() { }

        public async Task Get()
        {
        }

        public async Task UploadDataset(IFormFile file)
        {

        }

        public async Task GetDatasetDetails(int id)
        {

        }

        public async Task DeleteDataset(int id)
        {

        }
    }
}
