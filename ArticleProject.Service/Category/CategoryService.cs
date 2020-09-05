using ArticleProject.Core.Repository;
using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public void Add(Category category)
        {
            _repository.Add(category);
        }

        public void Delete(Category category)
        {
            _repository.Delete(category);
        }

        public IEnumerable<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetById(int id)
        {
            return _repository.Get(x => x.ID == id);
        }

        public void Update(Category category)
        {
            _repository.Update(category);
        }
    }
}
