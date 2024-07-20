namespace Examination_system
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string headerOfQuestion, string bodyOfQuestion, decimal mark, Answers[] answerList, Answers rightAnswer) : base(headerOfQuestion, bodyOfQuestion, mark, answerList, rightAnswer)
        {
        }

        public Question CreateQuestion()
        {
            do
            {
                Console.WriteLine($"Please Enter The Header Of Question");
                HeaderOfQuestion = Console.ReadLine();
            } while (HeaderOfQuestion == string.Empty);

            do
            {
                Console.WriteLine($"Please Enter The Body Of Question");
                BodyOfQuestion = Console.ReadLine();
            } while (BodyOfQuestion == string.Empty);

            decimal M;
            do
            {
                Console.WriteLine($"Please Enter The Mark Of Question");
            } while (!decimal.TryParse(Console.ReadLine(), out M) || (M <= 0));

            Mark = M;

            int CorrectAnswer =1;
            do
            {
                Console.WriteLine("Please Enter The Correct Answer 1.True   2.False");
            } while (!int.TryParse(Console.ReadLine(), out CorrectAnswer) || (CorrectAnswer != 1 && CorrectAnswer != 2));
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");

            return new Question(HeaderOfQuestion, BodyOfQuestion, Mark, AnswerList, AnswerList[CorrectAnswer - 1]);
        }
    }
}
