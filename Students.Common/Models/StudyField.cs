using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Common.Models
{
    public class StudyField
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<Subject> Subjects { get; set; }

        public StudyField (int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
