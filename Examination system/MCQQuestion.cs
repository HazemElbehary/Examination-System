namespace Examination_system
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string headerOfQuestion, string bodyOfQuestion, decimal mark, Answers[] answerList, Answers rightAnswer) : base(headerOfQuestion, bodyOfQuestion, mark, answerList, rightAnswer)
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

            AnswerList = new Answers[3];
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

            int CorrectAnswer = 1;
            do
            {
                Console.WriteLine($"Please Enter The Correct Answer:\n1.{AnswerList[0]}\n2.{AnswerList[1]}\n3.{AnswerList[2]}");
            } while (!int.TryParse(Console.ReadLine(), out CorrectAnswer) || (CorrectAnswer != 1 && CorrectAnswer != 2 && CorrectAnswer != 3));


            return new Question(HeaderOfQuestion, BodyOfQuestion, Mark, AnswerList, AnswerList[CorrectAnswer - 1]);
        }
    }
}
