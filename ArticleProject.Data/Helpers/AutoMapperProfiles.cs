using ArticleProject.Data.Dto;
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
            CreateMap<Post, PostDto>()
                .ForMember(dest => dest.CategoryName, opt =>
                {
                    opt.MapFrom(src => src.Category.Title);
                });
        }
    }
}
