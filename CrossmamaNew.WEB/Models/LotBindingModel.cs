using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossmamaNew.WEB.Models
{
    public class LotBindingModel
    {
        public HttpPostedFileBase ImageFile { get; set; }

        public string NownName { get; set; }

        public string GenderName { get; set; }

        public string SizeValue { get; set; }

        public IEnumerable<string> ColorList { get; set; }

        public IEnumerable<string> StructureList { get; set; }

        public string StateName { get; set; }

        public string Comment { get; set; }
    }
}