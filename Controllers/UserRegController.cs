using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WEBFORMSAssignment.Models;


namespace WEBFORMSAssignment.Controllers
{
    public class UserRegController : ApiController
    {
        public IHttpActionResult addnewuser(newuserreg nu)
        {
            formdbEntities nd = new formdbEntities();
            nd.Userreg(nu.Username, nu.Pwd, nu.Repwd, nu.Email, nu.Gender, nu.Maritalstatus, nu.Joindate);
            nd.SaveChanges();
            return Ok();
        }
    }
}
