using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Common.Models
{
    public class AcademicStaff
    {
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        public string Position { get; set; }

        public AcademicStaff (int id, string fullName, string position)
        {
            Id = id;
            FullName = fullName;
            Position = position;
        }
    }
}
