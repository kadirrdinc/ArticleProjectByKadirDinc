using ArticleProject.Data.Dtos;
using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Data.Dtos
{
    public class PostDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string CategoryName { get; set; }
        public List<CommentDto> Comments { get; set; }
        public List<ImageDto> Images { get; set; }
    }
}
