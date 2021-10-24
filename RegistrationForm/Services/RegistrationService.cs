using RegistrationForm.Entities;
using RegistrationForm.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationForm.Services
{
    public class RegistrationService
    {
        private RegistrationRepository _registrationRepository;

        public RegistrationService(RegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public async Task<List<Question>> GetInfoAsync()
        {
            return await _registrationRepository.GetAsync();
        }
    }
}
