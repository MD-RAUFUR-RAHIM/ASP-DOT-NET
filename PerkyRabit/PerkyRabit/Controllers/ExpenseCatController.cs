using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PerkyRabit.Controllers
{
    public class ExpenseCatController : ApiController
    {

        [HttpGet]
        [Route("all/catagory")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ExpenseCatServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpGet]
        [Route("get/catagory/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ExpenseCatServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpPost]
        [Route("create/catagory")]
        public HttpResponseMessage Add(ExpenseCatDTO obj)
        {
            try
            {
                var data = ExpenseCatServices.Add(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpPut]
        [Route("update/catagory")]
        public HttpResponseMessage Update(ExpenseCatDTO obj)
        {
            try
            {
                var data = ExpenseCatServices.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpDelete]
        [Route("delete/catagory/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ExpenseCatServices.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
    }
}
