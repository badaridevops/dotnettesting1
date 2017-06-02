using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    // TODO: Complete missing part
    public class User
    {
        public int Id { get; set; }

        [MaxLength(64)]
        public string DisplayName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}