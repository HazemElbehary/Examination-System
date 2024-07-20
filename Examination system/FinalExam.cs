namespace Examination_system
{
    internal class FinalExam : Exam
    {
        public FinalExam(int timeOfExam, int numOfQuestions, Question[] questions, int typeOfExam) : base(timeOfExam, numOfQuestions, questions, typeOfExam)
        {
        }

        public override void ShowExam()
        {
            decimal Grade = base.TestUser();

            Console.WriteLine("\n======================\n");
            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine(Questions[i].HeaderOfQuestion);
                Console.WriteLine(Questions[i].BodyOfQuestion);
                Console.WriteLine($"Right Answer : {Questions[i].RightAnswer}\n");
            }
            Console.WriteLine("\n======================\n");
            Console.WriteLine($"Your Grade = {Grade}");
        }
    }
}
