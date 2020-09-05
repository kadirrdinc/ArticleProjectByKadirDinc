using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Data.Dtos
{
    public class CommentDto
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string CreatedDate { get; set; }
    }
}
