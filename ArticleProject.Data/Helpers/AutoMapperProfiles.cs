using ArticleProject.Data.Dtos;
using ArticleProject.Data.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleProject.Data.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Comment, CommentDto>();
            CreateMap<Image, ImageDto>();
            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.CategoryName, opt =>
                {
                    opt.MapFrom(src => src.Category.Title);
                })
                .ForMember(dest => dest.Comments, opt =>
                {
                    opt.MapFrom(src => src.Comments);
                })
                .ForMember(dest => dest.Images, opt =>
                {
                    opt.MapFrom(src => src.Images);
                });
        }
    }
}
