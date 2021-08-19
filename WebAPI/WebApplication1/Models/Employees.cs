using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Models
{
    public class Employees
    {
        public int uid { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string CompanyName { get; set; }
        public string email { get; set; }
        public string paswd { get; set; }
        public string UserCatalouge { get; set; }
        public string UserCountry { get; set; }
        public string UserRole { get; set; }
        public string UserIsActive { get; set; }

  }
}
