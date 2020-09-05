using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetById(int id);
        IEnumerable<Category> GetAll();
    }
}
