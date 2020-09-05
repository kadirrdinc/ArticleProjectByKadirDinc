using ArticleProject.Core.Repository;
using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service
{
    public class ImageService : IimageService
    {
        private readonly IRepository<Image> _repository;
        public ImageService(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public void Add(Image image)
        {
            _repository.Add(image);
        }

        public void Delete(Image image)
        {
            _repository.Delete(image);
        }

        public IEnumerable<Image> GetByPostId(int id)
        {
            return _repository.GetAll(x => x.PostID == id);
        }

        public void Update(Image image)
        {
            _repository.Update(image);
        }
    }
}
