using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestMakerFreeWebApp.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestMakerFreeWebApp.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Content("Not implemented (yet)!");
        }

        ///<summary>
        ///Adds a new Question to the Database
        ///</summary>
        ///<param>
        ///The QuestionViewModel containing the data
        ///</param>
        [HttpPut]
        public IActionResult Put(QuestionViewModel model)
        {
            throw new NotImplementedException();
        }
        ///<summary>
        ///Edit the Question with a given {id}
        ///</summary>
        ///<param>
        ///The QuestionViewModel containing the data
        ///</param>
        [HttpPost]
        public IActionResult Post(QuestionViewModel model)
        {
            throw new NotImplementedException();
        }
        //GET api/question/all
        [HttpGet("All/{quizId}")]
        public IActionResult All(int quizId)
        {
            var sampleQuestions = new List<QuestionViewModel>();

            //add sample questions
            for (int i = 2; i <= 5; i++)
            {
                sampleQuestions.Add(new QuestionViewModel
                {
                    Id = i,
                    QuizId = quizId,
                    Text = $"What do you value most in your life? {i}",
                    CreatedDate = DateTime.Now,
                    LastModiFiedDate = DateTime.Now
                });
            }
            //output the result in JSON format
            return new JsonResult(
                sampleQuestions,
                new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }

    }
}
