namespace Examination_system
{
    internal class Question
    {
        #region Attributes
        string headerOfQuestion;
        string bodyOfQuestion;
        decimal mark;
        Answers[] answerList;
        Answers rightAnswer;
        #endregion

        #region Constructors
        public Question()
        {
            
        }
        public Question(string headerOfQuestion, string bodyOfQuestion, decimal mark, Answers[] answerList, Answers rightAnswer)
        {
            HeaderOfQuestion = headerOfQuestion;
            BodyOfQuestion = bodyOfQuestion;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;
        }

        #endregion

        #region Properties
        public string HeaderOfQuestion
        {
            get { return headerOfQuestion; }
            set { headerOfQuestion = value ?? string.Empty; }
        }

        public string BodyOfQuestion
        {
            get { return bodyOfQuestion; }
            set { bodyOfQuestion = value ?? string.Empty; }
        }

        public decimal Mark
        {
            get { return mark; }
            set { mark = value <= 0 ? 1 : value; }
        }

        public Answers[] AnswerList
        {
            get { return answerList; }
            set { answerList = value ?? [new Answers(Answers.AnswerCounter, "No Answer Exist")]; }
        }

        public Answers RightAnswer
        {
            get { return rightAnswer; }
            set { rightAnswer = value ?? answerList[0]; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            string QuestionItSelf = HeaderOfQuestion + "\n" + BodyOfQuestion;
            string Answers = "";
            for (int i = 0; i < AnswerList.Length; i++)
            {
                Answers += $"{i+1}. " + AnswerList[i] + "\n";
            }
            return QuestionItSelf + "\n" + Answers;
        }
        #endregion
    }
}
