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
    public class QuestionsController : Controller
    {
        private static readonly string[] DummyAnswer = new[]
        {
            "Ans1", "Ans2", "Ans3", "Ans4", "Ans5"
        };

        // Kalau yang dikirim banyak (array/list), pake IEnumerable<Type>
        // Arrow functionnya mirip kek di javascript ternyata.. mirip lambda di python juga

        [HttpGet]
        public IEnumerable<Question> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 20).Select(index => new Question
            {
                QuestionNumber = index,
                QuestionText = $"hello boys, question goes here... index: {index}",
                Answers = DummyAnswer,
                TrueAnswer = rng.Next(0, 5)
            })
            .ToArray();
        }
    }
}
