using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class User:IdentityUser
    {
        public virtual Parent Parent { get; set; }
    }
}
