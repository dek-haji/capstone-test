﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testDemo.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string UserId { get; set; }
        public string Answers { get; set; }
        public ApplicationUser User { get; set; }

    }
}
