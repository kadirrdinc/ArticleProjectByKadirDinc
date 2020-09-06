using ArticleProject.Core.Repository;
using ArticleProject.Data.Dtos;
using ArticleProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArticleProject.Service
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _repository;
        public PostService(IRepository<Post> repository)
        {
            _repository = repository;
        }

        public Post Add(Post post)
        {
            var newPost = new Post
            {
                Title = post.Title,
                Description = post.Description,
                CategoryID = post.CategoryID
            };

            try
            {
                _repository.Add(newPost);
                return newPost;
            }
            catch (Exception ex)
            {
                var m = ex.Message;
                return null;
            }
        }

        public Post Delete(int id)
        {
            var deletedPost = GetById(id);

            try
            {
                _repository.Delete(deletedPost);
                return deletedPost;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public IEnumerable<Post> GetAll()
        {
            var all = _repository.Include(x => x.Category,x=>x.Comments, x => x.Images).AsEnumerable();
            return all;
        }

        public IQueryable<Post> GetAlls()
        {
            var all = _repository.Include(x => x.Comments, x => x.Images).AsQueryable();
            return all;
        }

        public Post GetById(int id)
        {
            var post = _repository.Include(x => x.Comments, x => x.Images).AsQueryable().Where(x => x.ID == id).FirstOrDefault();
            return post;
        }

        public List<PostDto> PostDto()
        {
            var posts = _repository.Include(x => x.Comments, x => x.Images, x => x.Category).ToList();

            if (posts.Count() > 0)
            {
                var postList = new List<PostDto>();

                foreach (var post in posts)
                {
                    var images = new List<ImageDto>();

                    foreach (var image in post.Images)
                    {
                        var imageDto = new ImageDto
                        {
                            ID = image.ID,
                            ImageUrl = image.ImageUrl,
                            Description = image.Description
                        };
                        images.Add(imageDto);
                    }

                    var comments = new List<CommentDto>();
                    foreach (var comment in post.Comments)
                    {
                        var commentDto = new CommentDto
                        {
                            ID = comment.ID,
                            FullName = comment.FullName,
                            Email = comment.Email,
                            CreatedDate = comment.CreatedDate
                        };
                        comments.Add(commentDto);
                    }

                    var result = new PostDto
                    {
                        ID = post.ID,
                        Title = post.Title,
                        Description = post.Description,
                        CategoryName = post.Category.Title,
                        CreatedDate = post.CreatedDate,
                        Comments = comments,
                        Images = images
                    };

                    postList.Add(result);
                }
                return postList;
            }
            else
            {
                return null;
            }
        }

        public Post Update(Post post)
        {
            var selectedPost = GetById(post.ID);

            selectedPost.Title = post.Title;
            selectedPost.Description = post.Description;
            selectedPost.CategoryID = post.CategoryID;

            try
            {
                _repository.Update(selectedPost);
                return selectedPost;
            }
            catch (Exception ex)
            {
                var m = ex.Message;
                return null;
            }
        }
    }
}
