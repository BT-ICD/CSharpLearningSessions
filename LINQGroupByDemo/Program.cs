using System;
using System.Linq;

namespace LINQGroupByDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ExamPaper paper = new ExamPaper();
            paper.ExamId = 1;
            var result = ExamRecord.getData();
            var subjectList = (from c in result
                               group c by new { QuestionId = c.QuestionId, Question = c.Question }
                            into g
                               select new ExamQuestion()
                               {
                                   QuestionId = g.Key.QuestionId,
                                   Question = g.Key.Question
                               }).ToList();

            Console.WriteLine(subjectList.Count);
            //paper.Questions = new System.Collections.Generic.List<ExamQuestion>();
            //paper.Questions.AddRange(subjectList);
            foreach (var item in subjectList)
            {
                Console.WriteLine(item.Question);
                var result2 = result.Where(c => c.QuestionId == item.QuestionId);
                var ansOptions = (from c in result2
                                  group c by new { AnswerId = c.AnswerId, AnswerHtml = c.AnswerHtml } into g
                                  select new AnswerOption()
                                  {
                                      AnswerId = g.Key.AnswerId,
                                      AnswerHtml = g.Key.AnswerHtml
                                  }).ToList();
                
            }
            Console.WriteLine(paper.Questions.Count);

        }
    }
}
