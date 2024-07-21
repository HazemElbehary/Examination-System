﻿namespace Examination_system
{
    internal abstract class Question
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
            set { headerOfQuestion = value ?? "No Question"; }
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
            set { answerList = value ?? [new Answers(1, "No Answer Exist")]; }
        }

        public Answers RightAnswer
        {
            get { return rightAnswer; }
            set { rightAnswer = value ?? answerList[0]; }
        }
        #endregion

        #region Methods
        public abstract Question CreateQuestion();
        protected void GatherCommonQuestionDetails() 
        {
            HeaderOfQuestion = ValidateInputs.PromptForNonEmptyString("Please Enter The Header Of Question");
            BodyOfQuestion = ValidateInputs.PromptForNonEmptyString("Please Enter The Body Of Question");
            Mark = ValidateInputs.PromptForPositiveDecimal("Please Enter The Mark Of Question");
        }

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
