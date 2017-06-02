using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class CompanyViewModel
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int City { get; set; }
        public int Country { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}