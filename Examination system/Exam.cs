using System.Diagnostics;

namespace Examination_system
{
    abstract class Exam
    {
        #region Attributes
        int timeOfExam;
        int numOfQuestions;
        Question[] questions;
        int typeOfExam;
        #endregion

        #region Properties
        public int TimeOfExam
        {
            get { return timeOfExam; }
            set { timeOfExam = value <= 0 ? 1 : value; }
        }

        public int NumOfQuestions
        {
            get { return numOfQuestions; }
            set { numOfQuestions = value <= 0 ? 1 : value; }
        }

        //
        public Question[] Questions
        {
            get { return questions; }
            set { questions = value ; }
        }

        public int TypeOfExam
        {
            get { return typeOfExam; }
            set { typeOfExam = value == 1 ? value : value == 2 ? value : 1 ; }
        }
        #endregion

        #region Constructors
        public Exam(int timeOfExam, int numOfQuestions, Question[] questions, int typeOfExam)
        {
            TimeOfExam = timeOfExam;
            NumOfQuestions = numOfQuestions;
            Questions = questions;
            TypeOfExam = typeOfExam;
        }
        #endregion

        #region Methods

        public decimal TestUser(Stopwatch SW)
        {
            decimal Points = 0;
            Console.WriteLine("\n======================\n");
            for (int i = 0; i < questions.Length; i++)
            {
                if (SW.Elapsed.TotalSeconds >= TimeOfExam)
                {
                    Console.WriteLine($"\nSorry Time Is Over :(\n");
                    break;
                }

                int a;
                do
                {
                    Console.WriteLine(questions[i]);
                } while (!int.TryParse(Console.ReadLine(), out a) || (a != 1 && a != 2 && (a > questions[i].AnswerList.Length || a < 1)));
                
                Points += (a == questions[i].RightAnswer.AnswerId) ? questions[i].Mark : 0 ;
                Console.WriteLine("\n======================\n");
            }
            Console.WriteLine("\n======================\n");
            return Points;
        }

        public abstract void ShowExam(Stopwatch SW);

        #endregion

    }
}