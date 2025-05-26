using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    class StudentManager
    {
        // Properties:
        public List<Student> Students = new();
        public List<Course> Courses = new();
        public List<Instructor> Instructors = new();

         // Methods:
        public bool AddStudent(Student student)
        {
            bool addedStudent = false;
            // check student
            if (student.Age > 5 && student.Name.Length >= 3)
            {
                // add student
                Students.Add(student);
                addedStudent = true;
            }       
            return addedStudent;
        }
        public bool AddCourse(Course course)
        {
            bool courseAdded = false;
            if (Instructors.Contains(course.instructor))
            {
                Courses.Add(course);
                courseAdded = true;
            }
            return courseAdded;
        }
        public bool AddInstructor(Instructor instructor)
        {
            bool addedInstuctor = false;
            // check instructor
            if (instructor.Name.Length >= 3)
            {
                // add student
                Instructors.Add(instructor);
                addedInstuctor = true;
            }
            return addedInstuctor;
        }
        public Student FindStudent(int studentId)
        {
            Student student = new("yusif", 23);
            return student;
        }
        public Course FindCourse(int courseId)
        {
            Instructor instructor = new("yusif","english");
            Course course = new("yusif",instructor);
            return course;
        }
        public Instructor FindInstructor(int instructorId)
        {
            Instructor instructor = new("ali","english");
            return instructor;
        }
        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            return true;
        }

    }
}
