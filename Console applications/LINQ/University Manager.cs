using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class University_Manager
    {
        List<University> universities = new List<University>();
        List<Student> students = new List<Student>();

        public University_Manager()
        {
            universities = new List<University>();
            students = new List<Student>();

            //Let's add some Universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Beijing Tech" });

            //Let's add some Students
            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Toni", Gender = "male", Age = 21, UniversityId = 1 });
            students.Add(new Student { Id = 3, Name = "Frank", Gender = "male", Age = 22, UniversityId = 2 });
            students.Add(new Student { Id = 4, Name = "Leyla", Gender = "female", Age = 19, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 });
            students.Add(new Student { Id = 6, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortedStudents()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Sorted students");
            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromBejing()
        {
            IEnumerable<Student> bjStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Name == "Beijing Tech"
                                              select student;
            Console.WriteLine("Students from Beijing Tech");
            foreach (Student student in bjStudents)
            {
                student.Print();
            }
        }

        public void ReceiveStudentsUniversity(int id)
        {
            IEnumerable<Student> myStudents = from student in students
                                              join university in universities on student.UniversityId equals university.Id
                                              where university.Id == id
                                              select student;
            Console.WriteLine("Students from {0}", id);
            foreach (Student student in myStudents)
            {
                student.Print();
            }

        }

        public void StudentAndUniviersityNames()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collections");
            foreach (var col in newCollection)
            {
                Console.WriteLine($"Student {col.StudentName}, from University {col.UniversityName}");
            }
        }


    }
}
