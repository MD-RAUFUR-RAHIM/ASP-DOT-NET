using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ExpenseCatServices
    {
        public static List<ExpenseCatDTO> Get()
        {
            var data = DataAccess.ExpenseCatData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ExpenseCat, ExpenseCatDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<ExpenseCatDTO>>(data);
            return cnvrted;
        }
        public static ExpenseCatDTO Get(int id)
        {
            var data = DataAccess.ExpenseCatData().Get(id);
            var mapper = MapperServices<ExpenseCat, ExpenseCatDTO>.GetMapper();
            return mapper.Map<ExpenseCatDTO>(data);
        }

        public static bool Add(ExpenseCatDTO post)
        {
            var mapper = MapperServices<ExpenseCatDTO, ExpenseCat>.GetMapper();
            var mapped = mapper.Map<ExpenseCat>(post);
            return DataAccess.ExpenseCatData().Create(mapped);

        }
        public static bool Update(ExpenseCatDTO post)
        {
            var mapper = MapperServices<ExpenseCatDTO, ExpenseCat>.GetMapper();
            var mapped = mapper.Map<ExpenseCat>(post);
            return DataAccess.ExpenseCatData().Update(mapped);

        }
        public static bool Delete(int id)
        {
            return DataAccess.ExpenseCatData().Delete(id);
        }
    }
}
