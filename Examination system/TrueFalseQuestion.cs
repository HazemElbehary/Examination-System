namespace Examination_system
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string headerOfQuestion, string bodyOfQuestion, decimal mark, Answers[] answerList, Answers rightAnswer) : base(headerOfQuestion, bodyOfQuestion, mark, answerList, rightAnswer)
        {
        }

        public Question CreateQuestion()
        {
            Console.WriteLine($"Please Enter The Header Of Question");
            HeaderOfQuestion = Console.ReadLine();

            Console.WriteLine($"Please Enter The Body Of Question");
            BodyOfQuestion = Console.ReadLine();

            Console.WriteLine($"Please Enter The Mark Of Question");
            decimal.TryParse(Console.ReadLine(), out decimal M);
            Mark = M;

            int CorrectAnswer =1;
            do
            {
                Console.WriteLine("Please Enter The Correct Answer 1.True   2.False");
            } while (!int.TryParse(Console.ReadLine(), out CorrectAnswer) || (CorrectAnswer != 1 && CorrectAnswer != 2));

            AnswerList[0] = new Answers(1, "True");
            AnswerList[0] = new Answers(2, "False");

            return new Question(HeaderOfQuestion, BodyOfQuestion, Mark, AnswerList, RightAnswer);
        }
    }
}
