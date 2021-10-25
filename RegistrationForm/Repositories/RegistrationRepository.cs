using Microsoft.EntityFrameworkCore;
using RegistrationForm.Data;
using RegistrationForm.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RegistrationForm.Repositories
{
    public class RegistrationRepository
    {
        private readonly DataContext _context;

        public RegistrationRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetAsync()
        {
            return await _context.Questions.Include(p => p.Answers).ToListAsync();
        }

        public async Task<Question> GetByIdAsync(int id)
        {
            return await _context.Questions.Include(pa => pa.Answers).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(Question question)
        {
            _context.Questions.Update(question);
            await _context.SaveChangesAsync();
        }
    }
}
