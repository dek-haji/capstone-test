﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testDemo.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public int QuestionTypeId { get; set; }
        [Required]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        [Required]
        [Display(Name = "Product Category")]
       
       
        public QuestionType QuestionType { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        

    }
}
