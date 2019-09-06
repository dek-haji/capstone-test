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
        public int ApplicationUserId { get; set; }
        public string Answer { get; set; }
        public Question question { get; set; }
    }
}
