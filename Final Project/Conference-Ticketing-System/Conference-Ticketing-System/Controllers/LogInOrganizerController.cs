﻿using BLL.Services;
using Conference_Ticketing_System.AuthFilter;
using Conference_Ticketing_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Conference_Ticketing_System.Controllers
{
    
    public class LogInOrganizerController : ApiController
    {
        [HttpPost]
        [Route("api/login/Organizer")]
        public HttpResponseMessage Login(LogInOrganizerModel data)
        {
            var token = AuthServices.Login(data.Name, data.Password);
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { Msg = "Organizer not found" });
            }


        }
    }
}
