using EF_task_2.Contexts;
using EF_task_2.Models;

namespace EF_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ITIDbContext context = new ITIDbContext();
            
            Course course = new Course 
            {
                 Name = "Test",
                 Duration = 20,
                 Description = "Test",
            };
            Course_Inst course_Inst = new Course_Inst 
            {
                Evaluate = "Test",
            };
            Department department = new Department
            {
                Name = "HR",
                HiringDate = new DateTime()
            };
            Instructor instructor = new Instructor
            {
                Address = "Cairo",
                HourRateBouns = 10,
                Name = "Test",
                Salary = 10000
            };
            Stud_Course stud_Course = new Stud_Course
            {
                Grade = 50
            };
            Student student = new Student
            {
                Address = "Cairo",
                Age = 20,
                FName = "Test",
                LName = "Test"
            };
            Topic topic = new Topic
            {
                Name = "Programing"
            };
            // ADD
            context.Add(course);
            context.Add(course_Inst);
            context.Add(department);
            context.Add(instructor);
            context.Add(stud_Course);
            context.Add(student);
            context.Add(topic);
                
            context.SaveChanges();

            // Retrieve
            var course1 = context.Courses.FirstOrDefault(course1 => course1.Name == "Test");
            var course_inst = context.Course_Insts.FirstOrDefault(course_inst => course_inst.inst_ID == 1);
            var department1 = context.Departments.FirstOrDefault(department1 => department1.ID == 1);
            var instructor1 = context.Instructors.FirstOrDefault(instructor1 => instructor1.ID == 1);
            var stud_Course1 = context.Stud_Courses.FirstOrDefault(stud_Course1 => stud_Course1.stud_ID == 1);
            var student1 = context.Students.FirstOrDefault(student1 => student1.Id == 1);
            var topic1 = context.Topics.FirstOrDefault(topic1 => topic1.ID == 1);
            Console.WriteLine(course1.ID);
            Console.WriteLine(course_inst);
            Console.WriteLine(department1);
            Console.WriteLine(instructor1);
            Console.WriteLine(stud_Course1);
            Console.WriteLine(student1);
            Console.WriteLine(topic1);

            // Update
            var course2 = context.Courses.FirstOrDefault(course1 => course1.Name == "Test");
            if (course2 is not null)
            {
                course2.Name = "Test";
                context.SaveChanges();
            }

            // Delete
            context.Remove(course1);
            context.Remove(course2);
            context.Remove(course_inst);
            context.Remove(department1);
            context.Remove(instructor1);
            context.Remove(stud_Course1);
            context.Remove(student1);
            context.Remove(topic1);
            context.SaveChanges();

        }
    }
}
