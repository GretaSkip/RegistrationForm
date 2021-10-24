using Microsoft.EntityFrameworkCore;
using RegistrationForm.Data;
using RegistrationForm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            // return await _context.Registrations.Include(r => r.Question).ThenInclude(q => q.Answers).FirstOrDefaultAsync(d => d.RegId == 1);

        }
    }
}
