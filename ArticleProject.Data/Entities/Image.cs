using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArticleProject.Data.Entity
{
    public class Image:BaseEntity
    {
        public string Description { get; set; }

        [Required(ErrorMessage ="Zorunlu Alan")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}
