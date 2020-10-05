using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossmamaNew.DAL.Entities
{
    public class Parent
    {
        [Key]
        [ForeignKey("User")]
        public string Id { get; set; }

        public string Address { get; set; }

        public virtual User User { get; set; }
    }
}
