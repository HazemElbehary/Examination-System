namespace Examination_system
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion()
        {
            
        }
        public TrueFalseQuestion(string headerOfQuestion, string bodyOfQuestion, decimal mark, Answers[] answerList, Answers rightAnswer) : base(headerOfQuestion, bodyOfQuestion, mark, answerList, rightAnswer)
        {
        }

        public override Question CreateQuestion()
        {
            base.GatherCommonQuestionDetails();

            int CorrectAnswer =1;
            do
            {
                Console.WriteLine("Please Enter The Correct Answer 1.True   2.False");
            } while (!int.TryParse(Console.ReadLine(), out CorrectAnswer) || (CorrectAnswer != 1 && CorrectAnswer != 2));
            AnswerList = new Answers[2];
            AnswerList[0] = new Answers(1, "True");
            AnswerList[1] = new Answers(2, "False");

            return new TrueFalseQuestion(HeaderOfQuestion, BodyOfQuestion, Mark, AnswerList, AnswerList[CorrectAnswer - 1]);
        }
    }
}
