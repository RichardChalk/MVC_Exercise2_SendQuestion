using Microsoft.AspNetCore.Mvc;
using SendQuestion.Models;
using SendQuestion.ViewModels;

namespace SendQuestion.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SendQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendQuestion(QuestionViewModel questionVM)
        {
            if (ModelState.IsValid)
            {
                // This is where we can save to the database (if we had one!)
                // _context.SaveChanges();

                return RedirectToAction("QuestionConfirmation", questionVM);
            }

            return View(questionVM);
        }

        public IActionResult QuestionConfirmation(QuestionViewModel questionVM)
        {
            return View(questionVM);
        }
    }
}
