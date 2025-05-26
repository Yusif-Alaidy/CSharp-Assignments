namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager school = new();
            string mainScreen = "\t\t╔==========================================================================╗\n" +
                                "\t\t║    1. Add Student (hint: start with empty list of courses)               ║\n" +
                                "\t\t║    2. Add Instructor                                                     ║\n" +
                                "\t\t║    3. Add Course (hint: select the instructor by id or name)             ║\n" +
                                "\t\t║    4. Enroll Student in Course                                           ║\n" +
                                "\t\t║    5. Show All Students                                                  ║\n" +
                                "\t\t║    6. Show All Courses                                                   ║\n" +
                                "\t\t║    7. Show All Instructors                                               ║\n" +
                                "\t\t║    8. Find the student by id or name                                     ║\n" +
                                "\t\t║    9. Fine the course by id or name                                      ║\n" +
                                "\t\t║   10. Check if the student enrolled in specific course                   ║\n" +
                                "\t\t║   11. Return the instructor name by course name                          ║\n" +
                                "\t\t║   12. Update student information                                         ║\n" +
                                "\t\t║   13. Delete Student                                                     ║\n" +
                                "\t\t║   14. Exit                                                               ║\n" +
                                "\t\t╚==========================================================================╝";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(mainScreen);
            Console.ResetColor();
            int input;
            do
            {
                Console.Write("\t\tEnter Your Choise ^_^ ==>: ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.Write("\n\t\t╔=========================╗\n" +
                                        "\t\t║   Enter Student Name    ║\n" +
                                        "\t\t╚=========================╝\n");
                        Console.Write("\t\t==>: ");
                        string studentName = Console.ReadLine();                        
                        Console.Write("\t\t╔=======================╗\n" +
                                      "\t\t║   Enter Student Age   ║\n" +
                                      "\t\t╚=======================╝\n");
                        Console.Write("\t\t==>: ");
                        int studentAge = Convert.ToInt32(Console.ReadLine());

                        bool studentAdded = school.AddStudent(new(studentName, studentAge));
                        if (studentAdded)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔=================╗\n" +
                                          "\t\t║   Success ^_^   ║\n" +
                                          "\t\t╚=================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔===============================╗\n" +
                                          "\t\t║   There something wrong X_X   ║\n" +
                                          "\t\t╚===============================╝\n");
                        }
                        Console.ResetColor();
                        break;
                    case 2:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.Write("\n\t\t╔============================╗\n" +
                                        "\t\t║   Enter Instructor Name    ║\n" +
                                        "\t\t╚============================╝\n");
                        Console.Write("\t\t==>: ");
                        string instructorName = Console.ReadLine();
                        Console.Write("\t\t╔=====================================╗\n" +
                                      "\t\t║   Enter Instructor Specialization   ║\n" +
                                      "\t\t╚=====================================╝\n");
                        Console.Write("\t\t==>: ");
                        string instructorSpecialization = Console.ReadLine();

                        bool instructorAdded = school.AddInstructor(new(instructorName, instructorSpecialization));
                        if (instructorAdded)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔=================╗\n" +
                                          "\t\t║   Success ^_^   ║\n" +
                                          "\t\t╚=================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔===============================╗\n" +
                                          "\t\t║   There something wrong X_X   ║\n" +
                                          "\t\t╚===============================╝\n");
                        }
                        Console.ResetColor();
                        break;
                    case 3:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        bool courseAdded = false;
                        Console.Write("\n\t\t╔=======================╗\n" +
                                        "\t\t║   Enter Course Name   ║\n" +
                                        "\t\t╚=======================╝\n");
                        Console.Write("\t\t==>: ");
                        string courseName = Console.ReadLine();

                        Console.Write("\n\t\t╔================================╗\n" +
                                        "\t\t║   Enter Instructor Name or Id  ║\n" +
                                        "\t\t╚================================╝\n");
                        Console.Write("\t\t==>: ");
                        string NameOrId = Console.ReadLine();
                        for (int i=0; i<school.Instructors.Count; i++)
                        {
                            if(NameOrId == school.Instructors[i].Name || NameOrId == Convert.ToString(school.Instructors[i].InstructorId))
                            {
                                Instructor courseInstructor = school.Instructors[i];
                                courseAdded = school.AddCourse(new(courseName, courseInstructor));
                            }
                        }
                        if (courseAdded)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔=================╗\n" +
                                          "\t\t║   Success ^_^   ║\n" +
                                          "\t\t╚=================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔===============================╗\n" +
                                          "\t\t║   There something wrong X_X   ║\n" +
                                          "\t\t╚===============================╝\n");
                            Console.ResetColor();
                        }
                        break;
                    case 4:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        bool enrolled = false;
                        Console.Write("\n\t\t╔========================╗\n" +
                                        "\t\t║   Enter Student Name   ║\n" +
                                        "\t\t╚========================╝\n");
                                                Console.Write("\t\t==>: ");
                        string enrollStudent = Console.ReadLine();

                        Console.Write("\n\t\t╔=======================╗\n" +
                                        "\t\t║   Enter Course Name   ║\n" +
                                        "\t\t╚=======================╝\n");
                        Console.Write("\t\t==>: ");
                        string enrollCourse = Console.ReadLine();
                        for (int i=0; i<school.Students.Count; i++)
                        {
                            if (school.Students[i].Name == enrollStudent)
                            {
                                for(int j=0; j<school.Courses.Count; j++)
                                {
                                    if (school.Courses[j].title == enrollCourse)
                                    {
                                        enrolled = school.Students[i].Enroll(school.Courses[j]);
                                    }
                                }
                            }
                        }
                        if (enrolled)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔=================╗\n" +
                                          "\t\t║   Success ^_^   ║\n" +
                                          "\t\t╚=================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔=======================================╗\n" +
                                          "\t\t║   Student or course is not exis X_X   ║\n" +
                                          "\t\t╚=======================================╝\n");
                            Console.ResetColor();
                        }
                        break;
                    case 5:                        
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        if (school.Students.Count < 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\t\t╔========================╗\n" +
                                              "\t\t║ [] - the list is empty ║\n" +
                                              "\t\t╚========================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (int i = 0; i < school.Students.Count; i++)
                            {
                                Console.Write($"\n\t\t╔=======================================╗\n" +
                                                $"\t\t║   Student Id ==>: {school.Students[i].StudentId} \n" +
                                                $"\t\t║   Name       ==>: {school.Students[i].Name}      \n" +
                                                $"\t\t║   age        ==>: {school.Students[i].Age}       \n" +
                                                $"\t\t╚=======================================╝\n");
                            }
                        }
                        Console.ResetColor();
                        break;
                    case 6:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        if (school.Courses.Count < 1)
                        {
                            Console.WriteLine("\t\t╔========================╗\n" +
                                              "\t\t║ [] - the list is empty ║\n" +
                                              "\t\t╚========================╝\n");
                        }
                        else
                        {
                            for (int i = 0; i < school.Courses.Count; i++)
                            {
                                Console.Write($"\n\t\t╔=======================================╗\n" +
                                                $"\t\t║   Course Id          ==>: {school.Courses[i].courseId}          \n" +
                                                $"\t\t║   Title              ==>: {school.Courses[i].title}             \n" +
                                                $"\t\t║   Instructor name    ==>: {school.Courses[i].instructor.Name}   \n" +
                                                $"\t\t╚=======================================╝\n");
                            }
                        }
                        Console.ResetColor();
                        break;
                    case 7:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        if (school.Instructors.Count < 1)
                        {
                            Console.WriteLine("\t\t╔========================╗\n" +
                                              "\t\t║ [] - the list is empty ║\n" +
                                              "\t\t╚========================╝\n");
                        }
                        else
                        {
                            for (int i = 0; i < school.Instructors.Count; i++)
                            {
                                Console.Write($"\n\t\t╔=======================================╗\n" +
                                                $"\t\t║   Instructor Id     ==>: {school.Instructors[i].InstructorId}     \n" +
                                                $"\t\t║   Name              ==>: {school.Instructors[i].Name}             \n" +
                                                $"\t\t║   Specialization    ==>: {school.Instructors[i].Specialization}   \n" +
                                                $"\t\t╚=======================================╝\n");
                            }
                        }
                        Console.ResetColor();
                        break;
                    case 8: // Find student with id or name
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.Write("\n\t\t╔==============================╗\n" +
                                        "\t\t║   Enter Student Name or Id   ║\n" +
                                        "\t\t╚==============================╝\n");
                                                Console.Write("\t\t==>: ");
                        string StudentNameOrId = Console.ReadLine();
                        for (int i=0; i<school.Students.Count; i++)
                        {
                            if (StudentNameOrId == school.Students[i].Name||StudentNameOrId == Convert.ToString(school.Students[i].StudentId))
                            {
                                Console.WriteLine(school.Students[i].PrintDetails());

                            }
                        }
                        break;
                    case 9: // Find course with id or name
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.Write("\n\t\t╔=============================╗\n" +
                                        "\t\t║   Enter Course Name or Id   ║\n" +
                                        "\t\t╚=============================╝\n");
                                                Console.Write("\t\t==>: ");
                        string CourseNameOrId = Console.ReadLine();
                        for (int i=0; i<school.Courses.Count; i++)
                        {
                            if (CourseNameOrId == school.Courses[i].title||CourseNameOrId == Convert.ToString(school.Courses[i].courseId))
                            {
                                Console.WriteLine(school.Courses[i].PrintDetails());

                            }
                        }
                        break;
                    case 10:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.Write("\n\t\t╔==============================╗\n" +
                                        "\t\t║   Enter Student Name or Id   ║\n" +
                                        "\t\t╚==============================╝\n");
                        Console.Write("\t\t==>: ");
                        string student_name_id = Console.ReadLine();
                        Console.Write("\n\t\t╔=======================╗\n" +
                                        "\t\t║   Enter Course Name   ║\n" +
                                        "\t\t╚=======================╝\n");
                        Console.Write("\t\t==>: ");
                        string course_name = Console.ReadLine();
                        bool enrolledCourse = false;
                        for(int i=0; i<school.Students.Count; i++)
                        {
                            if (school.Students[i].Name==student_name_id || school.Students[i].StudentId == Convert.ToUInt32(student_name_id))
                            {
                                for (int j=0; j<school.Courses.Count; j++)
                                {
                                    if (school.Courses[j].title == course_name)
                                    {
                                        enrolledCourse = school.Students[i].Courses.Contains(school.Courses[j]);
                                    }
                                }
                            }
                        }
                        if (enrolledCourse)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔==================================================╗\n" +
                                          "\t\t║   Yes this student is enrolled this course >_<   ║\n" +
                                          "\t\t╚==================================================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔=====================================================╗\n" +
                                          "\t\t║   No this student is not enrolled this course X_X   ║\n" +
                                          "\t\t╚=====================================================╝\n");
                            Console.ResetColor();
                        }
                        break;
                    case 11:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        Console.Write("\n\t\t╔==============================╗\n" +
                                        "\t\t║   Enter Course Name or Id    ║\n" +
                                        "\t\t╚==============================╝\n");
                        Console.Write("\t\t==>: ");
                        string name = "";
                        string CourseName = Console.ReadLine();
                        for (int i=0; i<school.Courses.Count; i++)
                        {
                            if (school.Courses[i].title == CourseName)
                            {
                                name = school.Courses[i].instructor.Name;
                            }
                        }
                        if (name != "")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔==================================================╗\n" +
                                         $"\t\t║   The instructor for this coures is {name} >_<    \n" +
                                          "\t\t╚==================================================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔=================================╗\n" +
                                         $"\t\t║   The course is not exist X_X   ║\n" +
                                          "\t\t╚=================================╝\n");
                            Console.ResetColor();
                        }
                        break;
                    case 12:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        bool changined = false;
                        Console.Write("\n\t\t╔========================╗\n" +
                                        "\t\t║   Enter student Name   ║\n" +
                                        "\t\t╚========================╝\n");
                        Console.Write("\t\t==>: ");
                        string student_name = Console.ReadLine();

                        Console.Write("\n\t\t╔=============================╗\n" +
                                        "\t\t║   What you want to change   ║\n" +
                                        "\t\t║   1. student name           ║\n" +
                                        "\t\t║   2. student age            ║\n" +
                                        "\t\t╚=============================╝\n");
                        Console.Write("\t\t==>: ");
                        string input2 = Console.ReadLine();

                        Console.Write("\n\t\t╔====================╗\n" +
                                        "\t\t║   Enter new data   ║\n" +
                                        "\t\t╚====================╝\n");
                        Console.Write("\t\t==>: ");
                        string newData = Console.ReadLine();

                        for (int i=0;  i<school.Students.Count; i++)
                        {
                            if (school.Students[i].Name == student_name)
                            {
                                if (input2 == "1")
                                {
                                    changined = true;
                                    school.Students[i].Name = newData;
                                }
                                else if (input2 == "2")
                                {
                                    changined = true;
                                    school.Students[i].Age = Convert.ToInt32(newData);
                                }
                            }
                        }
                        if (changined)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔======================================╗\n" +
                                         $"\t\t║   The information is changined >_<   ║\n" +
                                          "\t\t╚======================================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔=================================================╗\n" +
                                         $"\t\t║   The student is not exsit or there issue X_X   ║\n" +
                                          "\t\t╚=================================================╝\n");
                            Console.ResetColor();
                        }

                        break;
                    case 13:
                        // main screen
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(mainScreen);
                        Console.ResetColor();

                        bool deleted = false;
                        Console.Write("\n\t\t╔========================╗\n" +
                                        "\t\t║   Enter student Name   ║\n" +
                                        "\t\t╚========================╝\n");
                        Console.Write("\t\t==>: ");
                        string student_name_delete = Console.ReadLine();

                        for (int i = 0; i < school.Students.Count; i++)
                        {
                            if (school.Students[i].Name == student_name_delete)
                            {
                                deleted = true;
                                school.Students.Remove(school.Students[i]);
                            }
                        }
                        if (deleted)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\t\t╔================================╗\n" +
                                         $"\t\t║   The Student is deleted >_<   ║\n" +
                                          "\t\t╚================================╝\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("\t\t╔==================================╗\n" +
                                         $"\t\t║   The Student is not exsit X_X   ║\n" +
                                          "\t\t╚==================================╝\n");
                            Console.ResetColor();
                        }
                        break;
                    case 14:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t╔========================╗\n" +
                                          "\t\t║   See You Later ＞__＜   ║\n" +
                                          "\t\t╚========================╝\n\n");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\t╔=========================================╗\n" +
                                          "\t\t║   Unknown selection, please try again   ║\n" +
                                          "\t\t╚=========================================╝");
                        Console.ResetColor();
                        break;

                }
            } while (input != 14);
        }
    }
}
