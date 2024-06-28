using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Common.Models
{
    public class LectureHall
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Capacity { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public LectureHall(int id, string name, int capacity)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
        }
    }
}
