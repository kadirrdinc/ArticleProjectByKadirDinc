using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArticleProject.Data.Entity
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Posts = new List<Post>();
        }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Description { get; set; }

        public IEnumerable<Post> Posts { get; set; }

    }
}
