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
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                int.TryParse(Console.ReadLine(), out int a);
                Points += (a == questions[i].RightAnswer.AnswerId) ? questions[i].Mark : 0 ;
            }
            return Points;
        }
        #endregion

    }
}
