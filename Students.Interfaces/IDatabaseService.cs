using Students.Common.Models;

public interface IDatabaseService
{
    bool EditStudent(int id, string name, int age, string major, int[] subjectIdDst);
    Student? DisplayStudent(int? id);
    Task<Student> CreateStudentAsync(Student student, int[] subjectIdDst);
    Task<bool> UpdateStudentAsync(int id, string name, int age, string major, int[] subjectIdDst);
    Task<bool> DeleteStudentAsync(int id);
}