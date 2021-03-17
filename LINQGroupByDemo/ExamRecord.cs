using System;
using System.Collections.Generic;
using System.Text;

namespace LINQGroupByDemo
{
    public class ExamRecord
    {
        public int ExamId { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public int AnswerId { get; set; }
        public string AnswerHtml { get; set; }

        public static List<ExamRecord> getData()
        {
            List<ExamRecord> list = new List<ExamRecord>()
            {
                new ExamRecord{ ExamId=1, QuestionId=1, Question="Question1", AnswerId=1, AnswerHtml="Option1"},
                new ExamRecord{ ExamId=1, QuestionId=1, Question="Question1", AnswerId=2, AnswerHtml="Option2"},
                new ExamRecord{ ExamId=1, QuestionId=1, Question="Question1", AnswerId=3, AnswerHtml="Option3"},
                new ExamRecord{ ExamId=1, QuestionId=1, Question="Question1", AnswerId=4, AnswerHtml="Option4"},

                new ExamRecord{ ExamId=1, QuestionId=2, Question="Question2", AnswerId=5, AnswerHtml="Option11"},
                new ExamRecord{ ExamId=1, QuestionId=2, Question="Question2", AnswerId=6, AnswerHtml="Option21"},
                new ExamRecord{ ExamId=1, QuestionId=2, Question="Question2", AnswerId=7, AnswerHtml="Option31"},
                new ExamRecord{ ExamId=1, QuestionId=2, Question="Question2", AnswerId=8, AnswerHtml="Option41"},

                new ExamRecord{ ExamId=1, QuestionId=3, Question="Question3", AnswerId=9, AnswerHtml="Option111"},
                new ExamRecord{ ExamId=1, QuestionId=3, Question="Question3", AnswerId=10, AnswerHtml="Option211"},
                new ExamRecord{ ExamId=1, QuestionId=3, Question="Question3", AnswerId=11, AnswerHtml="Option311"},
                new ExamRecord{ ExamId=1, QuestionId=3, Question="Question3", AnswerId=12, AnswerHtml="Option411"}
            };
            return list;
        }
    }
    public class ExamQuestion
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }

    }
    public class ExamQuestionOption
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }

        public List<AnswerOption>? Options { get; set; }
    }
    public class AnswerOption
    {
        public int AnswerId { get; set; }
        public string AnswerHtml { get; set; }
    }
    public class ExamPaper
    {
        public int ExamId { get; set; }
        public List<ExamQuestionOption> Questions { get; set; }
        //public List<AnswerOption> Options { get; set; }
    }
}
