using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using testImpolRest.Models;
using rondAlgo;

namespace testImpolRest.Controllers
{
    public class CalculationController : ApiController
    {
        Calculation cal = new Calculation();

        public HttpResponseMessage Post(Parameter param)
        {
            List<Rond> result = cal.Calculate(param.length, param.width, param.radius, param.minTopDistance, param.minLeftDistance, param.minMiddleDistance);
            int resultCount = result.Count;
            var response = Request.CreateResponse<int>(System.Net.HttpStatusCode.Created, resultCount);
            return response;
        }
    }
}
