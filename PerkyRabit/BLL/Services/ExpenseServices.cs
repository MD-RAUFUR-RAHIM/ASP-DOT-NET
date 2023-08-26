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
    public class ExpenseServices
    {
        public static List<ExpenseDTO> Get()
        {
            var data = DataAccess.ExpenseData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Expense, ExpenseDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<ExpenseDTO>>(data);
            return cnvrted;
        }
        public static List<ExpenseDTO> Get(DateTime date)
        {
            var data = (from n in DataAccess.ExpenseData().Get()
                        where n.Date.Date == date
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Expense, ExpenseDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<ExpenseDTO>>(data);
            return cnvrted;

        }

        public static bool Add(ExpenseDTO post)
        {
            var mapper = MapperServices<ExpenseDTO, Expense>.GetMapper();
            var mapped = mapper.Map<Expense>(post);
            return DataAccess.ExpenseData().Create(mapped);

        }

        public static bool Update(ExpenseDTO post)
        {
            var mapper = MapperServices<ExpenseDTO, Expense>.GetMapper();
            var mapped = mapper.Map<Expense>(post);
            return DataAccess.ExpenseData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccess.ExpenseData().Delete(id);

        }
      
    }
}
