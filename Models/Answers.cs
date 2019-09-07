using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testDemo.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string UserId { get; set; }
        public string Answer { get; set; }
        public ApplicationUser User { get; set; }

    }
}
