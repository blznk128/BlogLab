using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MinLength(5, ErrorMessage = "Must be at least 5-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be at least 5-20 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        [MinLength(2, ErrorMessage = "Must be at least 2-3000 characters")]
        [MaxLength(3000, ErrorMessage = "Must be at least 2-3000 characters")]
        public string Content { get; set; }
        public int? PhotoId { get; set; }
    }
}
