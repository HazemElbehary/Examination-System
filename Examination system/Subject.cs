namespace Examination_system
{
    internal class Subject
    {
        #region Attributes
        int SubId;
        string SubName;
        #endregion

        #region Properties
        public Exam ExamOfTheSubject { get; set; }
        #endregion

        #region Constructor
        public Subject(int SubId, string SubName)
        {
            this.SubId = SubId;
            this.SubName = SubName;
        }
        #endregion

        #region Methods
        public void CreateExam()
        {
            // Read The Type Of Exam Practical Exam OR Final 'Use user-define class ValidateInputs'
            int TypeOfExam = ValidateInputs.PromptForOneORTwoNumber("Please Enter The Type Of The Exam    1.Final Exam    2.Practical Exam");


            // Read The Number Of Questions
            int NumOfQuestions = ValidateInputs.PromptForPositiveInt("Please Enter The Number Of The Questoins");


            // Read The Time Of Exam
            int TimeOfExam = ValidateInputs.PromptForPositiveInt("Please Enter The Time Of The Exam In Second Format");



            // Create Array Of questions 
            Question[] questions = new Question[NumOfQuestions];

            // Final Exam
            if (TypeOfExam == 1)
            {
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    // Read Type Of Question {i+1}
                    int TOfQ = ValidateInputs.PromptForOneORTwoNumber($"Do You Want Question Number 0{i + 1} 1.True False OR 2.MCQ");

                    if (TOfQ == 1)
                    {
                        TrueFalseQuestion trueFalseQuestion = new TrueFalseQuestion();
                        questions[i] = trueFalseQuestion.CreateQuestion();
                    }
                    else
                    {
                        MCQQuestion mCQQuestion = new MCQQuestion();
                        questions[i] = mCQQuestion.CreateQuestion();
                    }
                }
            }

            // Practical Exam
            else
            {
                for (int i = 0; i < NumOfQuestions; i++)
                {
                    MCQQuestion mCQQuestion = new MCQQuestion();
                    questions[i] = mCQQuestion.CreateQuestion();
                }
            }

            if (TypeOfExam == 1)
                ExamOfTheSubject = new FinalExam(TimeOfExam, NumOfQuestions, questions, TypeOfExam);
            else
                ExamOfTheSubject = new PracticalExam(TimeOfExam, NumOfQuestions, questions, TypeOfExam);

        } 
        #endregion
    }
}
