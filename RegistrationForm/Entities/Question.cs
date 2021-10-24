using System.Collections.Generic;

namespace RegistrationForm.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AnswerId { get; set; }
        public List<Answer> Answers { get; set; }

        


    }
}
