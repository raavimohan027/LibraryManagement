using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/requests")]
    public class RequestController : ControllerBase
    {
        public RequestController()
        {
        }

        [Route("all")]
        public List<string> GetRequests(int id)
        {
            // all requests
            return new List<string>();
        }

        [Route("add")]
        public bool PostRequestBook(dynamic request)
        {

            //add the request or renewal
            return true;
        }

        [Route("requestrenewal")]
        public bool PostRenewalRequest(dynamic request)
        {

            //add the request or renewal
            return true;
        }

        [Route("{id}/update")]
        public bool PutRequestBook(int id, dynamic request)
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

        [Route("{id}/cancel")]
        public bool DeleteRequest(int id)
        {
            //cancel or delete the request
            return true;
        }
    }
}
