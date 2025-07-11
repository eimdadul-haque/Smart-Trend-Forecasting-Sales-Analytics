using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;

namespace STFSA.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/dataset")]
    public class SaleDatasetController : ControllerBase
    {
        public SaleDatasetController()
        {
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadDataset(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            return Ok(new { Message = "File uploaded successfully." });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDatasetDetails(int id)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDataset(int id)
        {
            return Ok(new { Message = "Dataset deleted successfully." });
        }
    }
}        

