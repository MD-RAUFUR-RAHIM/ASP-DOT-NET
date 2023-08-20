using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CourseService
    {
        public static List<CourseDTO> Get()
        {
            var data = DataFactory.CourseData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Course, CourseDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<CourseDTO>>(data);
            return cnvrted;
        }

        public static bool Create(CourseDTO obj)
        {
            
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CourseDTO, Course>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<Course>(obj);
            var data = DataFactory.CourseData().Create(cnvrted);
            return data;
        }
    }
}
