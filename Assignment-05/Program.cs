namespace Assignment_05
{
    class Program
    {
        static void Main()
        {
            // Main
            Exam exam = new();

            // Teacher ==> create exam
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   Hello Teacher");
            Console.WriteLine("╔==========================================================================╗");
            Console.Write("║ How Many Question you Want ? \n║ ==>: ");
            int NumberQuestion = Convert.ToInt32(Console.ReadLine());
            Console.Write("║ Chose Type Of Question, (T) for true or false and, (C) for Choose one ? \n║ ==>: ");
            string ch = Convert.ToString(Console.ReadLine()).ToUpper();
            if (ch != "C" && ch != "T")
                throw new InvalidDataException("Invalid Data please enter (C) or (T)");
            for (int i = 0; i < NumberQuestion; i++)
            {
                Console.Write("║ Enter your Question\n║ ==>: ");
                string Head = Console.ReadLine();

                Console.Write("║ Enter the mark\n║ ==>: ");
                int Marks = Convert.ToInt32(Console.ReadLine());

                List<string> Body = new();
                
                if(ch == "C")
                {
                    Console.WriteLine("║ Enter your answer");
                    for (int j=0; j<4; j++)
                    {
                        Console.Write($"║ {j+1}- ");
                        Body.Add(Console.ReadLine());
                    }
                    Console.Write("║ Enter Correct Answer\n║ ==>: ");
                    string CorrectAnswer = Console.ReadLine();
                    ChooseOneQuestion chooseOneQuestion = new(Head, Body, Marks, CorrectAnswer);
                    exam.AddQuestion(chooseOneQuestion);
                }

                if (ch == "T") 
                {
                    Console.Write("║ Enter Correct Answer (true) or (false)\n║ ==>: ");
                    string CorrectAnswer = Console.ReadLine();
                    TrueOrFalseQuestion trueOrFalseQuestion = new(Head,  Marks, CorrectAnswer);
                    exam.AddQuestion(trueOrFalseQuestion);
                }

            }
            Console.WriteLine("╚==========================================================================╝");
            Console.ResetColor();

            // Student ==> Exam
            int sum = 0;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Choose one
            Console.WriteLine("   Hello Student");
            Console.WriteLine("╔=====================================╗");
            for (int i = 0; i<exam.chooseOneQuestions.Count(); i++)
            {
                Console.WriteLine($"║ {exam.chooseOneQuestions[i].Header} ({exam.chooseOneQuestions[i].Marks})");

                for (int j=0; j< exam.chooseOneQuestions[i].Body.Count; j++)
                    Console.WriteLine($"║ {j+1}- {exam.chooseOneQuestions[i].Body[j]}");

                Console.Write("║ Enter your answer pleas\n║ ==>: ");
                string answer = Console.ReadLine();
                try
                {
                    if (exam.chooseOneQuestions[i].IsCorrect(exam.chooseOneQuestions[i].Body[Convert.ToInt32(answer) - 1]))
                    {
                        sum += exam.chooseOneQuestions[i].Marks;
                    }
                }
                catch (Exception)
                {
                    if (exam.chooseOneQuestions[i].IsCorrect(answer))
                    {
                        sum += exam.chooseOneQuestions[i].Marks;
                    }
                }


            }
            // True Or False
            for (int i = 0; i<exam.trueOrFalseQuestions.Count(); i++)
            {
                Console.WriteLine($"║ {exam.trueOrFalseQuestions[i].Header} ({exam.trueOrFalseQuestions[i].Marks})");
                for (int j=0; j< exam.trueOrFalseQuestions[i].Body.Count; j++)

                    Console.WriteLine($"║ {j+1}- {exam.trueOrFalseQuestions[i].Body[j]} ");

                Console.Write("║ Enter your answer pleas\n║ ==>: ");
                string answer = Console.ReadLine();
                try
                {
                    if (exam.trueOrFalseQuestions[i].IsCorrect(exam.trueOrFalseQuestions[i].Body[Convert.ToInt32(answer) - 1]))
                    {
                        sum += exam.trueOrFalseQuestions[i].Marks;
                    }
                }
                catch (Exception)
                {
                    if (exam.trueOrFalseQuestions[i].IsCorrect(answer))
                    {
                        sum += exam.trueOrFalseQuestions[i].Marks;
                    }
                }
            }
            Console.WriteLine("╚=====================================╝");
            Console.ResetColor();

            // print
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔=======================╗");
            Console.WriteLine($"║   Your resoult is {sum}   ║");
            Console.WriteLine("╚=======================╝");
        }

    }
}