using AutoMapper;
using BAL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class ConferenceServices
    {
        public static List<ConferenceDTO> Get()
        {
            var data = DataAccessFactory.AddConferenceData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Conference, ConferenceDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<ConferenceDTO>>(data);
            return cnvrted;
        }
        public static List<ConferenceDTO> Get(DateTime date)
        {
            var data = (from n in DataAccessFactory.AddConferenceData().Get()
                        where n.Date.Date == date
                        select n).ToList();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Conference, ConferenceDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<ConferenceDTO>>(data);
            return cnvrted;

        }

        public static bool Add(ConferenceDTO post)
        {
            var mapper = MapperService<ConferenceDTO, Conference>.GetMapper();
            var mapped = mapper.Map<Conference>(post);
            return DataAccessFactory.AddConferenceData().Create(mapped);

        }
        public static bool Update(ConferenceDTO post)
        {
            var mapper = MapperService<ConferenceDTO, Conference>.GetMapper();
            var mapped = mapper.Map<Conference>(post);
            return DataAccessFactory.AddConferenceData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.AddConferenceData().Delete(id);

        }


    }
}
