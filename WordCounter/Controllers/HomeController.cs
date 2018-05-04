using System;
using WordCounterApp.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterApp.Controllers
{
      public class HomeController : Controller
      {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
        [HttpPost("/submit")]
        public ActionResult Submit()
        {
          // WordCounter newWordCounter = new WordCounter ((Request.Form["word-input"]), (Request.Form["sentence"]));
          //  int NumberOfWords = newWordCounter.CountWords((Request.Form["word-input"]), (Request.Form["sentence"]));
          return View("Index");
        }
      }
}
