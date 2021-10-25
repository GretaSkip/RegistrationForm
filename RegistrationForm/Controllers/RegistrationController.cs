using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Dto;
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

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var question = await _registrationService.GetByIdAsync(id);
            return Ok(question);
        }

        [HttpPut]
        public async Task<IActionResult> Update(QuestionEditDto question)
        {
            await _registrationService.UpdateAsync(question);
            return NoContent();
        }
    }
}
