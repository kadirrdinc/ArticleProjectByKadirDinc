using ArticleProject.Core.Repository;
using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _repository;
        public CommentService(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public void Add(Comment comment)
        {
            _repository.Add(comment);
        }

        public void Delete(Comment comment)
        {
            _repository.Delete(comment);
        }

        public IEnumerable<Comment> GetAll()
        {
            return _repository.GetAll();
        }

        public Comment GetByPostId(int id)
        {
            return _repository.Get(x => x.PostID == id);
        }

        public void Update(Comment comment)
        {
            _repository.Update(comment);
        }
    }
}
