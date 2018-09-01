using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using SMS.BusinessLogicLayer.Implementations;
using SMS.BusinessLogicLayer.Interfaces;
using System.Web.Http;
using SMS.DomainEntites.ViewModel;

namespace SMS.Services.WebAPI.Controllers
{
    public class EncodingController : ApiController
    {
        private readonly IEncodingManager _encodingManager;

        public EncodingController()
        {
            _encodingManager = new EncodingManager();
        }

        //[HttpGet]
        //public object GetMvReportInfo()
        //{
        //    var result = _encodingManager.GetMvReportInfo();
        //    return result;
        //}


        //[HttpGet]
        //public HttpResponseMessage SearchMvRequestWithHistory(int requestId)
        //{
        //    //throw new Exception("No History found for this Request Id");
        //    var result = _encodingManager.SearchMvRequestWithHistory(requestId);
        //    if (result != null)
        //       return Request.CreateResponse(HttpStatusCode.OK, result);
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound,   "No Trasaction found ");
        //    }
        //}

        //[HttpGet]
        //public HttpResponseMessage GetTrasactionType()
        //{
        //    //throw new Exception("No History found for this Request Id");
        //    var result = _encodingManager.GetTrasactionType();
        //    if (result != null)
        //        return Request.CreateResponse(HttpStatusCode.OK, result);
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Trasaction found ");
        //    }
        //}

        //[HttpGet]
        //public HttpResponseMessage GetRequestSummaryByQueueNumber()
        //{
        //    var result = _encodingManager.GetRequestSummaryByQueueNumber(20005);
        //    if (result != null)
        //        return Request.CreateResponse(HttpStatusCode.OK, result);
        //    else
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Trasaction found ");
        //    }
        //}

        
        [HttpGet]
        public HttpResponseMessage GetRequestType(string outletCode, bool requestTypeOnly = false)
        {
            var result = _encodingManager.GetRequestType(outletCode, requestTypeOnly);
            if (result != null)
                return Request.CreateResponse(HttpStatusCode.OK, result);
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No Request Type found ");
            }
        }
    }
}