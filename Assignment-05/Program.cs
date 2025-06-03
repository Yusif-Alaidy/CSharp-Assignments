namespace Assignment_05
{
    class Program
    {
        static void Main()
        {
            Subject math = new Subject { Name = "Math" };
            Student s1 = new Student { Name = "Ahmed" };
            math.Students.Add(s1);
            math.ExamStarted += s1.OnExamStarted;

            PracticeExam practice = new PracticeExam(30, math);
            FinalExam final = new FinalExam(60, math);

            // إعداد أسئلة وإجابات
            var q1 = new TrueFalseQuestion("Q1", "2+2=4?", 5);
            var a1 = new AnswerList();
            a1.Add(new Answer("True", true));
            a1.Add(new Answer("False", false));

            practice.QandA.Add(q1, a1);
            final.QandA.Add(q1, a1);

            Console.WriteLine("Choose Exam Type (1-Practice, 2-Final): ");
            string choice = Console.ReadLine();

            Exam selected = (choice == "1") ? (Exam)practice : final;
            selected.Mode = "Starting";
            selected.Subject.StartExam();

            Console.WriteLine("\n--- Exam ---");
            selected.Show();
        }
    }
}