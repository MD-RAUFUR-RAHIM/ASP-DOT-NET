﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrganizerConferenceDTO : OrganizerRegistrationDTO
    {
        public List<ConferenceDTO> Conferences { get; set; }
        public OrganizerConferenceDTO() 
        {
            Conferences = new List<ConferenceDTO>();
        }
    }
}
