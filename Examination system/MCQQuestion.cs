namespace Examination_system
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string headerOfQuestion, string bodyOfQuestion, decimal mark, Answers[] answerList, Answers rightAnswer) : base(headerOfQuestion, bodyOfQuestion, mark, answerList, rightAnswer)
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

            int CorrectAnswer = 1;
            do
            {
                Console.WriteLine("Please Enter The Correct Answer 1.Answer01   2.Answer02   3.Answer03");
            } while (!int.TryParse(Console.ReadLine(), out CorrectAnswer) || (CorrectAnswer != 1 && CorrectAnswer != 2 && CorrectAnswer != 3));

            for (int i = 0; i < 3; i++)
            {
                string a;
                do
                {
                    Console.WriteLine($"Please Enter Answer Number 0{i + 1}");
                    a = Console.ReadLine();
                } while (a is null || a == string.Empty);
                AnswerList[i] = new Answers(i + 1, a);
            }

            return new Question(HeaderOfQuestion, BodyOfQuestion, Mark, AnswerList, AnswerList[CorrectAnswer]);
        }
    }
}
