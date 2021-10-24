using System.Collections.Generic;

namespace RegistrationForm.Entities
{
    public class Registration
    {
        public int Id { get; set; }
        public List<Question> Questions { get; set; }

    }
}
