using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testDemo.Models.QuestionTypesViewModel
{
    public class QuestionTypesViewModel
    {
        [Key]
        public int QuestionTypeId { get; set; }

        public int QuestionId { get; set; }

        public List<QuestionType> ProductTypes { get; set; }
        
    }
}
