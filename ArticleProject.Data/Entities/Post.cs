using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArticleProject.Data.Entity
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Comments = new List<Comment>();
            Images = new List<Image>();
        }

        [Required(ErrorMessage ="Zorunlu Alan")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public string Description { get; set; }
        
        //public int ImageID { get; set; }
        //public Image Image { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Image> Images { get; set; }

    }
}
