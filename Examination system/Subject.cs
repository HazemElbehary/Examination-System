namespace Examination_system
{
    internal class Subject
    {
        int SubId;
        string SubName;
        //Exam ExamOfTheSubject;

        public Exam ExamOfTheSubject { get; set; }
        public int TypeOfExam { get; set; }

        public Subject(int SubId, string SubName)
        {
            this.SubId = SubId;
            this.SubName = SubName;
        }


        public void CreateExam()
        {
            // Read The Type Of Exam Practical Exam OR Final
            int TypeOfExam;
            do
            {
                Console.WriteLine("Please Enter The Type Of The Exam    1.Final Exam    2.Practical Exam");
            } while (!int.TryParse(Console.ReadLine(), out TypeOfExam) || (TypeOfExam != 1 && TypeOfExam != 2));

            //
            this.TypeOfExam = TypeOfExam;

            // Read The Number Of Questions
            int NumOfQuestions;
            do
            {
                Console.WriteLine("Please Enter The Number Of The Questoins");
            } while (!int.TryParse(Console.ReadLine(), out NumOfQuestions) || (NumOfQuestions <= 0));

            // Create Are Of questions 
            Question[] questions = new Question[NumOfQuestions];

            // Read The Time Of Exam
            int TimeOfExam;
            do
            {
                Console.WriteLine("Please Enter The Time Of The Exam");
            } while (!int.TryParse(Console.ReadLine(), out TimeOfExam) || (TimeOfExam <= 0));

            // Final Exam
            if (TypeOfExam == 1)
            {
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    // Read The Type Of Question {i+1}
                    int TOfQ;
                    do
                    {
                        Console.WriteLine($"Do You Want Question Number 0{i + 1} 1.True False OR 2.MCQ");
                    } while (!int.TryParse(Console.ReadLine(), out TOfQ) || (TOfQ != 1 && TOfQ != 2));

                    if (TOfQ == 1)
                    {
                        TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion("", "", 0, null, null);
                        questions[i] = trueFalseQuestion.CreateQuestion();
                    }
                    else
                    {
                        MCQQuestion mCQQuestion = new MCQQuestion("", "", 0, null, null);
                        questions[i] = mCQQuestion.CreateQuestion();
                    }
                }
            }

            // Practical Exam
            else
            {
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    MCQQuestion mCQQuestion = new MCQQuestion("", "", 0, null, null);
                    questions[i] = mCQQuestion.CreateQuestion();
                }
            }

            ExamOfTheSubject = new Exam(TimeOfExam, NumOfQuestions, questions);
        }
    }
}
