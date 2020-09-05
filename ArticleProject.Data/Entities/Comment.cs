using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArticleProject.Data.Entity
{
    public class Comment:BaseEntity
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public int PostID { get; set; }
        public Post Post { get; set; }

    }
}
