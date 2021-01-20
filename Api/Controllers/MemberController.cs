using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/member/{id}")]
    public class MemberController : ControllerBase
    {
        public MemberController()
        {
        }

        public dynamic GetMemberDetails(int id)
        {
            // return the member details
            return "Member details object";
        }

        [Route("membershipdetails")]
        public dynamic GetMembershipDetails(int id)
        {
            // return the member ship details
            return "MemberShip details object";
        }

        [Route("requests")]
        public List<string> GetRequests(int id)
        {
            // requests made by the member
            return new List<string>();
        }

        [Route("fine")]
        public int GetCalculatedFine(int id)
        {
            return 10;
            // calculate fine for em
        }
    }
}

