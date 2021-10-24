using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Services;
using System.Threading.Tasks;

namespace RegistrationForm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly RegistrationService _registrationService;

        public RegistrationController(RegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [HttpGet]
        public async Task<ActionResult> GetInfo()
        {
            return Ok(await _registrationService.GetInfoAsync());
        }
    }
}
