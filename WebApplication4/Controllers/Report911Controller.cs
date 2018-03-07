using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.Models;

    namespace WebApplication4.Controllers
    {
        public class Report911Controller : ApiController
        {
        DBReport911 DBReport911 = new DBReport911();
        public object Get()
        {
            var Report911s = from d in DBReport911.Report911s select d;
            return Request.CreateResponse(HttpStatusCode.OK, Report911s);
        }
        public object Post([FromBody]Report911 value)
            {
           
            DBReport911.Report911s.Add(value);
            DBReport911.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK,value);
            }
        }
    }
