using Microsoft.AspNetCore.Mvc;

namespace STFSA.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/alerts")]
    public class AlertController : ControllerBase
    {
        public AlertController() { }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(new { Message = "Alerts fetched successfully" });
        }

        [HttpPut("{id}/read")]
        public async Task<IActionResult> MarkAsRead(string id)
        {
            return Ok(new { Message = "Alert marked as read", AlertId = id });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            return Ok(new { Message = "Alert deleted successfully", AlertId = id });
        }
    }
}


//| Method | Endpoint | Description |
//| ------ | ------------------- | ------------------ |
//| GET | `/ alerts`           | Get user alerts    |
//| PUT    | `/alerts/{id}/ read` | Mark alert as read |
//| DELETE | `/ alerts /{ id}`      | Delete an alert    |


