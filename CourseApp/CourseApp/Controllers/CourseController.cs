using BLL.DTO;
using BLL.Services;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CourseApp.Controllers
{
    public class CourseController : ApiController
    {
        [HttpGet]
        [Route("api/course/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CourseService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/course/create")]
        public HttpResponseMessage Create(CourseDTO obj)
        {
           
            try
            {
                
                var data = CourseService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
