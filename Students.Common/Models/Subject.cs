using Students.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Students.Common.Models;

public class Subject
{

    public int Id { get; set; }

    [Required]
    [CapitalLettersOnly]
    public string Name { get; set; } = string.Empty;

    [Range(1, 10)]
    public int Credits { get; set; }
    public int LectureHallId { get; set; }
    public int AcademicStaffId { get; set; }


    public List<Student> Students { get; set; } = new List<Student>();
    public LectureHall LectureHall { get; set; }
    public AcademicStaff AcademicStaff { get; set; }
    public ICollection<StudentSubject> StudentSubjects { get; set; } = new List<StudentSubject>();

    public Subject()
    {
    }

    public Subject(string name, int credits, int lectureHallId, int academicStaffId)
    {
        Name = name;
        Credits = credits;
        LectureHallId = lectureHallId;
        AcademicStaffId = academicStaffId;

    }
}
