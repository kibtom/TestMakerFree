using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestMakerFreeWebApp.ViewModels;

namespace TestMakerFreeWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        #region RESTful conventions methods 

        /// <summary> 
        /// Retrieves the Question with the given {id}
        /// </summary> 
        /// &lt;param name="id">The ID of an existing Question</param> 
        /// <returns>the Question with the given {id}</returns> 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Content("Not implemented (yet)!");

        }

        /// <summary>    
        /// Adds a new Question to the Database
        /// </summary>
        /// <param name="m">The QuestionViewModel containing the data to insert</param> 
        [HttpPut]
        public IActionResult Put(QuestionViewModel m)
        {
            throw new NotImplementedException();

        }

        /// <summary> 
        /// Edit the Question with the given {id} 
        /// </summary> 
        /// <param name="m">The QuestionViewModel containing the data to update</param> 
        [HttpPost]
        public IActionResult Post(QuestionViewModel m)
        {
            throw new NotImplementedException();

        }

        /// <summary> 
        /// Deletes the Question with the given {id} from the Database 
        /// </summary> /// <param name="id">The ID of an existing Question</param> 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();

        }
        #endregion 

        // GET api/question/all        
        [HttpGet("All/{quizId}")] 
        public IActionResult All(int quizId)
        {
            var sampleQuestions = new List<QuestionViewModel>();

            //Add first sample question
            sampleQuestions.Add(new QuestionViewModel()
            {
              Id  = 1,
              QuizId = quizId,
              Text = "What do you value most in life",
              CreatedDate = DateTime.Now,
              LastModifiedDate = DateTime.Now
            });

            //Add a bunch of sample question
            for (int i = 2; i <= 5; i++)
            {
                sampleQuestions.Add(new QuestionViewModel()
                {
                    Id = i,
                    QuizId = quizId,
                    Text = $"Sample Question {i}",
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }

            //output the results in Json format
            return  new JsonResult(
                sampleQuestions, new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }
    }
}