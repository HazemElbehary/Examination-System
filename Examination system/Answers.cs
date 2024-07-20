namespace Examination_system
{
    internal class Answers
    {
        #region Attributes
        int answerId;
        string answerText;
        #endregion

        #region Constructors
        public Answers(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        } 
        #endregion

        #region Properties
        public int AnswerId
        {
            get { return answerId; }
            set
            {
                answerId = value < 1 ? 1 : value;
            }
        }

        public string AnswerText
        {
            get { return answerText; }
            set { answerText = value is null ? string.Empty : value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return answerText ?? string.Empty;
        }
        #endregion
    }
}
