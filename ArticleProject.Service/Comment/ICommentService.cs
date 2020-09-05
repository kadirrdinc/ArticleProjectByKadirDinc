using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service
{
    public interface ICommentService
    {
        void Add(Comment comment);
        void Update(Comment comment);
        void Delete(Comment comment);
        Comment GetByPostId(int id);
        IEnumerable<Comment> GetAll();
    }
}
