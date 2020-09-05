using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service
{
    public interface IimageService
    {
        void Add(Image ımage);
        void Update(Image ımage);
        void Delete(Image ımage);
        IEnumerable<Image> GetByPostId(int id);
    }
}
