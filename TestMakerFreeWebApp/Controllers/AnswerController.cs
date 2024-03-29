﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TestMakerFreeWebApp.ViewModels;

namespace TestMakerFreeWebApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Answer")]
    public class AnswerController : Controller
    {
        #region RESTful conventions methods 

        /// <summary> 
        /// Retrieves the Answer with the given {id}
        /// </summary> 
        /// &lt;param name="id">The ID of an existing Answer</param> 
        /// <returns>the Answer with the given {id}</returns> 
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Content("Not implemented (yet)!");

        }

        /// <summary>    
        /// Adds a new Answer to the Database
        /// </summary>
        /// <param name="m">The AnswerViewModel containing the data to insert</param> 
        [HttpPut]
        public IActionResult Put(AnswerViewModel m)
        {
            throw new NotImplementedException();
            
        }

        /// <summary> 
        /// Edit the Answer with the given {id} 
        /// </summary> 
        /// <param name="m">The AnswerViewModel containing the data to update</param> 
        [HttpPost]
        public IActionResult Post(AnswerViewModel m)
        {
            throw new NotImplementedException(); 
            
        }

        /// <summary> 
        /// Deletes the Answer with the given {id} from the Database 
        /// </summary> /// <param name="id">The ID of an existing Answer</param> 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            throw new NotImplementedException();
            
        }
        #endregion 



        //GET api/answer/all
        [HttpGet("All/{questionId}")]
        public IActionResult All(int questionId)
        {
            var sampleAnswers = new List<AnswerViewModel>();

            //Add the first sample answer
            sampleAnswers.Add(new AnswerViewModel()
            {
                Id = 1,
                QuestionId = questionId,
                Text = "Family and friends",
                CreatedDate = DateTime.Now,
                LastModifiedDate = DateTime.Now
            });

            //Add a bunch of sample answers
            for (int i =2; i <= 5; i++)
            {
                sampleAnswers.Add(new AnswerViewModel()
                {
                    Id = i,
                    QuestionId = questionId,
                    Text = $"Sample Answer {i}",
                    CreatedDate = DateTime.Now,
                    LastModifiedDate = DateTime.Now
                });
            }

            //output the results in Json format
            return new JsonResult(sampleAnswers, new JsonSerializerSettings()
                {
                    Formatting = Formatting.Indented
                });
        }

    }
}