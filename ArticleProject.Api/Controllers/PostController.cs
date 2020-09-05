using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleProject.Api.Models;
using ArticleProject.Data.Dto;
using ArticleProject.Data.Entity;
using ArticleProject.Service;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        //TODO : Dto kullanılarak sadeleştirilmiş ihtiyaca uygun modelleme
        //[Route("Index")]
        //public IActionResult Index()
        //{
        //    return Ok(_postService.PostDto());
        //}

        // TODO : Bütün verilerin aktığı modelleme
        //[Route("Index2")]
        //public IQueryable<Post> Index2()
        //{
        //    return _postService.GetAlls();
        //}

        [Route("Index")]
        public IActionResult Index()
        {
            var posts = _postService.GetAll();
            var postDto = _mapper.Map<List<PostDto>>(posts);
            return Ok(postDto);
        }


        [Route("Create")]
        [HttpPost]
        public IActionResult Create([FromBody] Post post)
        {
            ReturnModel returnModel = new ReturnModel();

            if (!ModelState.IsValid)
            {
                returnModel.IsSuccess = false;
                returnModel.Message = "Boş Alan Bırakmayınız";
                returnModel.Data = null;
                return Ok(returnModel);
            }

            try
            {
                var createdPost = _postService.Add(post);

                returnModel.IsSuccess = true;
                returnModel.Message = "Kayıt Başarılı";
                returnModel.Data = createdPost;
            }
            catch (Exception ex)
            {
                returnModel.IsSuccess = false;
                returnModel.Message = "Hata Oluştu" + ex.Message;
                returnModel.Data = null;
            }

            return Ok(returnModel);
        }

        [Route("SelectedPost")]
        [HttpGet]
        public IActionResult GetById(int id)
        {
            ReturnModel returnModel = new ReturnModel();

            if (id > 0)
            {
                try
                {
                    var post = _postService.GetById(id);

                    returnModel.IsSuccess = true;
                    returnModel.Message = "Kayıt Getirildi";
                    returnModel.Data = post;
                }
                catch (Exception ex)
                {
                    returnModel.IsSuccess = false;
                    returnModel.Message = "Hata Oluştu. " + ex.Message;
                    returnModel.Data = null;
                }
            }
            else
            {
                returnModel.IsSuccess = false;
                returnModel.Message = "Kayıt Bulunamadı";
                returnModel.Data = null;
            }

            return Ok(returnModel);
        }

        [Route("Edit")]
        [HttpPost]
        public IActionResult Edit([FromBody] Post post)
        {
            ReturnModel returnModel = new ReturnModel();

            if (post.ID > 0)
            {
                if (!ModelState.IsValid)
                {
                    returnModel.IsSuccess = true;
                    returnModel.Message = "Boş Alan Bırakmayınız";
                    return Ok(returnModel);
                }

                try
                {
                    var editPost = _postService.Update(post);

                    returnModel.IsSuccess = true;
                    returnModel.Message = "Kayıt Güncellendi";
                    returnModel.Data = editPost;

                }
                catch (Exception ex)
                {
                    returnModel.IsSuccess = false;
                    returnModel.Message = "Hata Oluştu. " + ex.Message;
                    returnModel.Data = null;
                }

            }
            else
            {
                returnModel.IsSuccess = false;
                returnModel.Message = "Böyle bir post bulunamadı";
                returnModel.Data = null;
            }

            return Ok(returnModel);
        }

        [Route("Delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            ReturnModel returnModel = new ReturnModel();

            if (id > 0)
            {
                try
                {
                    var deletedPost = _postService.Delete(id);

                    returnModel.IsSuccess = true;
                    returnModel.Message = "Kayıt Silindi";
                    returnModel.Data = deletedPost;
                }
                catch (Exception ex)
                {
                    returnModel.IsSuccess = false;
                    returnModel.Message = "Hata Oluştu. " + ex.Message;
                    returnModel.Data = null;
                }
            }
            else
            {
                returnModel.IsSuccess = false;
                returnModel.Message = "Böyle bir post bulunamadı";
                returnModel.Data = null;
            }

            return Ok(returnModel);
        }
    }
}