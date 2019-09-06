using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testDemo.Models
{
    public class QuestionType
    {
        [Key]
        public int QuestionTypeId { get; set; }
        public string Name { get; set; }

    }
}
