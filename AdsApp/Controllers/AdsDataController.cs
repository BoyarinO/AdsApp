using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.IO;
using System.Dynamic;

namespace AdsApp.Controllers
{
    public class AdsDataController : ApiController
    {
        public IHttpActionResult GetImage()
        {
            string FilePath = HttpContext.Current.Server.MapPath("~/images/image1.jpg");
            byte[] myBytes = File.ReadAllBytes(FilePath);
            return Ok(myBytes);
        }
        public string GetQuestion()
        {
            string question = "Question #1: Variant1 Variant2 Variant3";
            return question;
        }

        public dynamic GetData()
        {
            dynamic data = new ExpandoObject();
            string question = "Question #1: Variant1 Variant2 Variant3";
            string FilePath = HttpContext.Current.Server.MapPath("~/images/image1.jpg");
            byte[] myBytes = File.ReadAllBytes(FilePath);
            data.Question = question;
            data.Image = myBytes;
            return data;

        }
    }
}
