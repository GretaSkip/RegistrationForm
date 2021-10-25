using RegistrationForm.Dto;
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

        public async Task<Question> GetByIdAsync(int id)
        {
            return await _registrationRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(QuestionEditDto question)
        {
            var existingQuestion = await _registrationRepository.GetByIdAsync(question.Id);
            if (existingQuestion != null)
            {
                existingQuestion.AnswerId = question.AnswerId;
            }
            await _registrationRepository.UpdateAsync(existingQuestion);
        }
    }
}
