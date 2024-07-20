namespace Examination_system
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numOfQuestions, Question[] questions, int typeOfExam) : base(timeOfExam, numOfQuestions, questions, typeOfExam)
        {
        }

        public override void ShowExam()
        {
            decimal Grade = base.TestUser();

            Console.WriteLine("\n======================\n");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"Q0{i+1}. Right Answer : {Questions[i].RightAnswer}\n");
            }
            Console.WriteLine("\n======================\n");
        }
    }
}
