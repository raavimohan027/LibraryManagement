using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/request")]
    public class RequestController : ControllerBase
    {
        public RequestController()
        {
        }

        [Route("all")]
        public List<string> GetRequests()
        {
            // all requests
            return new List<string>();
        }

        public bool PostRequest(dynamic request)
        {

            //add the request or renewal
            return true;
        }

        [Route("{id}/requestrenewal")]
        public bool PostRenewalRequest(int id, dynamic request)
        {

            //add the request or renewal
            return true;
        }

        [Route("{id}")]
        public bool PutRequest(int id, dynamic request)
        {
            //update the request or renewal
            return true;
        }

        [Route("{id}/approve")]
        public void PutApproveRequest(int id)
        {
            // approve the request made by the member
        }

        [Route("{id}/reject")]
        public void PutRejectRequest(int id)
        {
            // reject the request made by the member
        }

        [Route("{id}")]
        public bool DeleteRequest(int id)
        {
            //cancel or delete the request
            return true;
        }
    }
}
