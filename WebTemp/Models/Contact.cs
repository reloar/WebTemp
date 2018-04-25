using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTemp.Models
{
    public class Contact:IdentityUser
    {
        public string ProfileImage { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Product { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
    }
}