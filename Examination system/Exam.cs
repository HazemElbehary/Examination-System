namespace Examination_system
{
    internal class Exam
    {
        #region Attributes
        int timeOfExam;
        int numOfQuestions;
        Question[] questions;
        #endregion

        #region Constructors
        public Exam()
        {
            
        }
        public Exam(int timeOfExam, int numOfQuestions, Question[] questions)
        {
            TimeOfExam = timeOfExam;
            NumOfQuestions = numOfQuestions;
            Questions = questions;
        }
        #endregion

        #region Properties
        public int TimeOfExam
        {
            get { return timeOfExam; }
            set { timeOfExam = value <= 900 ? 900 : value; }
        }

        public int NumOfQuestions
        {
            get { return numOfQuestions; }
            set { numOfQuestions = value <= 0 ? 1 : value; }
        }

        public Question[] Questions
        {
            get { return questions; }
            set { questions = value is null ? [new Question("No Question", "", 0, [new Answers(1, "")], new Answers(1, ""))] : value; }
        }
        #endregion

        #region Methods
        public decimal ShowExam()
        {
            decimal Points = 0;
            Console.WriteLine("\n======================\n");
            for (int i = 0; i < questions.Length; i++)
            {
                int a;
                do
                {
                    Console.WriteLine(questions[i]);
                } while (!int.TryParse(Console.ReadLine(), out a) || (a != 1 && a != 2 && (a >= questions[i].AnswerList.Length || a < 1)));
                
                Points += (a == questions[i].RightAnswer.AnswerId) ? questions[i].Mark : 0 ;
                Console.WriteLine("\n======================\n");
            }
            Console.WriteLine("\n======================\n");

            ShowQuestionsWithRightAnswer();
            return Points;
        }

        void ShowQuestionsWithRightAnswer()
        {
            Console.WriteLine("\n======================\n");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i].HeaderOfQuestion);
                Console.WriteLine(questions[i].BodyOfQuestion);
                Console.WriteLine($"Right Answer : {questions[i].RightAnswer}\n");
            }
            Console.WriteLine("\n======================\n");
        }

        #endregion

    }
}