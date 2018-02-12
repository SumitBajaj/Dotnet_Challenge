using Dotcom_Challenge.Models;
using Dotcom_Challenge_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dotcom_Challenge.Controllers
{
    public class ConversionController : ApiController
    {
        IConversion _conversion = new Conversion();
        ConversionModel cModel = new ConversionModel();
        public IHttpActionResult GetConvertedWords(int id)
        {           
            return Ok(_conversion.ConversionToWords(id.ToString()));
        }      
    }
}
