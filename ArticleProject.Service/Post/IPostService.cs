using ArticleProject.Data.Dtos;
using ArticleProject.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace ArticleProject.Service
{
    public interface IPostService
    {
        Post Add(Post post);
        Post Update(Post post);
        Post Delete(int id);
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IQueryable<Post> GetAlls();
        List<PostDto> PostDto();
    }
}
