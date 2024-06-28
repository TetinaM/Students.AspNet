using Microsoft.EntityFrameworkCore;
using Students.Common.Models;

namespace Students.Common.Data;

public class StudentsContext : DbContext
{
    public StudentsContext(DbContextOptions<StudentsContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Student { get; set; } = default!;
    public DbSet<Subject> Subject { get; set; } = default!;
    public DbSet<StudentSubject> StudentSubject { get; set; } = default!;
    public DbSet<AcademicStaff> AcademicStaff { get; set; } = default!;
    public DbSet<StudyField> StudyField { get; set; } = default!;
    public DbSet<LectureHall> LectureHall { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentSubject>()
            .HasKey(ss => new { ss.StudentId, ss.SubjectId });

        modelBuilder.Entity<StudentSubject>()
            .HasOne(ss => ss.Student)
            .WithMany(s => s.StudentSubjects)
            .HasForeignKey(ss => ss.StudentId);

        modelBuilder.Entity<StudentSubject>()
            .HasOne(ss => ss.Subject)
            .WithMany(s => s.StudentSubjects)
            .HasForeignKey(ss => ss.SubjectId);

        modelBuilder.Entity<Subject>()
            .HasOne(s => s.AcademicStaff)
            .WithMany(a => a.Subjects)
            .HasForeignKey(s => s.AcademicStaffId);

        modelBuilder.Entity<Subject>()
            .HasOne(s => s.LectureHall)
            .WithMany(l => l.Subjects)
            .HasForeignKey(s => s.LectureHallId);

        modelBuilder.Entity<Student>()
            .HasOne(s => s.StudyField)
            .WithMany(sf => sf.Students)
            .HasForeignKey(s => s.StudyFieldId);
    }
}

