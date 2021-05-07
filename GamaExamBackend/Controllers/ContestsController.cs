using GamaExamBackend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamaExamBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContestsController : Controller
    {
        private static readonly string[] DummyAnswer = new[]
        {
            "Ans1", "Ans2", "Ans3", "Ans4", "Ans5"
        };

        private static readonly Contest[] DummyContests = new Contest[]
        {
            new Contest()
            {
                Id = 1,
                Title = "Contest 1",
                Duration = 60,
                NumOfQuestion = 2,
                Questions = new List<Question>
                {
                    new Question()
                    {
                        QuestionNumber = 1,
                        QuestionText = $"hello boys, question num 1",
                        Answers = DummyAnswer,
                        TrueAnswer = 1
                    },
                    new Question()
                    {
                        QuestionNumber = 2,
                        QuestionText = $"hello boys, question num 2",
                        Answers = DummyAnswer,
                        TrueAnswer = 2
                    },
                }
            },
            new Contest()
            {
                Id = 2,
                Title = "Contest 2",
                Duration = 120,
                NumOfQuestion = 4,
                Questions = new List<Question>
                {
                    new Question()
                    {
                        QuestionNumber = 1,
                        QuestionText = $"hello boys, question num 1",
                        Answers = DummyAnswer,
                        TrueAnswer = 1
                    },
                    new Question()
                    {
                        QuestionNumber = 2,
                        QuestionText = $"hello boys, question num 2",
                        Answers = DummyAnswer,
                        TrueAnswer = 2
                    },
                    new Question()
                    {
                        QuestionNumber = 3,
                        QuestionText = $"hello boys, question num 3",
                        Answers = DummyAnswer,
                        TrueAnswer = 3
                    },
                    new Question()
                    {
                        QuestionNumber = 4,
                        QuestionText = $"hello boys, question num 4",
                        Answers = DummyAnswer,
                        TrueAnswer = 4
                    }
                }
            }
        };

        // di atas ini isinya dummy -- belom coba konekin database

        // Kalo return banyak (list/array) --> public IEnumerable<Type>
        // Kalo cuma return 1              --> public Type

        [HttpGet]
        public IEnumerable<Contest> Get()
        {
            return DummyContests;
        }

        [HttpGet("{id}")]
        public Contest Get(long id)
        {
            Contest selectedContest = Array.Find(DummyContests, contest => contest.Id == id);
            return selectedContest;
        }
    }
}
