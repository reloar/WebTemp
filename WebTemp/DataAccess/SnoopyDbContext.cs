using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebTemp.Models;

namespace WebTemp.DataAccess
{
    public class SnoopyDbContext:IdentityDbContext<Contact>
    {
        public SnoopyDbContext():base($"name={nameof(SnoopyDbContext)}")
        {
                
        }
    }
}