﻿
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBakend.Models.DataModels
{
    public class Chapter : BaseEntity
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();

        [Required]
        public string List = string.Empty;   
    }
}
