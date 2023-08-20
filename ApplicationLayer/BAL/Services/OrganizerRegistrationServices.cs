using AutoMapper;
using BAL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class OrganizerRegistrationServices
    {
        public static List<OrganizerRegistrationDTO> Get()
        {
            var data = DataAccessFactory.OrganizerRegistrationData().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<OrganizerRegistration, OrganizerRegistrationDTO>();
            });
            var mapper = new Mapper(config);
            var cnvrted = mapper.Map<List<OrganizerRegistrationDTO>>(data);
            return cnvrted;
        }
        public static OrganizerRegistrationDTO Get(int id)
        {
            var data = DataAccessFactory.OrganizerRegistrationData().Get(id);
            var mapper = MapperService<OrganizerRegistration, OrganizerRegistrationDTO>.GetMapper();
            return mapper.Map<OrganizerRegistrationDTO>(data);
        }

        public static bool Add(OrganizerRegistrationDTO post)
        {
            var mapper = MapperService<OrganizerRegistrationDTO, OrganizerRegistration>.GetMapper();
            var mapped = mapper.Map<OrganizerRegistration>(post);
            return DataAccessFactory.OrganizerRegistrationData().Create(mapped);

        }
        public static bool Update(OrganizerRegistrationDTO post)
        {
            var mapper = MapperService<OrganizerRegistrationDTO, OrganizerRegistration>.GetMapper();
            var mapped = mapper.Map<OrganizerRegistration>(post);
            return DataAccessFactory.OrganizerRegistrationData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory.OrganizerRegistrationData().Delete(id);

        }
    }
}
